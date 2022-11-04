using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPPrueba.Models
{
    public class Claims
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public DateTime Date { get; set; }

        public Vehicles Vehicule_Id { get; set; }


    }
}
