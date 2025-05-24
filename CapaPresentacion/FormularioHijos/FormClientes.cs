using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            //COLORES PARA VENTANA ACTIVO INACTIVO inicializando
            //_ = EstaMinimizado(); //A verificar si está minimizado:


            this.FormBorderStyle = FormBorderStyle.None;  // Quitamos el borde predeterminado
            Text = "Clientes"; // Asignamos titulo a la Ventana o Nombre
            LblTitulo.Text = Text;
            //StartPosition = FormStartPosition.CenterScreen; //Centramos la Ventana
            this.MinimumSize = new Size(942, 660); // Anchura: 800px, Altura: 600px
            this.TopLevel = false;  // No es un formulario de nivel superior

        }
        // ====COLORES PARA VENTANA ACTIVO INACTIVO
        // Colores personalizados (puedes cambiarlos)


        #region OCCEDIENDO AL FORM INCIO PARA OBTENER -ABRIR FORMULARIO EN FOMULARIO HIJO
        // --- Enlace con Fomulario Inicio implementado desde Form Inicio

        #endregion

        #region MINIMIZADO MANEJO DE BORDES
        // MANEJO DE OnResize MINIMIZADO MANEJO DE BORDES
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e); // Llamar a la implementación base del evento

            // Comprobar el estado de la ventana (si está maximizada o no)
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Asegurarse de que los bordes y botones no aparezcan al maximizar
                this.FormBorderStyle = FormBorderStyle.None;
                //this.ControlBox = false;
            }
            else
            {
                // Mantener los bordes y botones ocultos cuando se cambia el tamaño
                this.FormBorderStyle = FormBorderStyle.None;
                //this.ControlBox = false;
            }
        }
        #endregion

        #region  ARRASTRAR VENTANA HIJO O SUBVENTANA DESDE BARRA DE TITULO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        // Método que maneja el evento MouseMove para mover la ventana

        private void PanelTituloHijo_MouseDown(object sender, MouseEventArgs e)
        {
            // Llama a ReleaseCapture para liberar la captura del ratón
            ReleaseCapture();

            // Envía el mensaje WM_SYSCOMMAND con el código SC_MOVE para mover la ventana
            // 0x112 es el valor de WM_SYSCOMMAND, y 0xF012 es el valor de SC_MOVE
            SendMessage(Handle, 0x112, 0xF012, 0);
        }

        #endregion

        #region BOTONES DE TITULO VENTANA HIJO O SUBVENTANA


        private bool _isClosing = false;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_isClosing) return; // Evita reprocesamiento
            _isClosing = true;
            base.OnFormClosing(e);

            // Cerrar directamente si está minimizado
            if (this.WindowState == FormWindowState.Minimized)
            {
                Inicio.Instancia.CerrarVentanas<Form>();
                Inicio.Instancia.Reiniciar();
                return;
            }
        }

        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    base.OnFormClosing(e);
        //    // Mostrar un cuadro de mensaje preguntando si desea cerrar la aplicación
        //    var result = MessageBox.Show($"¿Estás seguro de que quieres cerrar la Ventana \n{Text}?",
        //                                 "Confirmar Cierre",
        //                                 MessageBoxButtons.YesNo,
        //                                 MessageBoxIcon.Question);
        //    // Si el usuario selecciona "No", cancelamos el cierre de la ventana
        //    if (result == DialogResult.No)
        //    {
        //        e.Cancel = true; // Esto previene el cierre de la aplicación
        //    }
        //    // Obtener la referencia al formulario principal
        //    Inicio.Instancia.Reiniciar();
        //}

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            try
            {
                Inicio.Instancia.CerrarVentanas<Form>();
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar reiniciar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;  // Quitamos el borde predeterminado
            this.ControlBox = true;
        }

        private void BtnMaximizarRestaurar_Click(object sender, EventArgs e)
        {
            if (WindowState.Equals(FormWindowState.Maximized))
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }

        }
        #endregion


    }
}
