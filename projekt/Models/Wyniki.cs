using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projekt.Models
{
    public class Wyniki
    {
        [Key]
        public int idwyniki { get; set; }
        [ForeignKey("idzawodnicy")]
        public int idzawodnicy { get; set; }
        [ForeignKey("idmiejscowosci")]
        public int idmiejscowosci { get; set; }
        public int wynik { get; set; }

        public Wyniki()
        {
        }
    }
}
