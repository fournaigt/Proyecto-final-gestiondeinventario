namespace CapaPresentacion
{
    partial class InventarioUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioUsuario));
            this.DtaGridAdmin = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnComprar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnRegistro = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCSesion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRefrescar = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // DtaGridAdmin
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtaGridAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DtaGridAdmin.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DtaGridAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtaGridAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaGridAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DtaGridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtaGridAdmin.DoubleBuffered = true;
            this.DtaGridAdmin.EnableHeadersVisualStyles = false;
            this.DtaGridAdmin.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DtaGridAdmin.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.DtaGridAdmin.Location = new System.Drawing.Point(12, 12);
            this.DtaGridAdmin.Name = "DtaGridAdmin";
            this.DtaGridAdmin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtaGridAdmin.RowHeadersWidth = 51;
            this.DtaGridAdmin.RowTemplate.Height = 24;
            this.DtaGridAdmin.Size = new System.Drawing.Size(510, 530);
            this.DtaGridAdmin.TabIndex = 1;
            // 
            // btnComprar
            // 
            this.btnComprar.ActiveBorderThickness = 1;
            this.btnComprar.ActiveCornerRadius = 20;
            this.btnComprar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnComprar.ActiveForecolor = System.Drawing.Color.White;
            this.btnComprar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnComprar.BackColor = System.Drawing.SystemColors.Control;
            this.btnComprar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComprar.BackgroundImage")));
            this.btnComprar.ButtonText = "Comprar";
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnComprar.IdleBorderThickness = 1;
            this.btnComprar.IdleCornerRadius = 20;
            this.btnComprar.IdleFillColor = System.Drawing.Color.White;
            this.btnComprar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnComprar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnComprar.Location = new System.Drawing.Point(604, 241);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(5);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(186, 54);
            this.btnComprar.TabIndex = 5;
            this.btnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ActiveBorderThickness = 1;
            this.btnBuscar.ActiveCornerRadius = 20;
            this.btnBuscar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.ActiveForecolor = System.Drawing.Color.White;
            this.btnBuscar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.ButtonText = "Buscar";
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.IdleBorderThickness = 1;
            this.btnBuscar.IdleCornerRadius = 20;
            this.btnBuscar.IdleFillColor = System.Drawing.Color.White;
            this.btnBuscar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.Location = new System.Drawing.Point(604, 305);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(186, 54);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNombre.LineThickness = 3;
            this.txtNombre.Location = new System.Drawing.Point(557, 60);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(312, 44);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCantidad.HintForeColor = System.Drawing.Color.Empty;
            this.txtCantidad.HintText = "";
            this.txtCantidad.isPassword = false;
            this.txtCantidad.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCantidad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCantidad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCantidad.LineThickness = 3;
            this.txtCantidad.Location = new System.Drawing.Point(557, 175);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(312, 44);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnRegistro
            // 
            this.btnRegistro.ActiveBorderThickness = 1;
            this.btnRegistro.ActiveCornerRadius = 20;
            this.btnRegistro.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnRegistro.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegistro.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegistro.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistro.BackgroundImage")));
            this.btnRegistro.ButtonText = "Registro de Compras";
            this.btnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRegistro.IdleBorderThickness = 1;
            this.btnRegistro.IdleCornerRadius = 20;
            this.btnRegistro.IdleFillColor = System.Drawing.Color.White;
            this.btnRegistro.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnRegistro.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegistro.Location = new System.Drawing.Point(547, 361);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(304, 54);
            this.btnRegistro.TabIndex = 10;
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(551, 25);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(277, 31);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "Nombre del Producto";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(551, 140);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(131, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cantidad";
            // 
            // btnCSesion
            // 
            this.btnCSesion.ActiveBorderThickness = 1;
            this.btnCSesion.ActiveCornerRadius = 20;
            this.btnCSesion.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCSesion.ActiveForecolor = System.Drawing.Color.White;
            this.btnCSesion.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCSesion.BackColor = System.Drawing.SystemColors.Control;
            this.btnCSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCSesion.BackgroundImage")));
            this.btnCSesion.ButtonText = "Cerrar Sesion";
            this.btnCSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSesion.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCSesion.IdleBorderThickness = 1;
            this.btnCSesion.IdleCornerRadius = 20;
            this.btnCSesion.IdleFillColor = System.Drawing.Color.White;
            this.btnCSesion.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCSesion.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCSesion.Location = new System.Drawing.Point(604, 486);
            this.btnCSesion.Margin = new System.Windows.Forms.Padding(5);
            this.btnCSesion.Name = "btnCSesion";
            this.btnCSesion.Size = new System.Drawing.Size(186, 54);
            this.btnCSesion.TabIndex = 13;
            this.btnCSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCSesion.Click += new System.EventHandler(this.btnCSesion_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.ActiveBorderThickness = 1;
            this.btnRefrescar.ActiveCornerRadius = 20;
            this.btnRefrescar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnRefrescar.ActiveForecolor = System.Drawing.Color.White;
            this.btnRefrescar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRefrescar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.BackgroundImage")));
            this.btnRefrescar.ButtonText = "Refrescar";
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRefrescar.IdleBorderThickness = 1;
            this.btnRefrescar.IdleCornerRadius = 20;
            this.btnRefrescar.IdleFillColor = System.Drawing.Color.White;
            this.btnRefrescar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnRefrescar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRefrescar.Location = new System.Drawing.Point(604, 425);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(186, 54);
            this.btnRefrescar.TabIndex = 22;
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // InventarioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 554);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnCSesion);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.DtaGridAdmin);
            this.Name = "InventarioUsuario";
            this.Text = "InventarioUsuario";
            this.Load += new System.EventHandler(this.InventarioUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DtaGridAdmin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnComprar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBuscar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCantidad;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistro;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCSesion;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRefrescar;
    }
}