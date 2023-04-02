using System.ComponentModel.DataAnnotations;

namespace projekt.Models
{
    public class Miejscowosci
    {
        [Key]
        public int idmiejscowosci { get; set; }
        public string nazwa_miejscowosci { get; set; }

        public string kraj_miejscowosci { get; set; }

        public Miejscowosci()
        {
            nazwa_miejscowosci = "";
            kraj_miejscowosci = "";
        }
    }
}
