using Examples.Curso.Entitys;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Curso.Ejercicios_de_Programacion
{
    public static class CargaMasiva
    {
        public static List<File> LeerFile()
        {
            Console.WriteLine("INICIO PROCESO LEER File");
            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();

            string line;
            List<File> files = new List<File>();

            try
            {
                StreamReader sr = new StreamReader("C:\\git-ccardenas\\ejemplo.txt");
                line = sr.ReadLine();

                while (line != null)
                {
                    File file = new File();
                    string[] words = line.Split(",");

                    file.Ciudad = words[0];
                    file.Comuina = words[1];
                    file.Proveedor = words[2];
                    file.Producto = words[3];
                    files.Add(file);
                    line = sr.ReadLine();
                }

                sr.Close();

                timeMeasure.Stop();
                Console.WriteLine($"tiempo milisegundos: { timeMeasure.Elapsed.TotalMilliseconds} ms");
                Console.WriteLine($"tiempo segundos: { timeMeasure.Elapsed.TotalSeconds} s");

                return files;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void FilesProcessV1(List<File> file)
        {
            var lstCiudad = file.GroupBy(x => x.Ciudad).ToList();
            var lstComuna = file.GroupBy(x => x.Comuina).ToList();
            var lstProveedor = file.GroupBy(x => x.Proveedor).ToList();
            var lstProducto = file.GroupBy(x => x.Producto).ToList();

            var lstEliminados = new List<Ciudad>();

            foreach (var item in lstCiudad)
            {
                var ciudad = new Ciudad();
                var resultCiudad = BuscarCiudad(item.Key);

                if (string.IsNullOrEmpty(resultCiudad))
                {
                    foreach (var iCiudad in file)
                    {
                        if (iCiudad.Ciudad == item.Key)
                        {
                            //crear una lista, esta lista tendrá como resultado 1000 registros de la misma ciudad
                            //cómo sé cual es la correcta?
                        }
                    }
                }
            }
            //TODO: según lo analizado en este método, el uso de groupby no aplica, dado que se pierden el indice por regitro
        }

        public static void FilesProcessV2(List<File> file)
        {
            Console.WriteLine("INICIO PROCESO FILE V2");
            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();
            foreach (var item in file)
            {
                //Evaluar si existe la ciudad
                //foreach, buscar en base de datos por registro y luego evaluar si existe
                var ciudad = BuscarCiudad("2");
                //Evaluar si existe la comuna
                var comuna = BuscarComuna(item.Comuina);
                ////foreach, buscar en base de datos por registro y luego evaluar si existe
                ////Evaluar si existe la proveedor
                ////foreach, buscar en base de datos por registro y luego evaluar si existe
                var proveedor = BuscarProveedor(item.Proveedor);
                ////Evaluar si existe la producto
                ////foreach, buscar en base de datos por registro y luego evaluar si existe
                var producto = BuscarProducto(item.Producto);
                //TODO:Si todos existen el registro está OK, sino el registro se debe eliminar o pasar a otra lista 
                //para informar los registros con problema
            }
            timeMeasure.Stop();
           
            Console.WriteLine($"tiempo segundos: { timeMeasure.Elapsed.TotalSeconds} s");

            Console.ReadLine();
        }

        public static void FilesProcessV3(List<File> file)
        {
            Console.WriteLine("INICIO PROCESO FILE V3");
            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();
            foreach (var item in file)
            {
                //Evaluar si existe la ciudad
                //foreach, buscar en base de datos por registro y luego evaluar si existe
                Task tCiudad = new Task( ()=> BuscarCiudad(item.Ciudad));
                tCiudad.Start();
                //Evaluar si existe la comuna
                Task tComuna = new Task(() => BuscarComuna(item.Comuina));
                tComuna.Start();
                //foreach, buscar en base de datos por registro y luego evaluar si existe
                //Evaluar si existe la proveedor
                //foreach, buscar en base de datos por registro y luego evaluar si existe
                Task tProveedor = new Task(() => BuscarProveedor(item.Proveedor));
                tProveedor.Start();
                //Evaluar si existe la producto
                //foreach, buscar en base de datos por registro y luego evaluar si existe
                Task tProducto = new Task(() => BuscarProducto(item.Producto));
                tProducto.Start();
                
                //TODO:Si todos existen el registro está OK, sino el registro se debe eliminar o pasar a otra lista 
                //para informar los registros con problema
            }
            timeMeasure.Stop();
           
            Console.WriteLine($"tiempo segundos: { timeMeasure.Elapsed.TotalSeconds} s");
            Console.WriteLine("FIN PROCESO FILE V3");
            Console.ReadLine();
        }

        public static void FilesProcessV4(List<File> file)
        {
            Console.WriteLine("INICIO PROCESO FILE V4");
            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();
            var lstCorruptos = new List<File>();
            var lstCiudades = LstCiudades();
            var lstComunas = LstComunas();
            var lstProveedores = LstProveedores();
            var lstProducto = LstProductos();

            foreach (var item in file)
            {
                
                //Evaluar si existe la ciudad
                //foreach, buscar en base de datos por registro y luego evaluar si existe
                Task<string> tCiudad = new Task<string>(() => BuscarCiudadByList(item.Ciudad, lstCiudades));
                tCiudad.Start();
                //Evaluar si existe la comuna
                Task<string> tComuna = new Task<string>(() => BuscarComunaByList(item.Comuina, lstComunas));
                tComuna.Start();
                //foreach, buscar en base de datos por registro y luego evaluar si existe
                //Evaluar si existe la proveedor
                //foreach, buscar en base de datos por registro y luego evaluar si existe
                Task<string> tProveedor = new Task<string>(() => BuscarProveedorByList(item.Proveedor, lstProveedores));
                tProveedor.Start();
                //Evaluar si existe la producto
                //foreach, buscar en base de datos por registro y luego evaluar si existe
                Task<string> tProducto = new Task<string>(() => BuscarProductoByList(item.Producto, lstProducto));
                tProducto.Start();

                //TODO:Si todos existen el registro está OK, sino el registro se debe eliminar o pasar a otra lista 
                //para informar los registros con problema

                if (string.IsNullOrEmpty(tCiudad.Result) || string.IsNullOrEmpty(tComuna.Result)
                    || string.IsNullOrEmpty(tProveedor.Result) || string.IsNullOrEmpty(tProducto.Result))
                {
                    var fCorrupto = new File();

                    fCorrupto.Ciudad = item.Ciudad;
                    fCorrupto.Comuina = item.Comuina;
                    fCorrupto.Producto = item.Producto;
                    fCorrupto.Proveedor = item.Proveedor;

                    //TODO: la lista de corruptos se puede guardar en una db o utilizar para eliminar los registros corruptos
                    //de la lita original

                    lstCorruptos.Add(fCorrupto);
                }
            }

            timeMeasure.Stop();

            Console.WriteLine($"tiempo segundos: { timeMeasure.Elapsed.TotalSeconds} s");
            Console.WriteLine("FIN PROCESO FILE V4");
            Console.WriteLine("La cantidad de registros no procesados son: {1} ", lstCorruptos.Count());

            timeMeasure.Start();
            Console.WriteLine("Eliminación de items corruptos");
            //Eliminación de items corruptos
            foreach (var item in lstCorruptos)
            {
                file.Remove(item);
            }

            timeMeasure.Stop();

            Console.WriteLine($"tiempo segundos: { timeMeasure.Elapsed.TotalSeconds} s");
            Console.WriteLine("FIN PROCESO FILE V4");
            Console.WriteLine("La cantidad de registros no procesados son: {1} ", lstCorruptos.Count());
            //foreach (var item in lstCorruptos)
            //{
            //    Console.WriteLine();
            //}
            Console.ReadLine();
        }
        public static string BuscarCiudad(string cuidad)
        {
            using (var context = new ProductosContext())
            {
                
                var find = context.Ciudads.Where(x => x.IdCiudad == Convert.ToInt32(cuidad)).FirstOrDefault();

                return find == null ? string.Empty : find.Nombre;
            }
        }

        public static List<Ciudad> LstCiudades()
        {
            using (var context = new ProductosContext())
            {
                return context.Ciudads.ToList();
            }
        }

        public static List<Comuna> LstComunas()
        {
            using (var context = new ProductosContext())
            {
                return context.Comunas.ToList();
            }
        }

        public static List<Proveedor> LstProveedores()
        {
            using (var context = new ProductosContext())
            {
                return context.Proveedors.ToList();
            }
        }

        public static List<Producto> LstProductos()
        {
            using (var context = new ProductosContext())
            {
                return context.Productos.ToList();
            }
        }
        public static string BuscarCiudadByList(string cuidad, List<Ciudad> ciudades)
        {
            using (var context = new ProductosContext())
            {

                var find = ciudades.Where(x => x.IdCiudad == Convert.ToInt32(cuidad)).FirstOrDefault();

                return find == null ? string.Empty : find.Nombre;
            }
        }

        public static string BuscarComunaByList(string comuna, List<Comuna> comunas)
        {
            using (var context = new ProductosContext())
            {
                var find = comunas.Where(x => x.IdComuna == Convert.ToInt32(comuna)).FirstOrDefault();
                return find == null ? string.Empty : find.Nombre;
            }
        }

        public static string BuscarProveedorByList(string Proveedor, List<Proveedor> proveedores)
        {
            using (var context = new ProductosContext())
            {
                var find = proveedores.Where(x => x.IdProveedor == Convert.ToInt32(Proveedor)).FirstOrDefault();
                return find == null ? string.Empty : find.Nombre;
            }
        }

        public static string BuscarProductoByList(string Producto, List<Producto> productos)
        {
            using (var context = new ProductosContext())
            {
                var find = productos.Where(x => x.IdProducto == Convert.ToInt32(Producto)).FirstOrDefault();
                return find == null ? string.Empty : find.Nombre;
            }
        }


        public static string BuscarComuna(string comuna)
        {
            using (var context = new ProductosContext())
            {
                var find = context.Comunas.Where(x => x.IdComuna == Convert.ToInt32(comuna)).FirstOrDefault();
                return find == null ? string.Empty : find.Nombre;
            }
        }

        public static string BuscarProveedor(string Proveedor)
        {
            using (var context = new ProductosContext())
            {
                var find = context.Proveedors.Where(x => x.IdProveedor == Convert.ToInt32(Proveedor)).FirstOrDefault();
                return find == null ? string.Empty : find.Nombre;
            }
        }

        public static string BuscarProducto(string Producto)
        {
            using (var context = new ProductosContext())
            {
                var find = context.Productos.Where(x => x.IdProducto == Convert.ToInt32(Producto)).FirstOrDefault();
                return find == null ? string.Empty : find.Nombre;
            }
        }
    }




}
