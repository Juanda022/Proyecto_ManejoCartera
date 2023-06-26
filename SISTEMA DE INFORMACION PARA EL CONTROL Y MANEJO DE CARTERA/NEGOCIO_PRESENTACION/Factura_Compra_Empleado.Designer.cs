namespace NEGOCIO_PRESENTACION
{
    partial class Factura_Compra_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura_Compra_Empleado));
            this.txt_Valor_FC2 = new System.Windows.Forms.TextBox();
            this.lbl_Valor_FC = new System.Windows.Forms.Label();
            this.txt_Proveedores_FC2 = new System.Windows.Forms.TextBox();
            this.lbl_Codigo_Prove = new System.Windows.Forms.Label();
            this.txt_Empleado_FC2 = new System.Windows.Forms.TextBox();
            this.lbl_Codigo_Emple_FC = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dtp_FeFactC2 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.Grilla_FactC2 = new System.Windows.Forms.DataGridView();
            this.txt_Codigo_FC2 = new System.Windows.Forms.TextBox();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_Codigo_FC = new System.Windows.Forms.Label();
            this.cmb_EstadoFC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_FactC2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Valor_FC2
            // 
            this.txt_Valor_FC2.Location = new System.Drawing.Point(282, 218);
            this.txt_Valor_FC2.Name = "txt_Valor_FC2";
            this.txt_Valor_FC2.Size = new System.Drawing.Size(230, 20);
            this.txt_Valor_FC2.TabIndex = 114;
            // 
            // lbl_Valor_FC
            // 
            this.lbl_Valor_FC.AutoSize = true;
            this.lbl_Valor_FC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor_FC.ForeColor = System.Drawing.Color.Black;
            this.lbl_Valor_FC.Location = new System.Drawing.Point(109, 218);
            this.lbl_Valor_FC.Name = "lbl_Valor_FC";
            this.lbl_Valor_FC.Size = new System.Drawing.Size(47, 18);
            this.lbl_Valor_FC.TabIndex = 113;
            this.lbl_Valor_FC.Text = "Valor";
            // 
            // txt_Proveedores_FC2
            // 
            this.txt_Proveedores_FC2.Location = new System.Drawing.Point(282, 161);
            this.txt_Proveedores_FC2.Name = "txt_Proveedores_FC2";
            this.txt_Proveedores_FC2.Size = new System.Drawing.Size(230, 20);
            this.txt_Proveedores_FC2.TabIndex = 112;
            this.txt_Proveedores_FC2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Proveedores_FC2_KeyPress);
            // 
            // lbl_Codigo_Prove
            // 
            this.lbl_Codigo_Prove.AutoSize = true;
            this.lbl_Codigo_Prove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo_Prove.ForeColor = System.Drawing.Color.Black;
            this.lbl_Codigo_Prove.Location = new System.Drawing.Point(109, 161);
            this.lbl_Codigo_Prove.Name = "lbl_Codigo_Prove";
            this.lbl_Codigo_Prove.Size = new System.Drawing.Size(163, 18);
            this.lbl_Codigo_Prove.TabIndex = 111;
            this.lbl_Codigo_Prove.Text = "Codigo Proveedores";
            // 
            // txt_Empleado_FC2
            // 
            this.txt_Empleado_FC2.Location = new System.Drawing.Point(282, 129);
            this.txt_Empleado_FC2.Name = "txt_Empleado_FC2";
            this.txt_Empleado_FC2.Size = new System.Drawing.Size(230, 20);
            this.txt_Empleado_FC2.TabIndex = 110;
            this.txt_Empleado_FC2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Empleado_FC2_KeyPress);
            // 
            // lbl_Codigo_Emple_FC
            // 
            this.lbl_Codigo_Emple_FC.AutoSize = true;
            this.lbl_Codigo_Emple_FC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo_Emple_FC.ForeColor = System.Drawing.Color.Black;
            this.lbl_Codigo_Emple_FC.Location = new System.Drawing.Point(109, 131);
            this.lbl_Codigo_Emple_FC.Name = "lbl_Codigo_Emple_FC";
            this.lbl_Codigo_Emple_FC.Size = new System.Drawing.Size(142, 18);
            this.lbl_Codigo_Emple_FC.TabIndex = 109;
            this.lbl_Codigo_Emple_FC.Text = "Codigo Empleado";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(11, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(74, 67);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 108;
            this.pictureBox4.TabStop = false;
            // 
            // dtp_FeFactC2
            // 
            this.dtp_FeFactC2.Location = new System.Drawing.Point(282, 192);
            this.dtp_FeFactC2.Name = "dtp_FeFactC2";
            this.dtp_FeFactC2.Size = new System.Drawing.Size(230, 20);
            this.dtp_FeFactC2.TabIndex = 107;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 45);
            this.panel3.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 24);
            this.label2.TabIndex = 115;
            this.label2.Text = "Factura Compra";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(588, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(630, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btn_Consulta);
            this.panel1.Controls.Add(this.btn_Nuevo);
            this.panel1.Location = new System.Drawing.Point(551, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 275);
            this.panel1.TabIndex = 105;
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Consulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Consulta.ForeColor = System.Drawing.Color.Black;
            this.btn_Consulta.Location = new System.Drawing.Point(15, 193);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(96, 60);
            this.btn_Consulta.TabIndex = 24;
            this.btn_Consulta.Text = "Consulta";
            this.btn_Consulta.UseVisualStyleBackColor = false;
            this.btn_Consulta.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nuevo.ForeColor = System.Drawing.Color.Black;
            this.btn_Nuevo.Location = new System.Drawing.Point(15, 102);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(96, 57);
            this.btn_Nuevo.TabIndex = 23;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // Grilla_FactC2
            // 
            this.Grilla_FactC2.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.Grilla_FactC2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_FactC2.Location = new System.Drawing.Point(0, 288);
            this.Grilla_FactC2.Name = "Grilla_FactC2";
            this.Grilla_FactC2.Size = new System.Drawing.Size(672, 85);
            this.Grilla_FactC2.TabIndex = 104;
            // 
            // txt_Codigo_FC2
            // 
            this.txt_Codigo_FC2.Location = new System.Drawing.Point(282, 99);
            this.txt_Codigo_FC2.Name = "txt_Codigo_FC2";
            this.txt_Codigo_FC2.Size = new System.Drawing.Size(230, 20);
            this.txt_Codigo_FC2.TabIndex = 103;
            this.txt_Codigo_FC2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_FC2_KeyPress);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.ForeColor = System.Drawing.Color.Black;
            this.lbl_Fecha.Location = new System.Drawing.Point(109, 194);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(54, 18);
            this.lbl_Fecha.TabIndex = 102;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // lbl_Codigo_FC
            // 
            this.lbl_Codigo_FC.AutoSize = true;
            this.lbl_Codigo_FC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo_FC.ForeColor = System.Drawing.Color.Black;
            this.lbl_Codigo_FC.Location = new System.Drawing.Point(109, 99);
            this.lbl_Codigo_FC.Name = "lbl_Codigo_FC";
            this.lbl_Codigo_FC.Size = new System.Drawing.Size(62, 18);
            this.lbl_Codigo_FC.TabIndex = 101;
            this.lbl_Codigo_FC.Text = "Codigo";
            // 
            // cmb_EstadoFC
            // 
            this.cmb_EstadoFC.FormattingEnabled = true;
            this.cmb_EstadoFC.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmb_EstadoFC.Location = new System.Drawing.Point(282, 246);
            this.cmb_EstadoFC.Name = "cmb_EstadoFC";
            this.cmb_EstadoFC.Size = new System.Drawing.Size(230, 21);
            this.cmb_EstadoFC.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(109, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 115;
            this.label1.Text = "Estado";
            // 
            // Factura_Compra_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(674, 372);
            this.Controls.Add(this.cmb_EstadoFC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Valor_FC2);
            this.Controls.Add(this.lbl_Valor_FC);
            this.Controls.Add(this.txt_Proveedores_FC2);
            this.Controls.Add(this.lbl_Codigo_Prove);
            this.Controls.Add(this.txt_Empleado_FC2);
            this.Controls.Add(this.lbl_Codigo_Emple_FC);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dtp_FeFactC2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grilla_FactC2);
            this.Controls.Add(this.txt_Codigo_FC2);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_Codigo_FC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura_Compra_Empleado";
            this.Text = "Factura_Compra_Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_FactC2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Valor_FC2;
        private System.Windows.Forms.Label lbl_Valor_FC;
        private System.Windows.Forms.TextBox txt_Proveedores_FC2;
        private System.Windows.Forms.Label lbl_Codigo_Prove;
        private System.Windows.Forms.TextBox txt_Empleado_FC2;
        private System.Windows.Forms.Label lbl_Codigo_Emple_FC;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DateTimePicker dtp_FeFactC2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Consulta;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.DataGridView Grilla_FactC2;
        private System.Windows.Forms.TextBox txt_Codigo_FC2;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Codigo_FC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_EstadoFC;
        private System.Windows.Forms.Label label1;

    }
}