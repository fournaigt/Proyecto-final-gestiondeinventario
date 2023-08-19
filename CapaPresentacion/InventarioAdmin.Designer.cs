namespace CapaPresentacion
{
    partial class InventarioAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioAdmin));
            this.DtaGridAdmin = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnAddAdmin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnModificarAdmin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEliminarAdmin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtStock = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnPrecio = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPrecio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCSesion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRefrescar = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // DtaGridAdmin
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtaGridAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtaGridAdmin.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DtaGridAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtaGridAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaGridAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.DtaGridAdmin.Size = new System.Drawing.Size(510, 485);
            this.DtaGridAdmin.TabIndex = 0;
            this.DtaGridAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaGridAdmin_CellContentClick);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.ActiveBorderThickness = 1;
            this.btnAddAdmin.ActiveCornerRadius = 20;
            this.btnAddAdmin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddAdmin.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddAdmin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAdmin.BackgroundImage")));
            this.btnAddAdmin.ButtonText = "Añadir";
            this.btnAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddAdmin.IdleBorderThickness = 1;
            this.btnAddAdmin.IdleCornerRadius = 20;
            this.btnAddAdmin.IdleFillColor = System.Drawing.Color.White;
            this.btnAddAdmin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddAdmin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddAdmin.Location = new System.Drawing.Point(530, 24);
            this.btnAddAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(186, 54);
            this.btnAddAdmin.TabIndex = 1;
            this.btnAddAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // btnModificarAdmin
            // 
            this.btnModificarAdmin.ActiveBorderThickness = 1;
            this.btnModificarAdmin.ActiveCornerRadius = 20;
            this.btnModificarAdmin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnModificarAdmin.ActiveForecolor = System.Drawing.Color.White;
            this.btnModificarAdmin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnModificarAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarAdmin.BackgroundImage")));
            this.btnModificarAdmin.ButtonText = "Modificar";
            this.btnModificarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAdmin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnModificarAdmin.IdleBorderThickness = 1;
            this.btnModificarAdmin.IdleCornerRadius = 20;
            this.btnModificarAdmin.IdleFillColor = System.Drawing.Color.White;
            this.btnModificarAdmin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnModificarAdmin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnModificarAdmin.Location = new System.Drawing.Point(952, 443);
            this.btnModificarAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificarAdmin.Name = "btnModificarAdmin";
            this.btnModificarAdmin.Size = new System.Drawing.Size(139, 54);
            this.btnModificarAdmin.TabIndex = 2;
            this.btnModificarAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificarAdmin.Click += new System.EventHandler(this.btnModificarAdmin_Click);
            // 
            // btnEliminarAdmin
            // 
            this.btnEliminarAdmin.ActiveBorderThickness = 1;
            this.btnEliminarAdmin.ActiveCornerRadius = 20;
            this.btnEliminarAdmin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarAdmin.ActiveForecolor = System.Drawing.Color.White;
            this.btnEliminarAdmin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarAdmin.BackgroundImage")));
            this.btnEliminarAdmin.ButtonText = "Eliminar";
            this.btnEliminarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAdmin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarAdmin.IdleBorderThickness = 1;
            this.btnEliminarAdmin.IdleCornerRadius = 20;
            this.btnEliminarAdmin.IdleFillColor = System.Drawing.Color.White;
            this.btnEliminarAdmin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEliminarAdmin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarAdmin.Location = new System.Drawing.Point(808, 443);
            this.btnEliminarAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminarAdmin.Name = "btnEliminarAdmin";
            this.btnEliminarAdmin.Size = new System.Drawing.Size(129, 54);
            this.btnEliminarAdmin.TabIndex = 3;
            this.btnEliminarAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarAdmin.Click += new System.EventHandler(this.btnEliminarAdmin_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(530, 97);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(186, 54);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(773, 261);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(79, 31);
            this.bunifuCustomLabel1.TabIndex = 16;
            this.bunifuCustomLabel1.Text = "Stock";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(773, 24);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(277, 31);
            this.bunifuCustomLabel3.TabIndex = 15;
            this.bunifuCustomLabel3.Text = "Nombre del Producto";
            // 
            // txtStock
            // 
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStock.HintForeColor = System.Drawing.Color.Empty;
            this.txtStock.HintText = "";
            this.txtStock.isPassword = false;
            this.txtStock.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtStock.LineIdleColor = System.Drawing.Color.Gray;
            this.txtStock.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtStock.LineThickness = 3;
            this.txtStock.Location = new System.Drawing.Point(779, 296);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(312, 44);
            this.txtStock.TabIndex = 14;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStock.OnValueChanged += new System.EventHandler(this.txtCantidad_OnValueChanged);
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
            this.txtNombre.Location = new System.Drawing.Point(779, 59);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(312, 44);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnPrecio
            // 
            this.btnPrecio.AutoSize = true;
            this.btnPrecio.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.btnPrecio.Location = new System.Drawing.Point(773, 142);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(91, 31);
            this.btnPrecio.TabIndex = 18;
            this.btnPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecio.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrecio.HintText = "";
            this.txtPrecio.isPassword = false;
            this.txtPrecio.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrecio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrecio.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrecio.LineThickness = 3;
            this.txtPrecio.Location = new System.Drawing.Point(779, 177);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(312, 44);
            this.txtPrecio.TabIndex = 17;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(537, 410);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(37, 31);
            this.bunifuCustomLabel2.TabIndex = 20;
            this.bunifuCustomLabel2.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.HintForeColor = System.Drawing.Color.Empty;
            this.txtId.HintText = "";
            this.txtId.isPassword = false;
            this.txtId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtId.LineThickness = 3;
            this.txtId.Location = new System.Drawing.Point(543, 445);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(235, 44);
            this.txtId.TabIndex = 19;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnCSesion.Location = new System.Drawing.Point(530, 177);
            this.btnCSesion.Margin = new System.Windows.Forms.Padding(5);
            this.btnCSesion.Name = "btnCSesion";
            this.btnCSesion.Size = new System.Drawing.Size(186, 54);
            this.btnCSesion.TabIndex = 4;
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
            this.btnRefrescar.Location = new System.Drawing.Point(530, 261);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(186, 54);
            this.btnRefrescar.TabIndex = 21;
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // InventarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 509);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCSesion);
            this.Controls.Add(this.btnEliminarAdmin);
            this.Controls.Add(this.btnModificarAdmin);
            this.Controls.Add(this.btnAddAdmin);
            this.Controls.Add(this.DtaGridAdmin);
            this.Name = "InventarioAdmin";
            this.Text = "InventarioAdmin";
            this.Load += new System.EventHandler(this.InventarioAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DtaGridAdmin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddAdmin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModificarAdmin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminarAdmin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBuscar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStock;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel btnPrecio;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrecio;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtId;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCSesion;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRefrescar;
    }
}