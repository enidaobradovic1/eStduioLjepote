namespace eStudioLjepote.Model
{
    public class ZaposleniciUloge
    {
        public int Id { get; set; }
        public int UlogaId { get; set; }

        public  Uloge Uloga { get; set; }
    }
}