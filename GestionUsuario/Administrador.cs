using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuario
{
    internal class Administrador : Usuario
    {
        public void AsignarDatos(string nombre, string rol, string contraseña)
        {
            base.nombre = nombre;
            base.rol = rol;
            base.contraseña = contraseña;
        }

        public void IniciarSesionAdmin()
        {
            base.IniciarSesion();
            MessageBox.Show("Iniciando sesión de Administrador...");
        }

        public void MostrarAdmin()
        {
            base.MostrarDatos();
        }
    }
}