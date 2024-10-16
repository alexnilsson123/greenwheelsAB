namespace GreenwheelsAB
{
    public class Användare
    {
        public int AnvändarID { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Email { get; set; }
        public bool Betalningsmetod { get; set; } = true;
        public List<Hyra> HyresHistorik { get; set; }

        public Användare(int användarID, string förnamn, string efternamn, string email)
        {
            AnvändarID = användarID;
            Förnamn = förnamn;
            Efternamn = efternamn;
            Email = email;
            HyresHistorik = new List<Hyra>();
        }
    }
}
