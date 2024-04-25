using LINQ_Query_Console_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Query_Console_App.Models
{
    public class Vivienda: IVivienda
    {
        public int Tamano { get; set; }
        public string Nombre { get; set; }
        public int NumeroHabitaciones { get; set; }
        public int NumeroBanos { get; set; }
        public int MunicipioId { get; set; }
     
    }
}
