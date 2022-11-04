using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPPrueba.Models
{
    public class Vehicles
    {
        [Key]
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Vin { get; set; }

        public string Color { get; set; }

        public int Year { get; set; }

        public Owners Obner_ID { get; set; }

    }
}
