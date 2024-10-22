using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas_del_proyecto
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioCorrecto = "admin";
            string contraseñaCorrecta = "1234";

            if (textBoxUsuario.Text == usuarioCorrecto && textBoxContraseña.Text == contraseñaCorrecta)
            {
                MessageBox.Show("Login correcto. Accediendo a panel de administración.");
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Close(); // Cerrar ventana de login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }

        }
    }
}
