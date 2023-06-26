namespace NEGOCIO_PRESENTACION
{
    partial class Menu_Reporte_FacturaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Reporte_FacturaCompra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ReporteGeneral = new System.Windows.Forms.Button();
            this.btn_ReporteEspecifico = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_ReporteGeneral);
            this.panel1.Controls.Add(this.btn_ReporteEspecifico);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 386);
            this.panel1.TabIndex = 1;
            // 
            // btn_ReporteGeneral
            // 
            this.btn_ReporteGeneral.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_ReporteGeneral.Location = new System.Drawing.Point(86, 155);
            this.btn_ReporteGeneral.Name = "btn_ReporteGeneral";
            this.btn_ReporteGeneral.Size = new System.Drawing.Size(180, 85);
            this.btn_ReporteGeneral.TabIndex = 0;
            this.btn_ReporteGeneral.Text = "Reporte General";
            this.btn_ReporteGeneral.UseVisualStyleBackColor = false;
            this.btn_ReporteGeneral.Click += new System.EventHandler(this.btn_ReporteGeneral_Click);
            // 
            // btn_ReporteEspecifico
            // 
            this.btn_ReporteEspecifico.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_ReporteEspecifico.Location = new System.Drawing.Point(353, 155);
            this.btn_ReporteEspecifico.Name = "btn_ReporteEspecifico";
            this.btn_ReporteEspecifico.Size = new System.Drawing.Size(180, 85);
            this.btn_ReporteEspecifico.TabIndex = 1;
            this.btn_ReporteEspecifico.Text = "Reporte Especifico";
            this.btn_ReporteEspecifico.UseVisualStyleBackColor = false;
            this.btn_ReporteEspecifico.Click += new System.EventHandler(this.btn_ReporteEspecifico_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(618, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Menu_Reporte_FacturaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 386);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Reporte_FacturaCompra";
            this.Text = "Menu_Reporte_FacturaCompra";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ReporteGeneral;
        private System.Windows.Forms.Button btn_ReporteEspecifico;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}