using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Actividad_Diccionarios_de_Objetos_y_Herencia
{
    internal class Program
    {
        public enum Menu
        {
            AgregarCoche=1,MostrarCoche,ActualizarCoche,EliminarCoche,AgregarCamion,MostrarCamion,ActualizarCamion,EliminarCamion,Salir
        }
        static void Main(string[] args)
        {
            Acciones acc= new Acciones();
            while(true)
            {
                switch (menu())
                {
                    case Menu.AgregarCoche:
                        acc.AgregarCoche();
                        break;
                    case Menu.MostrarCoche:
                        acc.MostrarCoche();
                        break;
                    case Menu.ActualizarCoche:
                        acc.ActualizarCoche();
                        break;
                    case Menu.EliminarCoche:
                        acc.EliminarCoche();
                        break;
                    case Menu.AgregarCamion:
                        acc.AgregarCamion();
                        break;
                    case Menu.MostrarCamion:
                        acc.MostrarCamion();
                        break;
                    case Menu.ActualizarCamion:
                        acc.ActualizarCamion();
                        break;
                    case Menu.EliminarCamion:
                        acc.EliminarCamion();
                        break;
                    case Menu.Salir:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción Invalida");
                        break;
                }
            }
        }
        static Menu menu()
        {
            Console.WriteLine("1. Agregar Coche");
            Console.WriteLine("2. Mostrar Coches");
            Console.WriteLine("3. Actualizar Coche");
            Console.WriteLine("4. Eliminar Coche");
            Console.WriteLine("5. Agregar Camión");
            Console.WriteLine("6. Mostrar Camión");
            Console.WriteLine("7. Actualizar Camión");
            Console.WriteLine("8. Eliminar Camión");
            Console.WriteLine("9. Salir");
            Menu opc=(Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
