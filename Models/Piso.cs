using LINQ_Query_Console_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Query_Console_App.Models
{
    public class Piso: Vivienda, IPiso
    {
        public int Id { get; set; }
        public int NumeroPlanta {  get; set; }

        public static List<Piso> GetPisos()
        {
            return new List<Piso>
            {
                new Piso { Id = 1, Tamano = 90, Nombre = "Piso1", NumeroHabitaciones = 2, NumeroBanos = 2 , NumeroPlanta = 2, MunicipioId = 1 },
                new Piso { Id = 2, Tamano = 105, Nombre = "Piso2", NumeroHabitaciones = 4, NumeroBanos = 2 , NumeroPlanta = 1, MunicipioId = 2 },
                new Piso { Id = 3, Tamano = 85, Nombre = "Piso3", NumeroHabitaciones = 3, NumeroBanos = 2 , NumeroPlanta = 3, MunicipioId = 3 },
                new Piso { Id = 4, Tamano = 150, Nombre = "Piso4", NumeroHabitaciones = 5, NumeroBanos = 2 , NumeroPlanta = 4, MunicipioId = 4 }
            };
        }  
    }

    
}
