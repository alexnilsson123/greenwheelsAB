namespace GreenwheelsAB
{
    
    public class Hyra
    {
        public int HyraID { get; set; }
        public Användare Användare { get; set; }  
        public Fordon Fordon { get; set; }        
        public DateTime Starttid { get; set; }
        public DateTime? Sluttid { get; set; }
        public decimal Kostnad { get; set; }

        public int AnvändarID => Användare.AnvändarID;
        public int FordonID => Fordon.FordonID;

        public Hyra(int hyraID, Användare användare, Fordon fordon)
        {
            HyraID = hyraID;
            Användare = användare ;
            Fordon = fordon;
            Starttid = DateTime.Now;
        }
    }


}
