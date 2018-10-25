﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class ListaComida
    {
        List<Comida> comidas;

        public ListaComida()
        {
            comidas = new List<Comida>();

        }

        public void agregarComida(Comida comida)
        {
            comidas.Add(comida);
        }

        public void eliminarComida(Comida comida)
        {
            comidas.Remove(comida);
        }
    }
}
