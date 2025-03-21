using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Actividad_Diccionarios_de_Objetos_y_Herencia
{
    internal class VehiculoCamion:BaseVehiculo
    {
        public VehiculoCamion() { }
        public VehiculoCamion(int id, string marca, string modelo, int año,int capacidadCarga)
        :base(id,marca,modelo,año)
        {
            CapacidadCarga = capacidadCarga;
        }

        public int CapacidadCarga { get; set; }
    }
}
