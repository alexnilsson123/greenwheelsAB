namespace GreenwheelsAB
{
    public class Fordon
    {
        public int FordonID { get; set; }
        public string Typ { get; set; }
        public int BatteriNivå { get; set; }
        public string Status { get; set; }
        public int? StationID { get; set; } 

        public Fordon(int fordonID, string typ, int batteriNivå, string status, int? stationID)
        {
            FordonID = fordonID;
            Typ = typ;
            BatteriNivå = batteriNivå;
            Status = status;
            StationID = stationID;
        }
    }

}
