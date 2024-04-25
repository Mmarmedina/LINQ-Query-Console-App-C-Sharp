using LINQ_Query_Console_App.Interfaces;
using LINQ_Query_Console_App.Models;

namespace LINQ_Query_Console_App
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            List<Municipio> municipios = Municipio.GetMunicipios();
            List<Piso> pisos = Piso.GetPisos();
            List<Adosado> adosados = Adosado.GetAdosados();

            GetAllMunicipios(municipios);
            GetPisosWithMunicipios(pisos, municipios);
            GetAdosadosWithMunicipios(adosados, municipios);
            GetPisosInCadiz(pisos, municipios);
            GetAdosadosInCadiz(adosados, municipios);
            GetPisosThreeOrMoreRooms(pisos);
            GetAdosadosFourOrMoreRooms(adosados);
            GetAdosadosWithPool(adosados);
            GetPisos105metersOrMore(pisos);
            GetAdosados170metersOrMore(adosados);

            PrintTableMunicipios(municipios);
            PrintTablePisos(pisos);
            PrintTableAdosados(adosados);
        }
        public static void GetAllMunicipios(List<Municipio> municipios)
        {
            Console.WriteLine("1. Sacar por pantalla un listado de los municipios.");

            foreach (var municipio in municipios)
            {
                Console.WriteLine(municipio.Nombre);
            }

            Console.WriteLine();

        }
        public static void GetPisosWithMunicipios(List<Piso> pisos, List<Municipio> municipios)
        {
            Console.WriteLine("2. Sacar un listado de pisos y el municipio al que pertenecen.");

            var pisosWithMunicipios = pisos
            .Join(municipios,
                    p => p.MunicipioId,
                    m => m.Id,
                    (p, m) => new { Piso = p.Nombre, Municipio = m.Nombre })
            .ToList();

            foreach (var pisoWithMunicipio in pisosWithMunicipios)
            {
                Console.WriteLine($"{pisoWithMunicipio.Piso}: {pisoWithMunicipio.Municipio}");
            }

            Console.WriteLine();
        }
        public static void GetAdosadosWithMunicipios(List<Adosado> adosados, List<Municipio> municipios)
        {
            Console.WriteLine("3. Sacar un listado de adosados y el municipio al que pertenecen.");

            var adosadosWithMunicipios = adosados
                .Join(municipios,
                        a => a.Id,
                        m => m.Id,
                        (a, m) => new { Adosado = a.Nombre, Municipio = m.Nombre })
                .ToList();


            foreach (var adosadoWithMunicipio in adosadosWithMunicipios)
            {
                Console.WriteLine($"{adosadoWithMunicipio.Adosado}: {adosadoWithMunicipio.Municipio}");
            }

            Console.WriteLine();
        }
        public static void GetPisosInCadiz(List<Piso> pisos, List<Municipio> municipios)
        {
            Console.WriteLine("4. Sacar un listado de pisos filtrando por nombre de Municipio -> Cádiz.");

            var pisosInCadiz = pisos
                .Join(municipios, 
                        p => p.MunicipioId,
                        m => m.Id,
                        (p, m) => new { Piso = p.Nombre, Municipio = m.Nombre })
                .Where(x => x.Municipio == "Cádiz")
                .ToList();

            foreach (var pisoInCadiz in pisosInCadiz)
            {
                Console.WriteLine($"{pisoInCadiz.Piso}: {pisoInCadiz.Municipio}");
            }

            Console.WriteLine();
        }
        public static void GetAdosadosInCadiz(List<Adosado> adosados, List<Municipio> municipios)
        {
            Console.WriteLine("5. Sacar un listado de adosados filtrado por nombre de municipio -> Cádiz.");

            var adosadosInCadiz = adosados
                .Join(municipios,
                        a => a.MunicipioId,
                        m => m.Id,
                        (a, m) => new { Adosado = a.Nombre, Municipio = m.Nombre })
                .Where(x => x.Municipio == "Cádiz")
                .ToList();

            foreach (var adosadoInCadiz in adosadosInCadiz)
            {
                Console.WriteLine($"{adosadoInCadiz.Adosado}: {adosadoInCadiz.Municipio}");
            }

            Console.WriteLine();

        }
        public static void GetPisosThreeOrMoreRooms(List<Piso> pisos)
        {
            Console.WriteLine("6. Sacar un listado de pisos que tengan 3 o más habitaciones.");

            int numberFilter = 3;

            var pisosThreeOrMoreRooms = pisos.Where(x => x.NumeroHabitaciones >= numberFilter).ToList();

            foreach (var pisoThreeOrMoreRooms in pisosThreeOrMoreRooms)
            {
                Console.WriteLine($"{pisoThreeOrMoreRooms.Nombre}, " +
                                  $"Número de habitaciones: {pisoThreeOrMoreRooms.NumeroHabitaciones}");
            }

            Console.WriteLine();
        }
        public static void GetAdosadosFourOrMoreRooms(List<Adosado> adosados)
        {
            Console.WriteLine("7. Sacar un listado de adosados que tengan 4 o más habitaciones.");

            int numberFilterRooms = 4;

            var adosadosMoreFourOrMoreRooms = adosados.Where(x => x.NumeroHabitaciones >= numberFilterRooms).ToList();

            foreach (var adosadoMoreFourOrMoreRooms in adosadosMoreFourOrMoreRooms)
            {
                 Console.WriteLine($"{adosadoMoreFourOrMoreRooms.Nombre}, " +
                                   $"Número de habitaciones: {adosadoMoreFourOrMoreRooms.NumeroHabitaciones}");
            }

            Console.WriteLine();
        }
        public static void GetAdosadosWithPool(List<Adosado> adosados)
        {
            Console.WriteLine("8. Sacar un listado de Adosados que tengan piscina");

            var adosadosWithPool = adosados.Where((x) => x.Piscina == true).ToList();

            foreach(var adosadoWithPool in adosadosWithPool)
            {
                Console.WriteLine($"{adosadoWithPool.Nombre}, " +
                                  $"Piscina: Sí ");
            }

            Console.WriteLine();

        }
        public static void GetPisos105metersOrMore(List<Piso> pisos)
        {
            Console.WriteLine("9. Sacar un listado de pisos que tengan 105 o más metros cuadrados.");

            int numberFilterMeters = 105;

            var pisos105metersOrMore = pisos.Where(x => x.Tamano >= numberFilterMeters).ToList();

            foreach (var piso105metersOrMore in pisos105metersOrMore)
            {
                Console.WriteLine($"{piso105metersOrMore.Nombre}, " +
                                  $"Tamaño: {piso105metersOrMore.Tamano} metros cuadrados ");
            }

            Console.WriteLine();
        }
        public static void GetAdosados170metersOrMore(List<Adosado> adosados)
        {
            Console.WriteLine("10. Sacar un listado de adosados que tengan 170 o más metros cuadrados.");

            int numberFilterMeters = 170;

            var adosados170metersOrMore = adosados.Where(x => x.Tamano >= numberFilterMeters).ToList();

            foreach (var adosado170metersOrMore in adosados170metersOrMore)
            {
                Console.WriteLine($"{adosado170metersOrMore.Nombre}, " +
                                  $"Tamaño: {adosado170metersOrMore.Tamano} metros cuadrados");
            }

            Console.WriteLine();

        }
        public static void PrintTableMunicipios(List<Municipio> municipios)
        {
            Console.WriteLine("Tabla Municipios");

            foreach (var municipio in municipios)
            {
                Console.WriteLine($"Id: {municipio.Id} || Nombre: {municipio.Nombre}");
            }
            Console.WriteLine();
        }
        public static void PrintTablePisos(List<Piso> pisos)
        {
            Console.WriteLine("Tabla Pisos");

            foreach (var piso in pisos)
            {
                Console.WriteLine($" Id: {piso.Id} || Tamaño: {piso.Tamano} || Nombre: {piso.Nombre} || Número de habitaciones {piso.NumeroHabitaciones} || Número de baños {piso.NumeroBanos} || Número de planta: {piso.NumeroPlanta} || Id municipio {piso.MunicipioId}");
            }

            Console.WriteLine();
        }
        public static void PrintTableAdosados (List<Adosado> adosados) 
        {
            Console.WriteLine("Tabla Adosados");

            foreach (var adosado in adosados)
            {
                Console.WriteLine($" Id: {adosado.Id} || Id: {adosado.Tamano} || Nombre: {adosado.Nombre} || Número de habitaciones: {adosado.NumeroHabitaciones} || Número de baños: {adosado.NumeroBanos} || Piscina: {adosado.Piscina} || Id municipio: {adosado.MunicipioId}");
            }
            Console.WriteLine();
        }
    }
}
