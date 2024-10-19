namespace GreenwheelsAB
{
    
    public class Fordon
    {
        public int FordonID { get; set; }
        public string Typ { get; set; }
        public int BatteriNivå { get; set; }
        public string Status { get; set; }
        public Station Station { get; set; }
        public int StationID => Station.StationID;


        public Fordon(int fordonID, string typ, int batteriNivå, string status, Station station)
        {
            FordonID = fordonID;
            Typ = typ;
            BatteriNivå = batteriNivå;
            Status = status;
            Station = station;
        }
    }

}
