using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        #region PARA MOVER LA VENTANA
        // Importamos funciones de la API de Windows
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void Guna2GradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void HopeGroupBox1_Move(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region MOSTRAS OCULTRAR PASSWORD Y CONTROL DE ICONO
        private void BtnContrasena_Click(object sender, EventArgs e)
        {
            if (txtContrasena.PasswordChar)
            {
                // Mostrar contraseña
                txtContrasena.PasswordChar = false; // Mostrar la contraseña (desactivar el modo oculto)
                btnContrasena.IconChar = FontAwesome.Sharp.IconChar.Eye; // Cambiar el ícono del botón al de "ojo abierto" (contraseña visible)
                txtContrasena.Refresh(); // Fuerza a redibujar el control inmediatamente
            }
            else
            {
                // Ocultar contraseña
                txtContrasena.PasswordChar = true;// Ocultar la contraseña (activar el modo oculto)
                btnContrasena.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;// Cambiar el ícono del botón al de "ojo tachado" (contraseña oculta)
                txtContrasena.Refresh(); // Fuerza a redibujar el control inmediatamente
            }
        }
        #endregion

        #region VALIDACION DE USUARIO Y CONTRASEÑA 
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Acceso concedido (modo prueba)!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Inicio form = new Inicio(); // Instanciando o Invocando al Programa principal
            form.Show(); //  Iniciando o arrancando el Sistema de Programa
            this.Hide(); // Opcional, cierra el formulario de login
            form.FormClosed += Inicio_closed; // Escuchar el evento "FormClosed"
        }
        private void Inicio_closed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Mostrar el Login recién cuando Inicio se haya cerrado completamente
            txtUsuario.Texts = ""; // Limpia el campo Usuario
            txtContrasena.Texts = ""; // Limpia el campo Contraseña
            txtUsuario.Focus(); // Pone el cursor en el campo Usuario
        }
        #endregion

    }
}
