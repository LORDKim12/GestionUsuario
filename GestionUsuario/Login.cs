using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionUsuario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            
            var admin = Sistema.Administradores
                .FirstOrDefault(a => a.Nombre == usuario && a.Contraseña == contraseña);

            if (admin != null)
            {
                admin.IniciarSesionAdmin();
                MessageBox.Show("Bienvenido Administrador " + admin.Nombre);
                formadministrador formAdmin = new formadministrador();
                formAdmin.Show();
                this.Hide();
                
            }

            
            var user = Sistema.Usuarios
                .FirstOrDefault(u => u.Nombre == usuario && u.Contraseña == contraseña);

            if (user != null)
            {
                user.IniciarSesion();
                MessageBox.Show("Bienvenido usuario " + user.Nombre);
                formsUsuario formUser = new formsUsuario();
                formUser.Show();
                this.Hide();

            }


            else { MessageBox.Show("Usuario o contraseña incorrectos."); }
        }
        private void Login_Load(object sender, EventArgs e)
        {
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }
       
    }
}