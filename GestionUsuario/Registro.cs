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
    public partial class formregistrar : Form
    {
        public formregistrar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtRol.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Si el rol es Administrador
            if (txtRol.Text.ToLower() == "administrador" || txtRol.Text.ToLower() == "admin")
            {
                Administrador admin = new Administrador();
                admin.AsignarDatos(txtNombre.Text, txtRol.Text, txtContraseña.Text);

                Sistema.Administradores.Add(admin);

                MessageBox.Show("✅ Administrador registrado correctamente.");
            }
            else
            {
                Usuario user = new Usuario();
                user.AsignarDatos(txtNombre.Text, txtRol.Text, txtContraseña.Text);

                Sistema.Usuarios.Add(user);

                MessageBox.Show("✅ Usuario registrado correctamente.");
            }

            // Limpiar campos
            txtNombre.Clear();
            txtRol.Clear();
            txtContraseña.Clear();
        }
        private void Registro_Load(object sender, EventArgs e)
        {
            // (puedes dejarlo vacío)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }
    }
}