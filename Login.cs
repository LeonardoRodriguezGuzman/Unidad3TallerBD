namespace TallerBD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion(txtUser.Text, txtPassword.Text);
            con.AbrirConexion();
            con.CerrarConexion();
        }
    }
}