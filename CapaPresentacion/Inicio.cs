using FontAwesome.Sharp;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private readonly ToolTip ToolTip;
        private bool toolTipEnabled = true;  // Variable para controlar si el ToolTip está habilitado

        public Inicio()
        {
            InitializeComponent();
            // Instanciamos para desde los Fomularios Hijos PARA ACCEDER A TODOS LOS METODOS 
            Instancia = this; // Guardamos la instancia ===1
                              // === VENTA ACTIVO INACTIVO


            //this.IsMdiContainer = true; // Hacer que el formulario sea un contenedor MDI
            // ===========Inicializamos para Cambiando colores de los botones
            Load += new EventHandler(InicioColores);

            //this.FormBorderStyle = FormBorderStyle.None;  // Quitamos el borde predeterminado
            StartPosition = FormStartPosition.CenterScreen;  // Centrar la ventana al inicio
            this.DoubleBuffered = true; // Activa el DoubleBuffering en el formulario reduce parpadeo                        
            MinimumSize = new Size(1200, 720); // Mantener tamaño de ventan en minimo
            Text = "Sistema Navarro"; // Asignamos titulo a la Ventana o Nombre
            // Inicializamos al metodo Redimensionar Ventana
            Load += new EventHandler(InicioRedimensionamiento);

            Load += new EventHandler(Form1_Load);
            //Paint += new PaintEventHandler(Form1_Paint);
            // Cargar Incios importantes del formulario
            //Load += Form1_Load; //otra forma de Iniciar Metodo  

            #region VENTANA ACTIVO O INACTIVO PRINCIPAL
            //ICIALIZAMOS PARA VENTANA ACTIVO O INACTIVO PRINCIPAL

            this.Activated += FormProducto_Activated;
            this.Deactivate += FormProducto_Deactivate;

            // Color inicial
            this.BackColor = _colorInactivo;
            #endregion

            #region INICIALIZANDO PARA TOOLTIP
            //Crear el ToolTip
            ToolTip toolTip = new ToolTip();
            ToolTip = toolTip;

            //Configurar propiedades del ToolTip
            ToolTip.AutoPopDelay = 5000;  // El ToolTip desaparece después de 5 segundos
            ToolTip.InitialDelay = 1000;  // Aparece después de 0.015 segundo
            ToolTip.ReshowDelay = 500;    // Se repite después de 0.5 segundos
            ToolTip.ShowAlways = true;    // Mostrar siempre el ToolTip
            ToolTip.IsBalloon = true; // Mostrar forma de globo
            ToolTip.ForeColor = Color.BlueViolet;
            ToolTip.BackColor = Color.Red;

            //Asignar ToolTips a los controles
            AsignarToolTip(btnProductos, "Gestiona los productos disponibles en el \nsistema y agrega productos al Sistema.");
            AsignarToolTip(btnVentas, "Accede al módulo de ventas para realizar transacciones.");
            AsignarToolTip(btnCompras, "Realiza y gestiona las compras de productos.");
            AsignarToolTip(btnClientes, "Visualiza y administra la base de clientes.");
            AsignarToolTip(btnGastosOperativos, "Controla los gastos operativos de la empresa.");
            AsignarToolTip(btnReportes, "Genera reportes sobre ventas, inventarios, etc.");
            AsignarToolTip(btnInventarios, "Consulta y gestiona el inventario de productos.");
            AsignarToolTip(btnUsuarios, "Administración de usuarios y permisos del sistema.");
            AsignarToolTip(btnConfiguracion, "Accede a la configuración del sistema y preferencias.");
            AsignarToolTip(btnAyuda, "Accede a la sección de ayuda para obtener asistencia.");
            AsignarToolTip(btnOcultarMostrar, "Oculta y Muestra la panel de botones.");
            AsignarToolTip(btnInicioRestaurar, "Cierra las ventanas abiertas hasta llegar al inicio");
            //Suscribirse al evento Draw para personalizar el ToolTip
            ToolTip.Draw += ToolTip_Draw;

            Timer timer = new Timer
            {
                Interval = 1000 // Intervalo de 1 segundo (1000 ms)
            };
            timer.Tick += Timer_Tick; // Asociar el evento Tick con el método que actualiza la hora
            timer.Start(); // Iniciar el Timer  
            #endregion

        }

        #region VENTANA ACTIVO INACTIVO FORM HIJOS
        // === VENTANA ACTIVO INACTIVO

        #endregion

        // COLORES PARA VENTANA ACTIVO INACTIVO
        // Colores personalizados (puedes cambiarlos)
        private Color _colorActivo = Color.FromArgb(0, 0, 0); // Gris claro
        private Color _colorInactivo = Color.FromArgb(45, 45, 48); // Gris más oscuro


        private void FormProducto_Activated(object sender, EventArgs e)
        {
            CambiarColorVentana(estadoActivo: true);
        }

        private void FormProducto_Deactivate(object sender, EventArgs e)
        {
            CambiarColorVentana(estadoActivo: false);
        }

        // Método principal para cambiar el color
        public void CambiarColorVentana(bool estadoActivo)
        {
            if (estadoActivo)
            {
                panelTitulo.BackColor = _colorActivo;
                panelSlider.BackColor = _colorActivo;
                this.BackColor = _colorActivo;
                this.Refresh(); // Forzar redibujado
            }
            else
            {
                panelTitulo.BackColor = _colorInactivo;
                panelSlider.BackColor = _colorInactivo;
                this.BackColor = _colorInactivo;
                this.Refresh();
            }
        }

        // Método para configurar colores personalizados
        public void ConfigurarColores(Color colorActivo, Color colorInactivo)
        {
            _colorActivo = colorActivo;
            _colorInactivo = colorInactivo;
            CambiarColorVentana(this.ContainsFocus);
        }

        #region ABRIR FORMULARIO EN FOMULARIO HIJO
        public static Inicio Instancia { get; private set; } //===1

        #endregion

        #region METODOS DE TOOLTIP HABILITAR DESHABILITAR 
        // Método que asigna el ToolTip a un control con el texto especificado
        private void AsignarToolTip(Control control, string descripcion)
        {
            if (toolTipEnabled)
            {
                ToolTip.SetToolTip(control, descripcion); // Solo se asigna el ToolTip si está habilitado
            }
            else
            {
                ToolTip.SetToolTip(control, ""); // Si está deshabilitado, no se asigna ToolTip (se elimina)
            }
        }

        // Método para habilitar o deshabilitar el ToolTip
        private void ToggleToolTips(bool habilitar)
        {
            toolTipEnabled = habilitar;

            // Reasignar ToolTips a los controles después de cambiar el estado
            AsignarToolTip(btnProductos, "Gestiona los productos disponibles en el sistema.");
            AsignarToolTip(btnVentas, "Accede al módulo de ventas para realizar transacciones.");
            AsignarToolTip(btnCompras, "Realiza y gestiona las compras de productos.");
            AsignarToolTip(btnClientes, "Visualiza y administra la base de clientes.");
            AsignarToolTip(btnGastosOperativos, "Controla los gastos operativos de la empresa.");
            AsignarToolTip(btnReportes, "Genera reportes sobre ventas, inventarios, etc.");
            AsignarToolTip(btnInventarios, "Consulta y gestiona el inventario de productos.");
            AsignarToolTip(btnUsuarios, "Administración de usuarios y permisos del sistema.");
            AsignarToolTip(btnConfiguracion, "Accede a la configuración del sistema y preferencias.");
            AsignarToolTip(btnAyuda, "Accede a la sección de ayuda para obtener asistencia.");
            AsignarToolTip(btnOcultarMostrar, "Oculta y Muestra la panel de botones.");
            AsignarToolTip(btnInicioRestaurar, "Cierra las ventanas abiertas hasta llegar al inicio");
        }

        // Evento para personalizar el dibujo del ToolTip
        private void ToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            // Establecer el tamaño de la fuente y color del texto
            Font font = new Font("Arial", 12, FontStyle.Bold);    // Tamaño de fuente: 10, estilo: Negrita
            Brush textBrush = new SolidBrush(Color.BlueViolet);         // Color del texto: Azul

            // Establecer fondo del ToolTip
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);  // Color de fondo: Amarillo claro: LightYellow

            // Dibujar el texto del ToolTip con la fuente y color definidos
            e.Graphics.DrawString(e.ToolTipText, font, textBrush, e.Bounds);
        }

        // Ejemplo de cómo llamar a ToggleToolTips en la interfaz de usuario (ejemplo con un botón para alternar)
        private void BtnHabilitarToolTips_Click(object sender, EventArgs e)
        {
            ToggleToolTips(true);  // Habilitar ToolTips
        }

        private void BtnDeshabilitarToolTips_Click(object sender, EventArgs e)
        {
            ToggleToolTips(false); // Deshabilitar ToolTips
        }
        #endregion

        #region HORA Y FECHA
        // Este evento se ejecuta cada vez que el Timer "Tick"
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Obtener la hora del sistema
            DateTime horaSistema = DateTime.Now;
            // Mostrar la hora en el Label en formato de 24 horas
            lblFecha.Text = horaSistema.ToString("dd/MM/yyyy"); // Muestra fecha actual
            lblHora.Text = horaSistema.ToString("hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture); // Muestra la hora en formato de 24 horas           
        }
        #endregion

        #region PROCESO DE REDIMENSIONAMIENTO DE LA VENTANA Y BORDE

        // Eventos Para quitar la barra de titulo
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private const int GWL_STYLE = -16;
        private const int WS_BORDER = 0x00800000;
        private const int WS_THICKFRAME = 0x00040000;

        private void InicioRedimensionamiento(object sender, EventArgs e)
        {
            // =============Funciones proceso de redimensionamiento de la Ventna            
            //this.Text = string.Empty; // Asignamos sin texto barra titulo 
            ControlBox = false; // Elimina los botones de la barra de título (minimizar, maximizar, cerrar)
            SetStyle(ControlStyles.ResizeRedraw, true); // Permite redibujar al redimensionar
            DoubleBuffered = true; // Reduce parpadeos al redibujar
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea; // Al maximizar ventana muestra la barra de tarea.
        }
        //============== Evento para manejar el proceso de redimensionamiento cuando el mouse está sobre los bordes isquina o inferior derecha
        private void Form1_Load(object sender, EventArgs e)
        {
            int style = GetWindowLong(Handle, GWL_STYLE);
            style &= ~(0x00C00000); // Quitar WS_CAPTION
            style |= WS_BORDER | WS_THICKFRAME; // Añadir WS_BORDER y WS_THICKFRAME
            SetWindowLong(Handle, GWL_STYLE, style);

            //FormVentas formVentas = new FormVentas(this);  // Asegúrate de que 'this' esté completamente inicializado
            //formVentas.MdiParent = this;  // Establecer correctamente el formulario padre
            //formVentas.Show();

        }

        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    // Dibujar bordes visibles y cambiar el color
        //    Pen pen = new Pen(Color.Aqua, 3); // Cambiar Color.Red al color deseado y 5 al grosor deseado
        //    Rectangle rect = new Rectangle(0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
        //    e.Graphics.DrawRectangle(pen, rect);
        //}


        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        #endregion

        #region MANEJO DE FORMULARIO HIJO O SUBVENTANA
        // ============ Arbrir Formulario Hijo o subventana en el panelEscritorio        
        private void AbrirFormularioHijo<FORM>() where FORM : Form, new()
        {
            Form formulario = null; // Inicialización
            try
            {
                // Verificar si el formulario ya está abierto en el panel
                formulario = panelEscritorio.Controls.OfType<FORM>().FirstOrDefault();

                if (formulario != null)
                {
                    // Restaurar el estado si está minimizado y traer al frente
                    formulario.WindowState = FormWindowState.Normal;
                    formulario.BringToFront();
                    return;
                }

                // Crear una nueva instancia del formulario si no existe
                formulario = new FORM
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.None
                };

                // Suscripción al evento FormClosed para limpieza
                formulario.FormClosed += (s, e) =>
                {
                    panelEscritorio.Controls.Remove(formulario);
                };

                // Agregar el formulario al panel y mostrarlo
                panelEscritorio.Controls.Add(formulario);
                panelEscritorio.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            catch (Exception ex)
            {
                // Manejo de errores: mostrar un mensaje al usuario
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bloque finalmente: ejecutar código que siempre debe ejecutarse
                if (formulario != null && !formulario.IsDisposed)
                {
                    // Aquí puedes realizar acciones adicionales si es necesario
                    Debug.WriteLine("Formulario procesado correctamente.");
                }
            }
        }
        #endregion

        #region COLOR DE LOS BOTONES DE SLIDER O PANEL MENU

        // Cambiando colores de los botones y los iconos con FontAwesome.Sharp
        private IconButton actualBtn;
        private Panel BordeIzquirdoBtn;
        // ====== Cambiando colores de los botones. metodos 

        private void InicioColores(object sender, EventArgs e)
        {
            // =========== Cambiando colores de los botones. Inicializamos para botones
            BordeIzquirdoBtn = new Panel
            {
                Size = new Size(7, 50) // tamaño del borde izquierdo
            }; // inicializamos borde izquirdo
            panelSlider.Controls.Add(BordeIzquirdoBtn); // agregamos borde al panel Slider o Menu
        }
        // estructurando colores
        private struct RGBColores
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateBoton(object senderBtn, Color color)
        {

            DisableBoton(); // Desabilita las propiedades del bonton ejecutado 
                            //Personalizacion del Boton
            actualBtn = (IconButton)senderBtn; // remitente del boton
            actualBtn.BackColor = Color.FromArgb(37, 36, 81); // cambiamos color fondo del boton
            actualBtn.ForeColor = color; // cambiamos a parametro de color
            actualBtn.TextAlign = ContentAlignment.MiddleLeft; // Alineamos texto al centro o Izquierda
            actualBtn.IconColor = color; // cambiamos a parametro de color
            actualBtn.TextImageRelation = TextImageRelation.TextBeforeImage;// Texto antes de imagen de color
            actualBtn.ImageAlign = ContentAlignment.MiddleRight; // alineamos el icono hacia la derecha
            //panel borde de izquierdo
            BordeIzquirdoBtn.BackColor = color; // parametro cambiamos a color
            BordeIzquirdoBtn.Location = new Point(0, actualBtn.Location.Y); // posicion del boton izquierdo
            BordeIzquirdoBtn.Visible = true; // boton visible
            BordeIzquirdoBtn.BringToFront(); // traemos al frente
            //Icon Actual Hijo formulario
            iconActualHijoFor.IconChar = actualBtn.IconChar; // asignamos el icono actual de  Hijo Formulario
            iconActualHijoFor.IconColor = color; // Parametro cambiamos a color
            lblTituloHijoFor.Text = actualBtn.Text; // Asignamos el texto del Hijo Formulario
            lblTituloHijoFor.ForeColor = actualBtn.ForeColor; // Asignamos el color texto del Hijo Formulario

        }
        private void DisableBoton()
        {
            if (actualBtn != null)
            {
                actualBtn.BackColor = Color.FromArgb(0, 40, 68); // cambiamos color fondo del boton Estado inactivo
                actualBtn.ForeColor = Color.Gainsboro; // cambiamos a parametro de color
                actualBtn.TextAlign = ContentAlignment.MiddleCenter; // centro
                actualBtn.IconColor = Color.Gainsboro; // cambiamos a parametro de color
                actualBtn.TextImageRelation = TextImageRelation.ImageBeforeText;// Texto antes de imagen de color
                actualBtn.ImageAlign = ContentAlignment.MiddleLeft; // alineamos el icono hacia la Izquierdadia
            }

        }
        #endregion

        #region BOTONES DE BARRA TITULO PERSONALIZADO
        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    base.OnFormClosing(e);

        //    //Mostrar un cuadro de mensaje preguntando si desea cerrar la aplicación
        //    var result = MessageBox.Show($"¿Estás seguro que deseas cerrar la Aplicación \n { Text}?",
        //                                 "Confirme para Cerrar",
        //                                 MessageBoxButtons.YesNo,
        //                                 MessageBoxIcon.Question);
        //    //Si el usuario selecciona "No", cancelamos el cierre de la ventana
        //    if (result == DialogResult.No)
        //    {

        //        e.Cancel = true; // Esto previene el cierre de la aplicación
        //    }
        //}

        //botones de la barra de titulo de la Ventana
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show(
                    $"¿Estás seguro que deseas cerrar la Aplicación \n {Text}?", "Confirme para Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    // 1. Cerrar todos los formularios hijos (si existen)
                    //CerrarTodasVentanasHijos<Form>(); // Usando la función que definimos antes

                    if (CerrarTodasVentanasHijos<Form>().Equals(true))
                    {
                        //2.Cerrar el formulario principal(o la aplicación)
                        this.Close(); // Si este es el formulario principal, cerrará la aplicación
                                      // Application.Exit(); // Alternativa más directa (cierra todo)

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Se ha producido un error al cerrar el programa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void CerrarVentanas<T>(bool confirmar = true) where T : Form
        {
            Form formulario = panelEscritorio.Controls.OfType<T>().FirstOrDefault();

            if (formulario != null)
            {
                if (confirmar)
                {
                    string nombreForm = formulario.Text;
                    DialogResult respuesta = MessageBox.Show(
                        $"¿Estás seguro que deseas cerrar la ventana \n{nombreForm}?",
                        "Confirme para Cerrar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (respuesta != DialogResult.Yes)
                        return;
                }

                formulario.Close();
                Reiniciar();
                ObtenerFormularioActivo();
            }
            else if (confirmar)
            {
                MessageBox.Show(
                    $"Ninguna Ventana abierta en {Text}",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        //public void CerrarVentanas<T>() where T : Form
        //{
        //    // Buscar el formulario hijo en el contenedor

        //    Form formulario = panelEscritorio.Controls.OfType<T>().FirstOrDefault();

        //    if (formulario != null)
        //    {
        //        String NombreFormHijo = formulario.Text;
        //        DialogResult RespHIjo = MessageBox.Show($"¿Estás seguro que deseas cerrar la ventana \n {NombreFormHijo}?", "Confirme para Cerrar",
        //            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (RespHIjo == DialogResult.Yes)
        //        {
        //            formulario.Close();
        //            Reiniciar();           // ¿O solo al final?
        //            ObtenerFormularioActivo(); // ¿Necesitas llamar esto en cada iteración?
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show($"Ninguna Ventana abierta en {Text}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        public bool CerrarTodasVentanasHijos<T>() where T : Form
        {
            var formularios = panelEscritorio.Controls.OfType<T>().ToList();

            if (formularios != null)
            {
                foreach (var formulario in formularios)
                {
                    String NombreFormHijo = formulario.Text;
                    DialogResult RespHIjo = MessageBox.Show($"¿Estás seguro que deseas cerrar la ventana \n {NombreFormHijo}?", "Confirme para Cerrar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (RespHIjo == DialogResult.Yes)
                    {
                        formulario.Close();
                        ObtenerFormularioActivo(); // ¿Necesitas llamar esto en cada iteración?
                        Reiniciar();           // ¿O solo al final?
                    }
                    if (RespHIjo == DialogResult.No)
                    {
                        return false;

                    }
                    //break;
                }//MessageBox.Show("No se encontraron formularios del tipo especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false; // No se cerró nada
            }

            return true; // Se cerraron formularios
        }
        public void CerrarVentanas()
        {
            try
            {
                // Recorremos todos los controles en el panel que contiene los formularios hijos
                foreach (Control control in panelEscritorio.Controls)
                {
                    // Convertimos el control a un formulario
                    // Comprobamos si el control es un formulario hijo (de tipo Form)
                    if (control is Form formularioHijo)
                    {
                        String NombreFormHijo = formularioHijo.Text;
                        DialogResult resulta = MessageBox.Show($"¿Estás seguro que deseas cerrar la ventana \n {NombreFormHijo}?", "Confirme para Cerrar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resulta == DialogResult.Yes)
                        {
                            // Cerramos el formulario hijo
                            formularioHijo.Close();
                            // Eliminamos el formulario del panel
                            panelEscritorio.Controls.Remove(formularioHijo);
                            Reiniciar();// Llamamos a la función para reiniciar el estado o realizar otras tareas si es necesario
                            ObtenerFormularioActivo();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Capturamos cualquier excepción y mostramos un mensaje de error
                MessageBox.Show($"Se produjo un error al cerrar los formularios hijos: {ex.Message}", "Error al cerrar Sub Formularios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BtnInicioRestaurar_Click(object sender, EventArgs e)
        {
            this.CerrarVentanas<Form>();

        }
        public void Reiniciar()
        {

            DisableBoton(); // Llamar al método para deshabilitar botones
            BordeIzquirdoBtn.Visible = false; // Botón izquierdo no visible
            iconActualHijoFor.IconChar = IconChar.Home; // Restaurar ícono
            iconActualHijoFor.IconColor = Color.MediumPurple; // Cambiar color del ícono
            lblTituloHijoFor.Text = "Inicio"; // Restaurar el título
            lblTituloHijoFor.ForeColor = Color.MediumPurple; // Cambiar color del texto
            ObtenerFormularioActivo();

        }

        #endregion

        #region   ARRASTRA DE VENTANA DE BARRA DE TITULO PERSONALIZADO 
        // ARRASTRA DE VENTANA DE BARRA DE TITULO PERSONALIZADO 
        //Importación de la función ReleaseCapture desde user32.dll para mover la ventana desde el PanelCabecera
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        // Método que maneja el evento MouseMove para mover la ventana
        private void PanelTitulo_Paint(object sender, MouseEventArgs e)
        {
            // Llama a ReleaseCapture para liberar la captura del ratón
            ReleaseCapture();

            // Envía el mensaje WM_SYSCOMMAND con el código SC_MOVE para mover la ventana
            // 0x112 es el valor de WM_SYSCOMMAND, y 0xF012 es el valor de SC_MOVE
            SendMessage(Handle, 0x112, 0xF012, 0);
        }
        #endregion

        #region BOTONES DE SLIDER O PANEL MENU
        //Funciones de contraer-Expandir Menú Slider(Menú animado)
        private void TmMenuOcultar_Tick(object sender, EventArgs e)
        {
            try
            {
                if (panelSlider.Width <= 60)
                {
                    tmMenuOcultar.Enabled = false;
                }
                else
                {
                    panelSlider.Width -= 60;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se ha producido un error en el Panel Slider Time: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TmMenuMostrar_Tick(object sender, EventArgs e)
        {
            try
            {
                if (panelSlider.Width >= 240)
                {
                    tmMenuMostrar.Enabled = false;
                }
                else
                {
                    panelSlider.Width += 60;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se ha producido un error en el Panel Slider Time: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BtnOcultarMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (panelSlider.Width == 240)
                {
                    panelSlider.Width = 60;
                    //tmMenuOcultar.Enabled = true;
                }
                else if (panelSlider.Width == 60)
                {
                    panelSlider.Width = 240;
                    //tmMenuMostrar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se ha producido un error en el Panel Slider: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //=========== Botones del Slider o panel Menú       
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActivateBoton(sender, RGBColores.color1);
                //AbrirFormularioHijo(new FormProductos()); //
                AbrirFormularioHijo<FormProductos>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulaio {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void BtnVentas_Click(object sender, EventArgs e)
        {
            //this.ActivateBoton(sender, RGBColores.color2);
            try
            {
                this.ActivateBoton(sender, RGBColores.color2);
                AbrirFormularioHijo<FormVentas>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulaio {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            try
            {
                ActivateBoton(sender, RGBColores.color3);
                AbrirFormularioHijo<FormCompras>();
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ActivateBoton(sender, RGBColores.color4);
            AbrirFormularioHijo<FormClientes>();
        }
        private void BtnGastosOperativos_Click(object sender, EventArgs e)
        {
            ActivateBoton(sender, RGBColores.color5);
            AbrirFormularioHijo<FormGastosOperativos>();
        }

        private void BtnResportes_Click(object sender, EventArgs e)
        {
            ActivateBoton(sender, RGBColores.color6);
            AbrirFormularioHijo<FormReportes>();
        }
        private void BtnInventario_Click(object sender, EventArgs e)
        {
            ActivateBoton(sender, RGBColores.color1);
            AbrirFormularioHijo<FormInventarios>();
        }
        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            ActivateBoton(sender, RGBColores.color2);
            AbrirFormularioHijo<FormUsuario>();
        }
        private void BtnConfiguración_Click(object sender, EventArgs e)
        {
            ActivateBoton(sender, RGBColores.color3);
            AbrirFormularioHijo<FormConfiguracion>();
            //AbrirFormularioHijo(new FormConfiguracion());
        }
        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            //Login ventanainicio = new Login();
            //ventanainicio.Show();
            ActivateBoton(sender, RGBColores.color4);
            //AbrirFormularioHijo(new FormAyuda());
            AbrirFormularioHijo<FormAyuda>();
        }



        private void ComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ActivateBoton(sender, RGBColores.color3);
                AbrirFormularioHijo<FormCompras>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al abrir los formularios hijos: {ex.Message}", "Error al cerrar Sub Formularios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        public Form ObtenerFormularioActivo()
        {
            if (panelEscritorio.Controls.Count > 0) // Verificar que hay controles
            {
                foreach (Control control in panelEscritorio.Controls) // Iterar por los controles
                {
                    // Hacer el cast a Form                        
                    // Validar si el control es de tipo Form y está visible
                    if (control is Form frm) // Solo la comprobación de tipo
                    {
                        if (frm.Visible)
                        {
                            //object sender = null;
                            string nombreBoton = "btn" + frm.Text;
                            //MessageBox.Show($"el nombre del boton es: {nombreBoton}", "titulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //ActivateBoton(actualBtn, RGBColores.color2);
                            // Buscar a los botones dentrol del panelSlider todos los botones y comparar con NombreBoton hasta encontrar luego aplicar el color ActivateBoton 
                            // Buscar a los botones dentro del panelSlider, comparar con nombreBoton y aplicar el color ActivateBoton
                            foreach (Control btn in panelSlider.Controls)
                            {
                                if (btn is Button button && btn.Name == nombreBoton)
                                {
                                    ActivateBoton(button, RGBColores.color2);
                                    break; // Detener la búsqueda una vez encontrado
                                }
                            }
                            //MessageBox.Show($"El formulario activo es: {frm.Text}", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return frm; // Devuelve el formulario activo

                        }
                    }
                }
            }

            return null; // No hay formularios visibles
        }

        //                   
        //private void panelEscritorio_ControlAdded(object sender, ControlEventArgs e)
        //{
        //    // Declarar la variable formulario fuera del if
        //    Form formulario = e.Control as Form;

        //    // Comprobamos si 'e.Control' es realmente un formulario
        //    if (formulario != null)
        //    {
        //        // Si 'e.Control' es un formulario, lo traemos al frente
        //        formulario.BringToFront();
        //    }
        //}

    }

}
