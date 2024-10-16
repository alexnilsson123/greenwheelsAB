namespace GreenwheelsAB
{
    public class Hyra
    {
        public int HyraID { get; set; }
        public int AnvändarID { get; set; }
        public int FordonID { get; set; }
        public DateTime Starttid { get; set; }
        public DateTime? Sluttid { get; set; } 
        public decimal Kostnad { get; set; } 

        public Hyra(int hyraID, int användarID, int fordonID)
        {
            HyraID = hyraID;
            AnvändarID = användarID;
            FordonID = fordonID;
            Starttid = DateTime.Now; 
        }
    }

}
