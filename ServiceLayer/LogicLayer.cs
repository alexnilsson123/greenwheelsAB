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


        public void RemoveFordon(Fordon fordon)
        {
            inmemorydatabase.fordon.Remove(fordon);
            foreach (var station in inmemorydatabase.station)
            {
                var fordonPåStation = station.AntalTillgängligaFordon.FirstOrDefault(f => f.FordonID == fordon.FordonID);
                if (fordonPåStation != null)
                {
                    station.AntalTillgängligaFordon.Remove(fordonPåStation);
                }
            }

        }


        public List<Fordon> HämtaAllaFordon()
        {
            return inmemorydatabase.fordon;
        }



        public List<Station> HämtaStationer()
        {
            return inmemorydatabase.station;
        }

        public List<Hyra> HämtaHyresHistorik(int användarID)
        {
            return inmemorydatabase.hyra.Where(h => h.AnvändarID == användarID).ToList();
        }

        public List<Fordon> VisaTillgängligaFordon(int stationID)
        {
            return inmemorydatabase.fordon.Where(f => f.StationID == stationID && f.Status == "Ledig" && inmemorydatabase.fordon.Contains(f)).ToList();
        }


        public void UppdateraFordonStatus(int fordonID, string status)
        {
            var fordon = inmemorydatabase.fordon.FirstOrDefault(f => f.FordonID == fordonID);
            if (fordon != null)
            {
                fordon.Status = status;
            }
        }


        // Lägg till en ny hyra i hyreshistoriken
        public void LäggTillHyra(int användarID, int fordonID)
        {
            int nyttHyraID = inmemorydatabase.hyra.Count + 1;
            Hyra nyHyra = new Hyra(nyttHyraID, användarID, fordonID);
            inmemorydatabase.hyra.Add(nyHyra);

            foreach (var användare in inmemorydatabase.användare)
            {
                if (användare.AnvändarID == användarID)
                {
                    användare.HyresHistorik.Add(nyHyra);
                    break;
                }
            }
        }



        public bool HyraFordon(int användarID, int fordonID, int stationID)
        {
            // Kontrollera om användaren redan har ett fordon hyrt
            var aktivHyra = inmemorydatabase.hyra.FirstOrDefault(h => h.AnvändarID == användarID && h.Sluttid == null);
            if (aktivHyra != null)
            {
                return false;
            }


            UppdateraFordonStatus(fordonID, "uthyrd");


            // Ta bort fordonet från stationens lista över tillgängliga fordon
            var station = inmemorydatabase.station.FirstOrDefault(s => s.StationID == stationID);
            if (station != null)
            {
                var fordon = station.AntalTillgängligaFordon.FirstOrDefault(f => f.FordonID == fordonID);
                if (fordon != null)
                {
                    station.AntalTillgängligaFordon.Remove(fordon);
                }
            }
            LäggTillHyra(användarID, fordonID);

            return true;
        }

        public List<Hyra> HämtaAktivaHyror(int användarID)
        {
            return inmemorydatabase.hyra.Where(h => h.AnvändarID == användarID && h.Sluttid == null).ToList();
        }




        public string AvslutaHyraOchVisaKostnad(int hyraID, int stationID)
        {
            var hyra = inmemorydatabase.hyra.FirstOrDefault(h => h.HyraID == hyraID);
            if (hyra != null && hyra.Sluttid == null)
            {
                hyra.Sluttid = DateTime.Now;
                hyra.Kostnad = BeräknaKostnad(hyra.Starttid, hyra.Sluttid.Value);


                UppdateraFordonStatus(hyra.FordonID, "Ledig");

                // Lägg tillbaka fordonet i den station användaren har valt
                var station = inmemorydatabase.station.FirstOrDefault(s => s.StationID == stationID);
                if (station != null)
                {
                    var fordon = inmemorydatabase.fordon.FirstOrDefault(f => f.FordonID == hyra.FordonID);
                    if (fordon != null)
                    {

                        fordon.StationID = stationID;


                        station.AntalTillgängligaFordon.Add(fordon);
                    }
                }

                return $"Hyra avslutad och fordon återlämnat till station {stationID}. Kostnad: {hyra.Kostnad:C}";
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
