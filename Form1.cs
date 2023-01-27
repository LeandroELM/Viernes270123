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
            txtnota1.Text= string.Empty;
            txtnota2.Text = string.Empty;

            txtname.Focus();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableregistro.AllowUserToAddRows = false;
        }

        public void btnadd_Click(object sender, EventArgs e)
        {
            string Nom, Apell, Car, nota1,nota2;
            
            if (txtname.Text == "" || txtlastname.Text == "" || txtcarnet.Text == "")
            {
                MessageBox.Show("Verifique los campos agregados");
            }
            else
            {
                Nom = txtname.Text;
                Apell = txtlastname.Text;
                Car = txtcarnet.Text;
                nota1 = txtnota1.Text;
                nota2 = txtnota2.Text;


                string [] datos = new string[5];
                datos[0] = Nom;
                datos[1] = Apell;
                datos[2] = Car;
                datos[3] = nota1; 
                datos[4] = nota2;

                tableregistro.Rows.Add(datos);

                CleanFind();
            }
        }

        private void btndeletefila_Click(object sender, EventArgs e)
        {
            try
            {
                int numRowSelect; // variable contadora
                numRowSelect = tableregistro.CurrentRow.Index;
                tableregistro.Rows.RemoveAt(numRowSelect);
            }
            catch (NullReferenceException) 
            {
                MessageBox.Show("No hay filas por borrar");
            }
            txtname.Focus();
        }

        private void btndeleteall_Click(object sender, EventArgs e)
        {
            int fila;
            fila = tableregistro.RowCount;
            for (int i=fila-1; i>=0; i--) 
            {
                tableregistro.Rows.RemoveAt(i);
            }
            txtname.Focus();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            
                                              
        }
    }
}
