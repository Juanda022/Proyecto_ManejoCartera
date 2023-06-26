namespace NEGOCIO_PRESENTACION
{
    partial class Pagos_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos_Empleado));
            this.dtp_Pagos2 = new System.Windows.Forms.DateTimePicker();
            this.txt_Cod_FactC2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cod_FactV2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Grilla_Pagos = new System.Windows.Forms.DataGridView();
            this.txt_Cod_Cliente2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cod_Empleado2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Cod_FormaPago2 = new System.Windows.Forms.TextBox();
            this.txt_Valor_Pagos2 = new System.Windows.Forms.TextBox();
            this.lbl_TelefonoF = new System.Windows.Forms.Label();
            this.lbl_TelefonoM = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.cmb_EstadoPagos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Pagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_Pagos2
            // 
            this.dtp_Pagos2.Location = new System.Drawing.Point(349, 171);
            this.dtp_Pagos2.Name = "dtp_Pagos2";
            this.dtp_Pagos2.Size = new System.Drawing.Size(230, 20);
            this.dtp_Pagos2.TabIndex = 107;
            // 
            // txt_Cod_FactC2
            // 
            this.txt_Cod_FactC2.Location = new System.Drawing.Point(349, 275);
            this.txt_Cod_FactC2.Name = "txt_Cod_FactC2";
            this.txt_Cod_FactC2.Size = new System.Drawing.Size(230, 20);
            this.txt_Cod_FactC2.TabIndex = 106;
            this.txt_Cod_FactC2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cod_FactC2_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btn_Consulta);
            this.panel1.Controls.Add(this.btn_Nuevo);
            this.panel1.Location = new System.Drawing.Point(727, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 309);
            this.panel1.TabIndex = 91;
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Consulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Consulta.ForeColor = System.Drawing.Color.Black;
            this.btn_Consulta.Location = new System.Drawing.Point(26, 163);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(85, 57);
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
            this.btn_Nuevo.Location = new System.Drawing.Point(26, 71);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(85, 55);
            this.btn_Nuevo.TabIndex = 23;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(152, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 18);
            this.label3.TabIndex = 105;
            this.label3.Text = "Codigo Factura Compra ";
            // 
            // txt_Cod_FactV2
            // 
            this.txt_Cod_FactV2.Location = new System.Drawing.Point(349, 249);
            this.txt_Cod_FactV2.Name = "txt_Cod_FactV2";
            this.txt_Cod_FactV2.Size = new System.Drawing.Size(230, 20);
            this.txt_Cod_FactV2.TabIndex = 104;
            this.txt_Cod_FactV2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cod_FactV2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(152, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 18);
            this.label4.TabIndex = 103;
            this.label4.Text = "Codigo Factura Venta";
            // 
            // Grilla_Pagos
            // 
            this.Grilla_Pagos.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.Grilla_Pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Pagos.Location = new System.Drawing.Point(4, 350);
            this.Grilla_Pagos.Name = "Grilla_Pagos";
            this.Grilla_Pagos.Size = new System.Drawing.Size(852, 102);
            this.Grilla_Pagos.TabIndex = 97;
            // 
            // txt_Cod_Cliente2
            // 
            this.txt_Cod_Cliente2.Location = new System.Drawing.Point(349, 223);
            this.txt_Cod_Cliente2.Name = "txt_Cod_Cliente2";
            this.txt_Cod_Cliente2.Size = new System.Drawing.Size(230, 20);
            this.txt_Cod_Cliente2.TabIndex = 102;
            this.txt_Cod_Cliente2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cod_Cliente2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(152, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 101;
            this.label2.Text = "Codigo Cliente";
            // 
            // txt_Cod_Empleado2
            // 
            this.txt_Cod_Empleado2.Location = new System.Drawing.Point(349, 197);
            this.txt_Cod_Empleado2.Name = "txt_Cod_Empleado2";
            this.txt_Cod_Empleado2.Size = new System.Drawing.Size(230, 20);
            this.txt_Cod_Empleado2.TabIndex = 100;
            this.txt_Cod_Empleado2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cod_Empleado2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(152, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 99;
            this.label1.Text = "Codigo Empleado";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(13, 50);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 90;
            this.pictureBox6.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 45);
            this.panel2.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 105;
            this.label5.Text = "Pagos";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(813, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(771, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_Cod_FormaPago2
            // 
            this.txt_Cod_FormaPago2.Location = new System.Drawing.Point(349, 139);
            this.txt_Cod_FormaPago2.Name = "txt_Cod_FormaPago2";
            this.txt_Cod_FormaPago2.Size = new System.Drawing.Size(230, 20);
            this.txt_Cod_FormaPago2.TabIndex = 96;
            this.txt_Cod_FormaPago2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cod_FormaPago2_KeyPress);
            // 
            // txt_Valor_Pagos2
            // 
            this.txt_Valor_Pagos2.Location = new System.Drawing.Point(349, 105);
            this.txt_Valor_Pagos2.Name = "txt_Valor_Pagos2";
            this.txt_Valor_Pagos2.Size = new System.Drawing.Size(230, 20);
            this.txt_Valor_Pagos2.TabIndex = 95;
            this.txt_Valor_Pagos2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Valor_Pagos2_KeyPress);
            // 
            // lbl_TelefonoF
            // 
            this.lbl_TelefonoF.AutoSize = true;
            this.lbl_TelefonoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TelefonoF.ForeColor = System.Drawing.Color.Black;
            this.lbl_TelefonoF.Location = new System.Drawing.Point(152, 165);
            this.lbl_TelefonoF.Name = "lbl_TelefonoF";
            this.lbl_TelefonoF.Size = new System.Drawing.Size(54, 18);
            this.lbl_TelefonoF.TabIndex = 94;
            this.lbl_TelefonoF.Text = "Fecha";
            // 
            // lbl_TelefonoM
            // 
            this.lbl_TelefonoM.AutoSize = true;
            this.lbl_TelefonoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TelefonoM.ForeColor = System.Drawing.Color.Black;
            this.lbl_TelefonoM.Location = new System.Drawing.Point(152, 139);
            this.lbl_TelefonoM.Name = "lbl_TelefonoM";
            this.lbl_TelefonoM.Size = new System.Drawing.Size(160, 18);
            this.lbl_TelefonoM.TabIndex = 93;
            this.lbl_TelefonoM.Text = "Codigo Forma Pago";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.Black;
            this.lbl_Nombre.Location = new System.Drawing.Point(155, 103);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(47, 18);
            this.lbl_Nombre.TabIndex = 92;
            this.lbl_Nombre.Text = "Valor";
            // 
            // cmb_EstadoPagos
            // 
            this.cmb_EstadoPagos.FormattingEnabled = true;
            this.cmb_EstadoPagos.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmb_EstadoPagos.Location = new System.Drawing.Point(349, 301);
            this.cmb_EstadoPagos.Name = "cmb_EstadoPagos";
            this.cmb_EstadoPagos.Size = new System.Drawing.Size(230, 21);
            this.cmb_EstadoPagos.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(155, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 108;
            this.label6.Text = "Estado";
            // 
            // Pagos_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(858, 464);
            this.Controls.Add(this.cmb_EstadoPagos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_Pagos2);
            this.Controls.Add(this.txt_Cod_FactC2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Cod_FactV2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grilla_Pagos);
            this.Controls.Add(this.txt_Cod_Cliente2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Cod_Empleado2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_Cod_FormaPago2);
            this.Controls.Add(this.txt_Valor_Pagos2);
            this.Controls.Add(this.lbl_TelefonoF);
            this.Controls.Add(this.lbl_TelefonoM);
            this.Controls.Add(this.lbl_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagos_Empleado";
            this.Text = "Pagos_Empleado";
            this.Load += new System.EventHandler(this.Pagos_Empleado_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Pagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Pagos2;
        private System.Windows.Forms.TextBox txt_Cod_FactC2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Consulta;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cod_FactV2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Grilla_Pagos;
        private System.Windows.Forms.TextBox txt_Cod_Cliente2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Cod_Empleado2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Cod_FormaPago2;
        private System.Windows.Forms.TextBox txt_Valor_Pagos2;
        private System.Windows.Forms.Label lbl_TelefonoF;
        private System.Windows.Forms.Label lbl_TelefonoM;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_EstadoPagos;
        private System.Windows.Forms.Label label6;

    }
}