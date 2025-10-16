using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuario
{
    internal class Usuario
    {
        protected string nombre;
        protected string rol;


        public void IniciarSesion()
        {
            MessageBox.Show("Iniciando Sesion....");
        }

        public void MostrarDatos()
        {
            MessageBox.Show("nombre: " + nombre + "rol: " + rol);
        }

    }
}
