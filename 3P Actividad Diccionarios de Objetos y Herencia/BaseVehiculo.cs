using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Actividad_Diccionarios_de_Objetos_y_Herencia
{
    internal class BaseVehiculo
    {
        public BaseVehiculo() { }
        public BaseVehiculo(int id, string marca, string modelo, int año)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
    }
}
