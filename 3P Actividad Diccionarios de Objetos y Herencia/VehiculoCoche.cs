using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Actividad_Diccionarios_de_Objetos_y_Herencia
{
    internal class VehiculoCoche:BaseVehiculo
    {
        public VehiculoCoche() { }
        public VehiculoCoche(int id, string marca, string modelo, int año,int numPuertas)
        : base(id, marca, modelo, año)
        {
            NumPuertas = numPuertas;
        }

        public int NumPuertas { get; set; }
    }
}
