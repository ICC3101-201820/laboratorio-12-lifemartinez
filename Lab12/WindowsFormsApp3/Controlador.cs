using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Lab12
{
    class Controlador
    {
        Form1 form1 = new Form1();

        public ListaComida comidas;

        public Controlador()
        {
            comidas = new ListaComida();
        }

        public void OnagregarComida(object sender, AgregarComidaArgs args)
        {
            Comida comida = new Comida(args.nombre, args.proteina, args.grasas, args.carbohidratos);
            comidas.agregarComida(comida);
            form1.agregarComida(comida);

        }

        public void OneliminarComida(Comida comida)
        {
            comidas.eliminarComida(comida);
        }

    }
}
