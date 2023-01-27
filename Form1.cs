using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viernes270123
{
    public partial class Form1 : Form
    {
        //Metodos
        public void CleanFind() 
        {
            txtname.Text = string.Empty;
            txtlastname.Text = string.Empty;
            txtcarnet.Text = string.Empty;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string Nom, Apell, Car;
            Nom = txtname.Text;
            Apell = txtlastname.Text;
            Car = txtcarnet.Text;

            string[] datos = new string[3];
            datos[0] = Nom;
            datos[1] = Apell;
            datos[2] = Car;

            tableregistro.Rows.Add(datos);


        }
    }
}
