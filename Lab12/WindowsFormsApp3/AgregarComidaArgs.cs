using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class AgregarComidaArgs : EventArgs
    {
        public string nombre;
        public int proteina;
        public int grasas;
        public int carbohidratos;
    }
}
