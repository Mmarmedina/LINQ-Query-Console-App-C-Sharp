using LINQ_Query_Console_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Query_Console_App.Models
{
    public class Municipio: IMunicipio
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }

        public static List<Municipio> GetMunicipios()
        {
            return new List<Municipio>
            {
                new Municipio { Id = 1, Nombre = "Cádiz"},
                new Municipio { Id = 2, Nombre = "Málaga"},
                new Municipio { Id = 3, Nombre = "Sevilla"},
                new Municipio { Id = 4, Nombre = "Almería"},
            };
        }
    }
}
