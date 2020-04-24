using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MetroFramework.Forms;

namespace salarioDocente
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            
           
    }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int salarioNuevo, años;
            salarioNuevo = 4100;
            años = int.Parse(txtAños.Text);

            double incremento=0;
            if (años > 16)
            {
                incremento = salarioNuevo * 2;
            }
            else
            {
                if (años > 12)
                {
                    incremento = salarioNuevo * 0.75;
                }
                else
                {
                    if (años > 8)
                    {
                        incremento = salarioNuevo * 0.50;
                    }
                    else
                    {
                        if(años > 4)
                            {
                            incremento = salarioNuevo * 0.25;
                        }
                    }
                }
            }

            int liquidoPag = 0, incre=0;
            incre = int.Parse(incremento.ToString());
            liquidoPag = incre + salarioNuevo;


            //copiamos los datos que el usuario ingresa hacia el listView 
            ListViewItem Registrar = new ListViewItem(txtNombre.Text);
            Registrar.SubItems.Add(comboBox1.Text);
            Registrar.SubItems.Add(txtAños.Text);
            Registrar.SubItems.Add(incremento.ToString());
            Registrar.SubItems.Add(liquidoPag.ToString());

            //importante! para registrar todo
            listView1.Items.Add(Registrar);
        }
    }
}
