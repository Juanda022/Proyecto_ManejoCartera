namespace NEGOCIO_PRESENTACION
{
    partial class Factura_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura_Venta));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txt_Valor_FV = new System.Windows.Forms.TextBox();
            this.lbl_Valor_FV = new System.Windows.Forms.Label();
            this.txt_Clientes_FV = new System.Windows.Forms.TextBox();
            this.lbl_Codigo_Clien = new System.Windows.Forms.Label();
            this.txt_Empleado_FV = new System.Windows.Forms.TextBox();
            this.lbl_Codigo_Emple_FV = new System.Windows.Forms.Label();
            this.dtp_FeFactV = new System.Windows.Forms.DateTimePicker();
            this.txt_Codigo_FV = new System.Windows.Forms.TextBox();
            this.lbl_Fecha_FV = new System.Windows.Forms.Label();
            this.lbl_Codigo_FV = new System.Windows.Forms.Label();
            this.Grilla_FactV = new System.Windows.Forms.DataGridView();
            this.cmb_EstadoFV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_FactV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(732, 35);
            this.panel3.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 102;
            this.label2.Text = "Factura Venta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(655, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(697, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 87;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Modificar);
            this.panel1.Controls.Add(this.btn_Consulta);
            this.panel1.Controls.Add(this.btn_Nuevo);
            this.panel1.Location = new System.Drawing.Point(609, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 377);
            this.panel1.TabIndex = 81;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_Eliminar.Location = new System.Drawing.Point(18, 258);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(95, 46);
            this.btn_Eliminar.TabIndex = 26;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Modificar.ForeColor = System.Drawing.Color.Black;
            this.btn_Modificar.Location = new System.Drawing.Point(18, 187);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(95, 46);
            this.btn_Modificar.TabIndex = 25;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Consulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Consulta.ForeColor = System.Drawing.Color.Black;
            this.btn_Consulta.Location = new System.Drawing.Point(18, 125);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(95, 46);
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
            this.btn_Nuevo.Location = new System.Drawing.Point(18, 59);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(95, 46);
            this.btn_Nuevo.TabIndex = 23;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 42);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(66, 68);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 86;
            this.pictureBox5.TabStop = false;
            // 
            // txt_Valor_FV
            // 
            this.txt_Valor_FV.Location = new System.Drawing.Point(284, 216);
            this.txt_Valor_FV.Name = "txt_Valor_FV";
            this.txt_Valor_FV.Size = new System.Drawing.Size(230, 20);
            this.txt_Valor_FV.TabIndex = 110;
            this.txt_Valor_FV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Valor_FV_KeyPress);
            // 
            // lbl_Valor_FV
            // 
            this.lbl_Valor_FV.AutoSize = true;
            this.lbl_Valor_FV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor_FV.ForeColor = System.Drawing.Color.Black;
            this.lbl_Valor_FV.Location = new System.Drawing.Point(111, 218);
            this.lbl_Valor_FV.Name = "lbl_Valor_FV";
            this.lbl_Valor_FV.Size = new System.Drawing.Size(47, 18);
            this.lbl_Valor_FV.TabIndex = 109;
            this.lbl_Valor_FV.Text = "Valor";
            // 
            // txt_Clientes_FV
            // 
            this.txt_Clientes_FV.Location = new System.Drawing.Point(284, 150);
            this.txt_Clientes_FV.Name = "txt_Clientes_FV";
            this.txt_Clientes_FV.Size = new System.Drawing.Size(230, 20);
            this.txt_Clientes_FV.TabIndex = 108;
            this.txt_Clientes_FV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Clientes_FV_KeyPress);
            // 
            // lbl_Codigo_Clien
            // 
            this.lbl_Codigo_Clien.AutoSize = true;
            this.lbl_Codigo_Clien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo_Clien.ForeColor = System.Drawing.Color.Black;
            this.lbl_Codigo_Clien.Location = new System.Drawing.Point(111, 150);
            this.lbl_Codigo_Clien.Name = "lbl_Codigo_Clien";
            this.lbl_Codigo_Clien.Size = new System.Drawing.Size(128, 18);
            this.lbl_Codigo_Clien.TabIndex = 107;
            this.lbl_Codigo_Clien.Text = "Codigo Clientes";
            // 
            // txt_Empleado_FV
            // 
            this.txt_Empleado_FV.Location = new System.Drawing.Point(284, 118);
            this.txt_Empleado_FV.Name = "txt_Empleado_FV";
            this.txt_Empleado_FV.Size = new System.Drawing.Size(230, 20);
            this.txt_Empleado_FV.TabIndex = 106;
            this.txt_Empleado_FV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Empleado_FV_KeyPress);
            // 
            // lbl_Codigo_Emple_FV
            // 
            this.lbl_Codigo_Emple_FV.AutoSize = true;
            this.lbl_Codigo_Emple_FV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo_Emple_FV.ForeColor = System.Drawing.Color.Black;
            this.lbl_Codigo_Emple_FV.Location = new System.Drawing.Point(111, 120);
            this.lbl_Codigo_Emple_FV.Name = "lbl_Codigo_Emple_FV";
            this.lbl_Codigo_Emple_FV.Size = new System.Drawing.Size(142, 18);
            this.lbl_Codigo_Emple_FV.TabIndex = 105;
            this.lbl_Codigo_Emple_FV.Text = "Codigo Empleado";
            // 
            // dtp_FeFactV
            // 
            this.dtp_FeFactV.Location = new System.Drawing.Point(284, 181);
            this.dtp_FeFactV.Name = "dtp_FeFactV";
            this.dtp_FeFactV.Size = new System.Drawing.Size(230, 20);
            this.dtp_FeFactV.TabIndex = 104;
            // 
            // txt_Codigo_FV
            // 
            this.txt_Codigo_FV.Location = new System.Drawing.Point(284, 88);
            this.txt_Codigo_FV.Name = "txt_Codigo_FV";
            this.txt_Codigo_FV.Size = new System.Drawing.Size(230, 20);
            this.txt_Codigo_FV.TabIndex = 103;
            this.txt_Codigo_FV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_FV_KeyPress);
            // 
            // lbl_Fecha_FV
            // 
            this.lbl_Fecha_FV.AutoSize = true;
            this.lbl_Fecha_FV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha_FV.ForeColor = System.Drawing.Color.Black;
            this.lbl_Fecha_FV.Location = new System.Drawing.Point(111, 183);
            this.lbl_Fecha_FV.Name = "lbl_Fecha_FV";
            this.lbl_Fecha_FV.Size = new System.Drawing.Size(54, 18);
            this.lbl_Fecha_FV.TabIndex = 102;
            this.lbl_Fecha_FV.Text = "Fecha";
            // 
            // lbl_Codigo_FV
            // 
            this.lbl_Codigo_FV.AutoSize = true;
            this.lbl_Codigo_FV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo_FV.ForeColor = System.Drawing.Color.Black;
            this.lbl_Codigo_FV.Location = new System.Drawing.Point(111, 88);
            this.lbl_Codigo_FV.Name = "lbl_Codigo_FV";
            this.lbl_Codigo_FV.Size = new System.Drawing.Size(62, 18);
            this.lbl_Codigo_FV.TabIndex = 101;
            this.lbl_Codigo_FV.Text = "Codigo";
            // 
            // Grilla_FactV
            // 
            this.Grilla_FactV.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.Grilla_FactV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_FactV.Location = new System.Drawing.Point(12, 292);
            this.Grilla_FactV.Name = "Grilla_FactV";
            this.Grilla_FactV.Size = new System.Drawing.Size(582, 101);
            this.Grilla_FactV.TabIndex = 111;
            // 
            // cmb_EstadoFV
            // 
            this.cmb_EstadoFV.FormattingEnabled = true;
            this.cmb_EstadoFV.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmb_EstadoFV.Location = new System.Drawing.Point(284, 242);
            this.cmb_EstadoFV.Name = "cmb_EstadoFV";
            this.cmb_EstadoFV.Size = new System.Drawing.Size(230, 21);
            this.cmb_EstadoFV.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(115, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 112;
            this.label1.Text = "Estado";
            // 
            // Factura_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(734, 399);
            this.Controls.Add(this.cmb_EstadoFV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grilla_FactV);
            this.Controls.Add(this.txt_Valor_FV);
            this.Controls.Add(this.lbl_Valor_FV);
            this.Controls.Add(this.txt_Clientes_FV);
            this.Controls.Add(this.lbl_Codigo_Clien);
            this.Controls.Add(this.txt_Empleado_FV);
            this.Controls.Add(this.lbl_Codigo_Emple_FV);
            this.Controls.Add(this.dtp_FeFactV);
            this.Controls.Add(this.txt_Codigo_FV);
            this.Controls.Add(this.lbl_Fecha_FV);
            this.Controls.Add(this.lbl_Codigo_FV);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura_Venta";
            this.Text = "Entrada_dinero";
            this.Load += new System.EventHandler(this.Factura_Venta_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_FactV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Consulta;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Valor_FV;
        private System.Windows.Forms.Label lbl_Valor_FV;
        private System.Windows.Forms.TextBox txt_Clientes_FV;
        private System.Windows.Forms.Label lbl_Codigo_Clien;
        private System.Windows.Forms.TextBox txt_Empleado_FV;
        private System.Windows.Forms.Label lbl_Codigo_Emple_FV;
        private System.Windows.Forms.DateTimePicker dtp_FeFactV;
        private System.Windows.Forms.TextBox txt_Codigo_FV;
        private System.Windows.Forms.Label lbl_Fecha_FV;
        private System.Windows.Forms.Label lbl_Codigo_FV;
        private System.Windows.Forms.DataGridView Grilla_FactV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_EstadoFV;
        private System.Windows.Forms.Label label1;
    }
}