namespace CapaPresentacion
{
    partial class RegistroCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCompra));
            this.dtaGridComprado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnAtras = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridComprado)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaGridComprado
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtaGridComprado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtaGridComprado.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtaGridComprado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtaGridComprado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridComprado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtaGridComprado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridComprado.DoubleBuffered = true;
            this.dtaGridComprado.EnableHeadersVisualStyles = false;
            this.dtaGridComprado.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtaGridComprado.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dtaGridComprado.Location = new System.Drawing.Point(12, 12);
            this.dtaGridComprado.Name = "dtaGridComprado";
            this.dtaGridComprado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtaGridComprado.RowHeadersWidth = 51;
            this.dtaGridComprado.RowTemplate.Height = 24;
            this.dtaGridComprado.Size = new System.Drawing.Size(381, 426);
            this.dtaGridComprado.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.ActiveBorderThickness = 1;
            this.btnAtras.ActiveCornerRadius = 20;
            this.btnAtras.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAtras.ActiveForecolor = System.Drawing.Color.White;
            this.btnAtras.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAtras.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.ButtonText = "Atras";
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAtras.IdleBorderThickness = 1;
            this.btnAtras.IdleCornerRadius = 20;
            this.btnAtras.IdleFillColor = System.Drawing.Color.White;
            this.btnAtras.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAtras.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAtras.Location = new System.Drawing.Point(497, 132);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(5);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(186, 54);
            this.btnAtras.TabIndex = 16;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(460, 48);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(269, 31);
            this.bunifuCustomLabel3.TabIndex = 17;
            this.bunifuCustomLabel3.Text = "Registro de Compras";
            // 
            // RegistroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dtaGridComprado);
            this.Name = "RegistroCompra";
            this.Text = "RegistroCompra";
            this.Load += new System.EventHandler(this.RegistroCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridComprado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dtaGridComprado;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAtras;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}