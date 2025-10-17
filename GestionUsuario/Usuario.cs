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
        protected string contraseña;

       
        public string Nombre => nombre;
        public string Rol => rol;
        public string Contraseña => contraseña;

        
        public void IniciarSesion()
        {
            MessageBox.Show("Iniciando Sesión...");
        }

        public void MostrarDatos()
        {
            MessageBox.Show($"Nombre: {nombre}\nRol: {rol}");
        }

        public void AsignarDatos(string nombre, string rol, string contraseña)
        {
            this.nombre = nombre;
            this.rol = rol;
            this.contraseña = contraseña;
        }
    }
}
