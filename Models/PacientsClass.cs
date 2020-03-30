using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class PacientsClass
    {
        [Key]
        public int PacientID { get; set; }

        public string PacientName { get; set; }

        public string PacientSurname { get; set; }

        public string PacientThirdName { get; set; }

        public string PacientEmail { get; set; }

        public string PacientTelephone { get; set; }

    }
}
