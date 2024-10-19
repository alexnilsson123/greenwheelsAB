using GreenwheelsAB;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ServiceLayer
{
    public class LogicLayer
    {
        private InMemoryDataBase inmemorydatabase = new InMemoryDataBase();



        public List<Användare> HämtaAnvändare()
        {
            return inmemorydatabase.användare;
        }


        public List<Fordon> HämtaAllaFordon()
        {
            return inmemorydatabase.fordon;
        }


        public List<Station> HämtaStationer()
        {
            return inmemorydatabase.station;
        }


        public List<Fordon> VisaTillgängligaFordon(Station station)
        {
            return station.AntalTillgängligaFordon.Where(f => f.Status == "Ledig").ToList();
        }

        public void TaBortFordon(Fordon fordon)
        {
            inmemorydatabase.fordon.Remove(fordon);
            foreach (var station in inmemorydatabase.station)
            {
                station.AntalTillgängligaFordon.Remove(fordon); 
            }
        }

        public void LäggTillNyttFordon(Fordon fordon)
        {
            inmemorydatabase.fordon.Add(fordon);
        }



        public void UppdateraFordonStatus(Fordon fordon, string status)
        {
            fordon.Status = status;
        }


        public void LäggTillHyra(Användare användare, Fordon fordon)
        {
            int nyttHyraID = inmemorydatabase.hyra.Count + 1;  
            Hyra nyHyra = new Hyra(nyttHyraID, användare, fordon);  
            användare.HyresHistorik.Add(nyHyra);
            inmemorydatabase.hyra.Add(nyHyra);
        }

        public List<Hyra> HämtaHyresHistorik(Användare användare)
        {
            return användare.HyresHistorik;
        }

        public bool HyraFordon(Användare användare, Fordon fordon, Station station)
        {
            var aktivHyra = användare.HyresHistorik.FirstOrDefault(h => h.Sluttid == null);
            if (aktivHyra != null)
            {
                return false; 
            }

            UppdateraFordonStatus(fordon, "Uthyrd");
            station.AntalTillgängligaFordon.Remove(fordon);
            LäggTillHyra(användare, fordon);

            return true;
        }

        public List<Hyra> HämtaAktivaHyror(Användare användare)
        {
            return användare.HyresHistorik.Where(h => h.Sluttid == null).ToList();
        }



        public string AvslutaHyraOchVisaKostnad(Hyra hyra, Station nyStation)
        {
            if (hyra != null && hyra.Sluttid == null)
            {
                hyra.Sluttid = DateTime.Now;
                hyra.Kostnad = BeräknaKostnad(hyra.Starttid, hyra.Sluttid.Value);

                UppdateraFordonStatus(hyra.Fordon, "Ledig");

                hyra.Fordon.Station.AntalTillgängligaFordon.Remove(hyra.Fordon);
                hyra.Fordon.Station = nyStation;
                nyStation.AntalTillgängligaFordon.Add(hyra.Fordon);

                return $"Hyra avslutad och fordon återlämnat till station {nyStation.StationID}. Kostnad: {hyra.Kostnad:C}";
            }

            return "Hyra kunde inte avslutas. Kontrollera hyresinformationen.";
        }

        private decimal BeräknaKostnad(DateTime starttid, DateTime sluttid)
        {
            TimeSpan hyrtid = sluttid - starttid;
            decimal kostnadPerMinut = 20.0M;
            return (decimal)hyrtid.TotalMinutes * kostnadPerMinut;
        }
    }



}
