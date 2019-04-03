using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using INV01.UI.Clases;


namespace INV01.UI.Formularios
{
    public partial class FormLogin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparam, int lparam);

        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text=="USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "PASSWORD")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text=="")
            {
                txtpass.Text = "PASSWORD";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelauxiliar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void acceder()
        {
            Acceso objetoAcceso = new Acceso();
            objetoAcceso.user = txtusuario.Text;
            objetoAcceso.pass = txtpass.Text;
            Respuesta<Acceso> resultado = objetoAcceso.Acceder();

            if (String.IsNullOrWhiteSpace(txtusuario.Text.ToString()) || txtusuario.Text == "USUARIO")
            {
                MessageBox.Show("El campo de Usuario no puede estar Vacio.");
                txtusuario.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtpass.Text.ToString()) || txtpass.Text == "PASSWORD")
            {
                MessageBox.Show("El campo de Password no puede estar Vacio.");                
                txtpass.Focus();
            }
            else
            {
                if (resultado.codigo == 0)
                {
                    formMain n = new formMain();
                    this.Hide();
                    n.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(resultado.mensaje.ToUpper());
                    txtpass.Focus();
                }
            }
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            acceder();
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                acceder();
            }
        }

    }
}
