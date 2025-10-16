namespace GestionUsuario
{
    public partial class Form1 : Form
    {
        Administrador Administrador = new Administrador();
        
        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrador.AsignarDatos("juan", "chalan");
            Administrador.IniciarSesion();
            Administrador.MostrarAdmin();
        }
    }
}
