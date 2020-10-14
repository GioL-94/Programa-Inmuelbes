using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmo
{
    public partial class Registro : Form
    {


        double PrecioFinal;
        Piso p = new Piso();
        Local l = new Local();

        ArrayList Regis = new ArrayList();



        public Registro()
        {
            InitializeComponent();
            

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            comboTipo.Items.Add("Piso");
            comboTipo.Items.Add("Local");
            comboEstado.Items.Add("Nuevo");
            comboEstado.Items.Add("Usado");


            


        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboTipo.SelectedIndex;
            if(index == 0)
            {
                textDir.Enabled = true;
                comboEstado.Enabled = true;
                numMetros.Enabled = true;
                numPiso.Enabled = true;
                numAntig.Enabled = true;
                numVentanas.Enabled = false;
                numPrecio.Enabled = true;
            }else
            {
                textDir.Enabled = true;
                comboEstado.Enabled = true;
                numMetros.Enabled = true;
                numPiso.Enabled = false;
                numAntig.Enabled = true;
                numVentanas.Enabled = true;
                numPrecio.Enabled = true;
            }

        }

        private void send_Click(object sender, EventArgs e)
        {
            int index = comboTipo.SelectedIndex;
            if (index == 0)
            {

                if(textDir.Text == "" || numMetros.Text == "" || numMetros.Text == "" || numPiso.Text == "" || numAntig.Text == "" 
                    || numPrecio.Text == "" || comboTipo.Text == "" || comboEstado.Text == "")
                {

                    MessageBox.Show("Debe llenar todos los campos");

                }
                else
                {
                    p.setDireccion(textDir.Text);

                    p.setTipo(comboTipo.Text);
                    p.setEstado(comboEstado.Text);
                    p.setMetrosC(Convert.ToDouble(numMetros.Text));
                    p.setPiso(Convert.ToInt32(numPiso.Text));
                    p.setAntic(Convert.ToInt32(numAntig.Text));
                    p.setPrecioBase(Convert.ToDouble(numPrecio.Text));
                    p.PrecioF();
                    Regis.Add(p);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Regis;
                }

                
                

                
            }else if(index == 1)
            {

                if (comboTipo.Text == "" || textDir.Text == "" || comboEstado.Text == "" || numMetros.Text == "" 
                    || numAntig.Text == "" || numVentanas.Text == "" || numPrecio.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }
                else
                {
                    l.setTipo(comboTipo.Text);
                    l.setDireccion(textDir.Text);
                    l.setEstado(comboEstado.Text);
                    l.setMetrosC(Convert.ToInt32(numMetros.Text));
                    l.setAntic(Convert.ToInt32(numAntig.Text));
                    l.setCVentanas(Convert.ToInt32(numVentanas.Text));
                    l.setPrecioBase(Convert.ToDouble(numPrecio.Text));
                    l.PrecioF();

                    Regis.Add(l);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Regis;
                }

                
            }

            textDir.Clear();
            numPiso.Clear();
            numMetros.Clear();
            numAntig.Clear();
            numVentanas.Clear();
            numPrecio.Clear();
            comboTipo.SelectedIndex = -1;
            comboEstado.SelectedIndex = -1;
           
            
        }



    }
}
