namespace CapaPresentacion
{
    partial class FormClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelTituloHijo = new System.Windows.Forms.Panel();
            this.BtnMaximizarRestaurar = new Guna.UI.WinForms.GunaControlBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnMinimizar = new FontAwesome.Sharp.IconButton();
            this.BtnCerrarForm = new FontAwesome.Sharp.IconButton();
            this.PanelTituloHijo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTituloHijo
            // 
            this.PanelTituloHijo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.PanelTituloHijo.BackColor = System.Drawing.Color.DodgerBlue;
            this.PanelTituloHijo.Controls.Add(this.BtnMaximizarRestaurar);
            this.PanelTituloHijo.Controls.Add(this.LblTitulo);
            this.PanelTituloHijo.Controls.Add(this.BtnMinimizar);
            this.PanelTituloHijo.Controls.Add(this.BtnCerrarForm);
            this.PanelTituloHijo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTituloHijo.Location = new System.Drawing.Point(0, 0);
            this.PanelTituloHijo.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTituloHijo.Name = "PanelTituloHijo";
            this.PanelTituloHijo.Size = new System.Drawing.Size(944, 24);
            this.PanelTituloHijo.TabIndex = 4;
            this.PanelTituloHijo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTituloHijo_MouseDown);
            // 
            // BtnMaximizarRestaurar
            // 
            this.BtnMaximizarRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizarRestaurar.AnimationHoverSpeed = 0.07F;
            this.BtnMaximizarRestaurar.AnimationSpeed = 0.03F;
            this.BtnMaximizarRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.BtnMaximizarRestaurar.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom;
            this.BtnMaximizarRestaurar.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.BtnMaximizarRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizarRestaurar.IconColor = System.Drawing.Color.White;
            this.BtnMaximizarRestaurar.IconSize = 15F;
            this.BtnMaximizarRestaurar.Location = new System.Drawing.Point(887, 0);
            this.BtnMaximizarRestaurar.Name = "BtnMaximizarRestaurar";
            this.BtnMaximizarRestaurar.OnHoverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnMaximizarRestaurar.OnHoverIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnMaximizarRestaurar.OnPressedColor = System.Drawing.Color.Aqua;
            this.BtnMaximizarRestaurar.Size = new System.Drawing.Size(25, 24);
            this.BtnMaximizarRestaurar.TabIndex = 5;
            this.BtnMaximizarRestaurar.Click += new System.EventHandler(this.BtnMaximizarRestaurar_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(3, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(135, 20);
            this.LblTitulo.TabIndex = 5;
            this.LblTitulo.Text = "TituloVentanaHijo";
            this.LblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTituloHijo_MouseDown);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimizar.IconColor = System.Drawing.Color.White;
            this.BtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimizar.IconSize = 15;
            this.BtnMinimizar.Location = new System.Drawing.Point(857, 0);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(25, 24);
            this.BtnMinimizar.TabIndex = 3;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnCerrarForm
            // 
            this.BtnCerrarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrarForm.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrarForm.FlatAppearance.BorderSize = 0;
            this.BtnCerrarForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCerrarForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCerrarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarForm.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarForm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCerrarForm.IconColor = System.Drawing.Color.Maroon;
            this.BtnCerrarForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCerrarForm.IconSize = 20;
            this.BtnCerrarForm.Location = new System.Drawing.Point(917, 0);
            this.BtnCerrarForm.Name = "BtnCerrarForm";
            this.BtnCerrarForm.Size = new System.Drawing.Size(25, 24);
            this.BtnCerrarForm.TabIndex = 2;
            this.BtnCerrarForm.Text = "X";
            this.BtnCerrarForm.UseVisualStyleBackColor = false;
            this.BtnCerrarForm.Click += new System.EventHandler(this.BtnCerrarForm_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 632);
            this.Controls.Add(this.PanelTituloHijo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.PanelTituloHijo.ResumeLayout(false);
            this.PanelTituloHijo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTituloHijo;
        private Guna.UI.WinForms.GunaControlBox BtnMaximizarRestaurar;
        private System.Windows.Forms.Label LblTitulo;
        private FontAwesome.Sharp.IconButton BtnMinimizar;
        private FontAwesome.Sharp.IconButton BtnCerrarForm;
    }
}