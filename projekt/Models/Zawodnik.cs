using projekt.Models;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace projekt.Models
{

    public class Zawodnik
    {
        [Key]
        public int idzawodnicy { get; set; }
        public string imie_zawodnika { get; set; }

        public string nazwisko_zawodnika { get; set; }

        public string kraj_pochodzenia { get; set; }

    }
}
