using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projekt.Models
{
    public class Wyniki
    {
        [Key]
        public int idwyniki { get; set; }
        public int wynik { get; set; }

        public virtual Zawodnik Zawodnik { get; set; } // dzięki temu będziemy mieli dostęp danych zawodnika dla konkretnego idwyniku
        public virtual Miejscowosci Miejscowosci { get; set; } // dzięki temu będziemy mieli dostęp miejscowosci dla konkretnego idwyniku

    }
}
