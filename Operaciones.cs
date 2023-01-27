using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viernes270123
{
    public class Operaciones
    {
        string nombre;
        string apellido;
        string carnet;
        int nota1;
        int nota2;
        public Operaciones()
        {

        }
        public Operaciones(string nombre, string apellido, string carnet)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Carnet = carnet;
        }
       
        public string Nombre 
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido 
        {
            get => apellido;
            set => apellido = value;
        }
        public string Carnet
        {
            get => carnet;
            set => carnet = value; 
        }
        public int Nota1
        {
            get => nota1; 
            set => nota1 = value;
        }
        public int Nota2 
        {
            get => nota2;
            set => nota2 = value;
        }

        public string Message() 
        {
            return "Saludos";
        }

       
    }
}
