using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Actividad_Diccionarios_de_Objetos_y_Herencia
{
    internal class Acciones
    {
        Dictionary<int,VehiculoCamion> diccionarioCamion = new Dictionary<int, VehiculoCamion>();
         Dictionary<int, VehiculoCoche> diccionarioCoche = new Dictionary<int, VehiculoCoche>();
        VehiculoCoche coche = new VehiculoCoche();
        VehiculoCamion camion= new VehiculoCamion();

        public void AgregarCoche()
        {
            Console.WriteLine("Dame el ID del auto");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame la matricula del coche");
            coche.Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame la marca del coche");
            coche.Marca=Console.ReadLine();
            Console.WriteLine("Dame el modelo del coche");
            coche.Modelo=Console.ReadLine();
            Console.WriteLine("Dame el año del coche");
            coche.Año=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el no. de puertas del coche");
            coche.NumPuertas=Convert.ToInt32(Console.ReadLine());

            diccionarioCoche.Add(id, new VehiculoCoche(coche.Id,coche.Marca,coche.Modelo,coche.Año,coche.NumPuertas));
            

        }
        public void MostrarCoche()
        {
            foreach (var co in diccionarioCoche)
            {
                Console.WriteLine("ID: "+co.Key);
                Console.WriteLine("Matricula: "+co.Value.Id);
                Console.WriteLine("Marca: "+co.Value.Marca);
                Console.WriteLine("Modelo: "+co.Value.Modelo);
                Console.WriteLine("Año: "+co.Value.Año);
                Console.WriteLine("No. Puertas: "+co.Value.NumPuertas);

            }
        }
        public void ActualizarCoche()
        {
            Console.WriteLine("Dame el ID a actualizar");
            int id=Convert.ToInt32(Console.ReadLine());
            var coche = diccionarioCoche.FirstOrDefault(x => x.Value.Id == id);
        }
        public void EliminarCoche()
        {
            Console.WriteLine("Dame el ID a eliminar");
            int id=Convert.ToInt32(Console.ReadLine());
            diccionarioCoche.Remove(id);
        }

        public void AgregarCamion()
        {
            Console.WriteLine("Dame el ID del camion");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame la matricula del camion");
            camion.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame la marca del camion");
            camion.Marca = Console.ReadLine();
            Console.WriteLine("Dame el modelo del camion");
            camion.Modelo = Console.ReadLine();
            Console.WriteLine("Dame el año del camion");
            camion.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame la capacidad de carga del camion");
            camion.CapacidadCarga = Convert.ToInt32(Console.ReadLine());

            diccionarioCamion.Add(id, new VehiculoCamion(camion.Id, camion.Marca, camion.Modelo, camion.Año, camion.CapacidadCarga));
        
        }
        public void MostrarCamion()
        {
            foreach (var ca in diccionarioCamion)
            {
                Console.WriteLine("ID: " + ca.Key);
                Console.WriteLine("Matricula: " + ca.Value.Id);
                Console.WriteLine("Marca: " + ca.Value.Marca);
                Console.WriteLine("Modelo: " + ca.Value.Modelo);
                Console.WriteLine("Año: " + ca.Value.Año);
                Console.WriteLine("Capacidad de carga: " + ca.Value.CapacidadCarga);

            }
        }
        public void ActualizarCamion()
        {

        }
        public void EliminarCamion()
        {
            Console.WriteLine("Dame el ID a eliminar");
            int id = Convert.ToInt32(Console.ReadLine());
            diccionarioCamion.Remove(id);
        }

    }
}
