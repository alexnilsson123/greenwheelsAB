using GreenwheelsAB;
using System.Security.Cryptography.X509Certificates;

namespace ServiceLayer
{

    internal class InMemoryDataBase
    {

        internal List<Hyra> hyra;
        internal List<Fordon> fordon;
        internal List<Användare> användare;
        internal List<Station> station;
        internal List<Administratör> administratör;

        public InMemoryDataBase()
        {
            användare = new List<Användare>();
            hyra = new List<Hyra>();
            fordon = new List<Fordon>();
            station = new List<Station>();
            administratör = new List<Administratör>();
            
            seed();
            
        }




    private void seed()
        {
            #region Skapa Användare
            användare.Add(new Användare(1, "Ali", "Basha", "Ali_Fotboll@gmail.com"));
            användare.Add(new Användare(2, "Alex", "Nilsson", "Alex_bäst@hotmail.com"));
            användare.Add(new Användare(3, "Lara", "Johannesmeyer", "Minecraft_larissa@live.se"));
            användare.Add(new Användare(4, "Osama", "AlHussein", "Ossi03@gmail.com"));
            användare.Add(new Användare(5, "Varto", "Kaka", "Varto2007@hotmail.com"));
            användare.Add(new Användare(6, "Husein", "Zeinedine", "Malamore@gmail.com"));
            användare.Add(new Användare(7, "Hassan", "Zeinedine", "Zlatan@live.com"));
            #endregion



            #region Skapa Station

            var station1 = new Station(1, "Rinkeby Station", "Stockholm");
            var station2 = new Station(2, "Los Angered Station", "Göteborg");
            var station3 = new Station(3, "Rosengård station", "Malmö");
            #endregion



            #region Skapa Fordon
            var fordon1 = new Fordon(1, "El Scooter", 80, "Ledig", 1);
            var fordon2 = new Fordon(2, "El Scooter", 75, "Ledig", 1);
            var fordon3 = new Fordon(3, "El Cyckel", 92, "Ledig", 1);
            var fordon4 = new Fordon(4, "El Scooter", 91, "Ledig", 2);
            var fordon5 = new Fordon(5, "El Cyckel", 100, "Ledig", 2);
            var fordon6 = new Fordon(6, "El Cyckel", 83, "Ledig", 2);
            var fordon7 = new Fordon(7, "El Scooter", 100, "Ledig", 3);
            var fordon8 = new Fordon(8, "El Scooter", 61, "Ledig", 3);
            #endregion



            #region Lägg Fordon i station
            station.AddRange(new[] { station1, station2, station3 });

            // Lägg till fordon till databasen
            fordon.AddRange(new[] { fordon1, fordon2, fordon3, fordon4, fordon5,fordon6,fordon7,fordon8 });

            // Lägg till fordon till rätt station
            station1.AntalTillgängligaFordon.Add(fordon1);
            station1.AntalTillgängligaFordon.Add(fordon2);
            station1.AntalTillgängligaFordon.Add(fordon3);
            station2.AntalTillgängligaFordon.Add(fordon4);
            station2.AntalTillgängligaFordon.Add(fordon5);
            station2.AntalTillgängligaFordon.Add(fordon6);
            station3.AntalTillgängligaFordon.Add(fordon7);
            station3.AntalTillgängligaFordon.Add(fordon8);
#endregion


        }

    }
}
