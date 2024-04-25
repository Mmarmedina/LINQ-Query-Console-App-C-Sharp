using LINQ_Query_Console_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Query_Console_App.Models
{
    public class Adosado : Vivienda, IAdosado
    {
        public int Id { get; set; }
        public Boolean Piscina { get; set; }

        public static List<Adosado> GetAdosados()
        {
            return new List<Adosado>
            {
                new Adosado { Id = 1, Tamano = 160, Nombre = "Adosado1", NumeroHabitaciones = 3, NumeroBanos = 3 , Piscina = true, MunicipioId = 1 },
                new Adosado { Id = 2, Tamano = 170, Nombre = "Adosado2", NumeroHabitaciones = 4, NumeroBanos = 2 , Piscina = false, MunicipioId = 2 },
                new Adosado { Id = 3, Tamano = 180, Nombre = "Adosado3", NumeroHabitaciones = 5, NumeroBanos = 3 , Piscina = true, MunicipioId = 3 },
                new Adosado { Id = 4, Tamano = 190, Nombre = "Adosado4", NumeroHabitaciones = 5, NumeroBanos = 2 , Piscina = false, MunicipioId = 4 },
            };
        }
    }
}
