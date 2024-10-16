namespace GreenwheelsAB
{
    public class Station
    {
        public int StationID { get; set; }
        public string Namn { get; set; }
        public string Plats { get; set; }
        public List<Fordon> AntalTillgängligaFordon { get; set; }

        public int AntalFordon => AntalTillgängligaFordon?.Count ?? 0;

        public Station(int stationID, string namn, string plats)
        {
            StationID = stationID;
            Namn = namn;
            Plats = plats;
            AntalTillgängligaFordon = new List<Fordon>();
        }

    }
}
