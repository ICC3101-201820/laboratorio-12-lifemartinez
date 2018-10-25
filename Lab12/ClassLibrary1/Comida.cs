using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Comida
    {
        public string nombre;
        public int proteinas;
        public int grasas;
        public int carbohidratos;
        public int caloria;

        public Comida(string n, int prot, int gras, int carb)
        {
            nombre = n;
            proteinas = prot;
            grasas = gras;
            carbohidratos = carb;
        }

        public int calorias()
        {
            caloria = (4 * carbohidratos) + (4 * proteinas) + (9 * grasas);
            return caloria;
        }
        

        public override string ToString()
        {
            return $"{nombre} (Carbohidratos :   {carbohidratos}, + Proteinas :  + {proteinas}, + Grasas :  + { grasas} + Calorias : { caloria})";
        }


    }
}
    