using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuario
{
    internal class Administrador : Usuario
    {
        public void AsignarDatos(string nombre, string rol)
        {
            base.nombre = nombre;
            base.rol = rol;
        }
        public void IniciarSesionAdmin()
        {
            base.IniciarSesion();
            MessageBox.Show("iniciando sesion admin....");
        }
        public void MostrarAdmin()
        {
            base.MostrarDatos();
            
        }
    }
}
