using System;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Drawing;

namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panelSlider = new System.Windows.Forms.Panel();
            this.btnOcultarMostrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.btnInicioRestaurar = new FontAwesome.Sharp.IconPictureBox();
            this.LogoEmpresa = new System.Windows.Forms.PictureBox();
            this.btnInventarios = new FontAwesome.Sharp.IconButton();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnGastosOperativos = new FontAwesome.Sharp.IconButton();
            this.btnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.btnCompras = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblUsuarioNombreTitulo = new System.Windows.Forms.Label();
            this.lblUsuarioMenuTitulo = new System.Windows.Forms.Label();
            this.btnMaxResutarur = new Guna.UI.WinForms.GunaControlBox();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.lblTituloHijoFor = new System.Windows.Forms.Label();
            this.iconActualHijoFor = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tmMenuOcultar = new System.Windows.Forms.Timer(this.components);
            this.tmMenuMostrar = new System.Windows.Forms.Timer(this.components);
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.lblHora = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new Guna.UI.WinForms.GunaLabel();
            this.gunaTransfarantPictureBox2 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaTransfarantPictureBox3 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.PictureBox2 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.tolAyudaGral = new System.Windows.Forms.ToolTip(this.components);
            this.panelSlider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultarMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicioRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoEmpresa)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconActualHijoFor)).BeginInit();
            this.panelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSlider
            // 
            this.panelSlider.BackColor = System.Drawing.Color.Black;
            this.panelSlider.Controls.Add(this.btnOcultarMostrar);
            this.panelSlider.Controls.Add(this.btnProductos);
            this.panelSlider.Controls.Add(this.btnInicioRestaurar);
            this.panelSlider.Controls.Add(this.LogoEmpresa);
            this.panelSlider.Controls.Add(this.btnInventarios);
            this.panelSlider.Controls.Add(this.btnAyuda);
            this.panelSlider.Controls.Add(this.btnVentas);
            this.panelSlider.Controls.Add(this.btnGastosOperativos);
            this.panelSlider.Controls.Add(this.btnConfiguracion);
            this.panelSlider.Controls.Add(this.btnReportes);
            this.panelSlider.Controls.Add(this.btnCompras);
            this.panelSlider.Controls.Add(this.btnClientes);
            this.panelSlider.Controls.Add(this.btnUsuarios);
            this.panelSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlider.Location = new System.Drawing.Point(0, 0);
            this.panelSlider.Name = "panelSlider";
            this.panelSlider.Size = new System.Drawing.Size(240, 720);
            this.panelSlider.TabIndex = 0;
            // 
            // btnOcultarMostrar
            // 
            this.btnOcultarMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOcultarMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnOcultarMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultarMostrar.ErrorImage = null;
            this.btnOcultarMostrar.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.btnOcultarMostrar.IconColor = System.Drawing.Color.White;
            this.btnOcultarMostrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOcultarMostrar.IconSize = 45;
            this.btnOcultarMostrar.InitialImage = null;
            this.btnOcultarMostrar.Location = new System.Drawing.Point(188, 5);
            this.btnOcultarMostrar.Name = "btnOcultarMostrar";
            this.btnOcultarMostrar.Size = new System.Drawing.Size(49, 45);
            this.btnOcultarMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOcultarMostrar.TabIndex = 10;
            this.btnOcultarMostrar.TabStop = false;
            this.btnOcultarMostrar.Click += new System.EventHandler(this.BtnOcultarMostrar_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Gift;
            this.btnProductos.IconColor = System.Drawing.Color.White;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.IconSize = 55;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 104);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(240, 50);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // btnInicioRestaurar
            // 
            this.btnInicioRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicioRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.btnInicioRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicioRestaurar.ErrorImage = null;
            this.btnInicioRestaurar.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnInicioRestaurar.IconColor = System.Drawing.Color.White;
            this.btnInicioRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicioRestaurar.IconSize = 45;
            this.btnInicioRestaurar.InitialImage = null;
            this.btnInicioRestaurar.Location = new System.Drawing.Point(188, 53);
            this.btnInicioRestaurar.Name = "btnInicioRestaurar";
            this.btnInicioRestaurar.Size = new System.Drawing.Size(49, 45);
            this.btnInicioRestaurar.TabIndex = 6;
            this.btnInicioRestaurar.TabStop = false;
            this.btnInicioRestaurar.Click += new System.EventHandler(this.BtnInicioRestaurar_Click);
            // 
            // LogoEmpresa
            // 
            this.LogoEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.LogoEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoEmpresa.ErrorImage = null;
            this.LogoEmpresa.Image = global::CapaPresentacion.Properties.Resources.LOGO_2;
            this.LogoEmpresa.InitialImage = null;
            this.LogoEmpresa.Location = new System.Drawing.Point(0, 12);
            this.LogoEmpresa.Name = "LogoEmpresa";
            this.LogoEmpresa.Size = new System.Drawing.Size(213, 86);
            this.LogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoEmpresa.TabIndex = 5;
            this.LogoEmpresa.TabStop = false;
            // 
            // btnInventarios
            // 
            this.btnInventarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnInventarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventarios.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnInventarios.FlatAppearance.BorderSize = 0;
            this.btnInventarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnInventarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnInventarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventarios.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventarios.ForeColor = System.Drawing.Color.White;
            this.btnInventarios.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnInventarios.IconColor = System.Drawing.Color.White;
            this.btnInventarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventarios.IconSize = 55;
            this.btnInventarios.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnInventarios.Location = new System.Drawing.Point(0, 434);
            this.btnInventarios.Name = "btnInventarios";
            this.btnInventarios.Size = new System.Drawing.Size(240, 50);
            this.btnInventarios.TabIndex = 7;
            this.btnInventarios.Text = "Inventarios";
            this.btnInventarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventarios.UseVisualStyleBackColor = false;
            this.btnInventarios.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.HandshakeAngle;
            this.btnAyuda.IconColor = System.Drawing.Color.White;
            this.btnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyuda.IconSize = 55;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 599);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(240, 50);
            this.btnAyuda.TabIndex = 10;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 55;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 159);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(240, 50);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // btnGastosOperativos
            // 
            this.btnGastosOperativos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnGastosOperativos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGastosOperativos.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnGastosOperativos.FlatAppearance.BorderSize = 0;
            this.btnGastosOperativos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnGastosOperativos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGastosOperativos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastosOperativos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastosOperativos.ForeColor = System.Drawing.Color.White;
            this.btnGastosOperativos.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnGastosOperativos.IconColor = System.Drawing.Color.White;
            this.btnGastosOperativos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGastosOperativos.IconSize = 55;
            this.btnGastosOperativos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGastosOperativos.Location = new System.Drawing.Point(0, 324);
            this.btnGastosOperativos.Name = "btnGastosOperativos";
            this.btnGastosOperativos.Size = new System.Drawing.Size(240, 50);
            this.btnGastosOperativos.TabIndex = 5;
            this.btnGastosOperativos.Text = "Gastos Operativos";
            this.btnGastosOperativos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastosOperativos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGastosOperativos.UseVisualStyleBackColor = false;
            this.btnGastosOperativos.Click += new System.EventHandler(this.BtnGastosOperativos_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.btnConfiguracion.IconColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguracion.IconSize = 55;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 544);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(240, 50);
            this.btnConfiguracion.TabIndex = 9;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.BtnConfiguración_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnReportes.IconColor = System.Drawing.Color.White;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 55;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 379);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(240, 50);
            this.btnReportes.TabIndex = 6;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.BtnResportes_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            this.btnCompras.IconColor = System.Drawing.Color.White;
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.IconSize = 55;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 214);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(240, 50);
            this.btnCompras.TabIndex = 3;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.BtnCompras_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 55;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 269);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(240, 50);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 55;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 489);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(240, 50);
            this.btnUsuarios.TabIndex = 8;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.AutoScroll = true;
            this.panelTitulo.BackColor = System.Drawing.Color.Black;
            this.panelTitulo.Controls.Add(this.lblUsuarioNombreTitulo);
            this.panelTitulo.Controls.Add(this.lblUsuarioMenuTitulo);
            this.panelTitulo.Controls.Add(this.btnMaxResutarur);
            this.panelTitulo.Controls.Add(this.rjCircularPictureBox1);
            this.panelTitulo.Controls.Add(this.lblTituloHijoFor);
            this.panelTitulo.Controls.Add(this.iconActualHijoFor);
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(240, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(960, 45);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_Paint);
            // 
            // lblUsuarioNombreTitulo
            // 
            this.lblUsuarioNombreTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioNombreTitulo.AutoSize = true;
            this.lblUsuarioNombreTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioNombreTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsuarioNombreTitulo.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioNombreTitulo.Location = new System.Drawing.Point(637, 9);
            this.lblUsuarioNombreTitulo.Name = "lblUsuarioNombreTitulo";
            this.lblUsuarioNombreTitulo.Size = new System.Drawing.Size(119, 13);
            this.lblUsuarioNombreTitulo.TabIndex = 14;
            this.lblUsuarioNombreTitulo.Text = "Nombre Usuario Actual ";
            this.lblUsuarioNombreTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsuarioMenuTitulo
            // 
            this.lblUsuarioMenuTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioMenuTitulo.AutoSize = true;
            this.lblUsuarioMenuTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioMenuTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsuarioMenuTitulo.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioMenuTitulo.Location = new System.Drawing.Point(649, 22);
            this.lblUsuarioMenuTitulo.Name = "lblUsuarioMenuTitulo";
            this.lblUsuarioMenuTitulo.Size = new System.Drawing.Size(105, 13);
            this.lblUsuarioMenuTitulo.TabIndex = 14;
            this.lblUsuarioMenuTitulo.Text = "Usuario Actual Titulo";
            this.lblUsuarioMenuTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMaxResutarur
            // 
            this.btnMaxResutarur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxResutarur.AnimationHoverSpeed = 0.07F;
            this.btnMaxResutarur.AnimationSpeed = 0.03F;
            this.btnMaxResutarur.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxResutarur.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom;
            this.btnMaxResutarur.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.btnMaxResutarur.IconColor = System.Drawing.Color.White;
            this.btnMaxResutarur.IconSize = 20F;
            this.btnMaxResutarur.Location = new System.Drawing.Point(874, 2);
            this.btnMaxResutarur.Name = "btnMaxResutarur";
            this.btnMaxResutarur.OnHoverBackColor = System.Drawing.Color.Teal;
            this.btnMaxResutarur.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMaxResutarur.OnPressedColor = System.Drawing.Color.Black;
            this.btnMaxResutarur.Size = new System.Drawing.Size(40, 40);
            this.btnMaxResutarur.TabIndex = 12;
            this.btnMaxResutarur.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::CapaPresentacion.Properties.Resources.perfil;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(760, 2);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(41, 41);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 2;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // lblTituloHijoFor
            // 
            this.lblTituloHijoFor.AutoSize = true;
            this.lblTituloHijoFor.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloHijoFor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHijoFor.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblTituloHijoFor.Location = new System.Drawing.Point(39, 18);
            this.lblTituloHijoFor.Name = "lblTituloHijoFor";
            this.lblTituloHijoFor.Size = new System.Drawing.Size(43, 16);
            this.lblTituloHijoFor.TabIndex = 6;
            this.lblTituloHijoFor.Text = "Inicio";
            // 
            // iconActualHijoFor
            // 
            this.iconActualHijoFor.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconActualHijoFor.ForeColor = System.Drawing.Color.SlateBlue;
            this.iconActualHijoFor.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconActualHijoFor.IconColor = System.Drawing.Color.SlateBlue;
            this.iconActualHijoFor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconActualHijoFor.IconSize = 45;
            this.iconActualHijoFor.Location = new System.Drawing.Point(0, 0);
            this.iconActualHijoFor.Name = "iconActualHijoFor";
            this.iconActualHijoFor.Size = new System.Drawing.Size(49, 45);
            this.iconActualHijoFor.TabIndex = 5;
            this.iconActualHijoFor.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(832, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 13;
            this.btnMinimizar.Text = "_";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = global::CapaPresentacion.Properties.Resources.close;
            this.btnCerrar.Location = new System.Drawing.Point(916, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.TabIndex = 11;
            this.tolAyudaGral.SetToolTip(this.btnCerrar, "Cerrar SISTEMA NAVARRO");
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // tmMenuOcultar
            // 
            this.tmMenuOcultar.Tick += new System.EventHandler(this.TmMenuOcultar_Tick);
            // 
            // tmMenuMostrar
            // 
            this.tmMenuMostrar.Interval = 15;
            this.tmMenuMostrar.Tick += new System.EventHandler(this.TmMenuMostrar_Tick);
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelEscritorio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEscritorio.Controls.Add(this.lblHora);
            this.panelEscritorio.Controls.Add(this.label1);
            this.panelEscritorio.Controls.Add(this.label2);
            this.panelEscritorio.Controls.Add(this.lblFecha);
            this.panelEscritorio.Controls.Add(this.gunaTransfarantPictureBox2);
            this.panelEscritorio.Controls.Add(this.gunaTransfarantPictureBox1);
            this.panelEscritorio.Controls.Add(this.gunaTransfarantPictureBox3);
            this.panelEscritorio.Controls.Add(this.PictureBox2);
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.ForeColor = System.Drawing.Color.Black;
            this.panelEscritorio.Location = new System.Drawing.Point(240, 45);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(960, 675);
            this.panelEscritorio.TabIndex = 3;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.SeaShell;
            this.lblHora.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(378, 498);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(100, 40);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "HORA";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(369, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hora Actual";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(714, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Actual";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(725, 517);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(102, 37);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "FECHA";
            // 
            // gunaTransfarantPictureBox2
            // 
            this.gunaTransfarantPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox2.Image = global::CapaPresentacion.Properties.Resources.pc_de_escritorio_calenWhit;
            this.gunaTransfarantPictureBox2.Location = new System.Drawing.Point(690, 413);
            this.gunaTransfarantPictureBox2.Name = "gunaTransfarantPictureBox2";
            this.gunaTransfarantPictureBox2.Size = new System.Drawing.Size(230, 219);
            this.gunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox2.TabIndex = 7;
            this.gunaTransfarantPictureBox2.TabStop = false;
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Image = global::CapaPresentacion.Properties.Resources.reloj_de_escritorio_SinTexto;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(330, 332);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(277, 289);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 5;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // gunaTransfarantPictureBox3
            // 
            this.gunaTransfarantPictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTransfarantPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox3.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox3.Image = global::CapaPresentacion.Properties.Resources.LOGO_2;
            this.gunaTransfarantPictureBox3.Location = new System.Drawing.Point(673, 40);
            this.gunaTransfarantPictureBox3.Name = "gunaTransfarantPictureBox3";
            this.gunaTransfarantPictureBox3.Size = new System.Drawing.Size(259, 137);
            this.gunaTransfarantPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaTransfarantPictureBox3.TabIndex = 8;
            this.gunaTransfarantPictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox2.BaseColor = System.Drawing.Color.Black;
            this.PictureBox2.Image = global::CapaPresentacion.Properties.Resources.escritorio_de_oficina_Trans20;
            this.PictureBox2.Location = new System.Drawing.Point(76, 2);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(817, 596);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 6;
            this.PictureBox2.TabStop = false;
            // 
            // tolAyudaGral
            // 
            this.tolAyudaGral.AutomaticDelay = 150;
            this.tolAyudaGral.ForeColor = System.Drawing.Color.Blue;
            this.tolAyudaGral.IsBalloon = true;
            this.tolAyudaGral.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelSlider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.panelSlider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultarMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicioRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoEmpresa)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconActualHijoFor)).EndInit();
            this.panelEscritorio.ResumeLayout(false);
            this.panelEscritorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }
        
        #endregion

        private System.Windows.Forms.Panel panelSlider;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private PictureBox LogoEmpresa;
        private Timer tmMenuOcultar;
        private Timer tmMenuMostrar;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private FontAwesome.Sharp.IconButton btnConfiguracion;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnGastosOperativos;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnCompras;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnInventarios;
        private FontAwesome.Sharp.IconPictureBox iconActualHijoFor;
        private Label lblTituloHijoFor;
        private Panel panelEscritorio;
        private FontAwesome.Sharp.IconPictureBox btnInicioRestaurar;
        private FontAwesome.Sharp.IconPictureBox btnOcultarMostrar;
        private ToolTip tolAyudaGral;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private Label label1;
        private Guna.UI.WinForms.GunaLabel lblHora;
        private Label label2;
        private Guna.UI.WinForms.GunaLabel lblFecha;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private Guna.UI.WinForms.GunaTransfarantPictureBox PictureBox2;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox2;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox3;
        private Guna.UI.WinForms.GunaControlBox btnMaxResutarur;
        private Label lblUsuarioNombreTitulo;
        private Label lblUsuarioMenuTitulo;
    }
}

