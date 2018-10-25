using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Lab12

{ 
    public delegate void agregarComidaEvento(string nombre, int proteina, int carbohidratos, int grasas);

    public partial class Form1 : Form
    {   
        public event EventHandler<AgregarComidaArgs> OnagregarComida;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void BotonAgregado_Click(object sender, EventArgs e)
        {
            if (OnagregarComida != null)
            {
                AgregarComidaArgs comidaArgs = new AgregarComidaArgs();
                comidaArgs.nombre = NombreBox.Text;
                comidaArgs.proteina = Convert.ToInt32(ProteinaBox.Text);
                comidaArgs.grasas = Convert.ToInt32(GrasaBox.Text);
                comidaArgs.carbohidratos = Convert.ToInt32(CarbohidratosBox.Text);
                OnagregarComida.Invoke(sender, comidaArgs);
                ListaComidas.Items.Add("Nombre : " + NombreBox.Text + " Proteinas : " +ProteinaBox.Text + " Grasas : " +GrasaBox.Text + " Carbohidratos : " + CarbohidratosBox.Text);
                
            }
        }
        public void agregarComida(Comida comida)
        {
            ListaComidas.Items.Add(Convert.ToString(comida));
        }
        public void eliminarComida(Comida comida)
        {
           
        }

        private void BotonEliminado_Click(object sender, EventArgs e)
        {
            //ListaComidas.ListItems.Remove ListaComidas.SelectedItem.Index;
        }
    }
}
