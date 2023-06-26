namespace NEGOCIO_PRESENTACION
{
    partial class Consultar_Modificar_Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar_Modificar_Pagos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_EstadoPagos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_Pagos = new System.Windows.Forms.DateTimePicker();
            this.txt_Cod_FactC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cod_FactV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Cod_Cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cod_Empleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txt_Cod_FormaPago = new System.Windows.Forms.TextBox();
            this.txt_Valor_Pagos = new System.Windows.Forms.TextBox();
            this.lbl_TelefonoF = new System.Windows.Forms.Label();
            this.lbl_TelefonoM = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.Grilla_Pagos = new System.Windows.Forms.DataGridView();
            this.txt_Numero_Pagos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Pagos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Modificar);
            this.panel1.Controls.Add(this.btn_Consulta);
            this.panel1.Location = new System.Drawing.Point(683, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 333);
            this.panel1.TabIndex = 71;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Modificar.ForeColor = System.Drawing.Color.Black;
            this.btn_Modificar.Location = new System.Drawing.Point(18, 129);
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
            this.btn_Consulta.Location = new System.Drawing.Point(18, 70);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(95, 46);
            this.btn_Consulta.TabIndex = 24;
            this.btn_Consulta.Text = "Consulta";
            this.btn_Consulta.UseVisualStyleBackColor = false;
            this.btn_Consulta.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 45);
            this.panel2.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 104;
            this.label5.Text = "Pagos";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(772, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(730, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_EstadoPagos
            // 
            this.cmb_EstadoPagos.FormattingEnabled = true;
            this.cmb_EstadoPagos.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmb_EstadoPagos.Location = new System.Drawing.Point(344, 301);
            this.cmb_EstadoPagos.Name = "cmb_EstadoPagos";
            this.cmb_EstadoPagos.Size = new System.Drawing.Size(230, 21);
            this.cmb_EstadoPagos.TabIndex = 128;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(154, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 127;
            this.label6.Text = "Estado";
            // 
            // dtp_Pagos
            // 
            this.dtp_Pagos.Location = new System.Drawing.Point(344, 171);
            this.dtp_Pagos.Name = "dtp_Pagos";
            this.dtp_Pagos.Size = new System.Drawing.Size(230, 20);
            this.dtp_Pagos.TabIndex = 126;
            // 
            // txt_Cod_FactC
            // 
            this.txt_Cod_FactC.Location = new System.Drawing.Point(344, 275);
            this.txt_Cod_FactC.Name = "txt_Cod_FactC";
            this.txt_Cod_FactC.Size = new System.Drawing.Size(230, 20);
            this.txt_Cod_FactC.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(151, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 18);
            this.label3.TabIndex = 124;
            this.label3.Text = "Codigo Factura Compra ";
            // 
            // txt_Cod_FactV
            // 
            this.txt_Cod_FactV.Location = new System.Drawing.Point(344, 249);
            this.txt_Cod_FactV.Name = "txt_Cod_FactV";
            this.txt_Cod_FactV.Size = new System.Drawing.Size(230, 20);
            this.txt_Cod_FactV.TabIndex = 123;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(151, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 18);
            this.label4.TabIndex = 122;
            this.label4.Text = "Codigo Factura Venta";
            // 
            // txt_Cod_Cliente
            // 
            this.txt_Cod_Cliente.Location = new System.Drawing.Point(344, 223);
            this.txt_Cod_Cliente.Name = "txt_Cod_Cliente";
            this.txt_Cod_Cliente.Size = new System.Drawing.Size(230, 20);
            this.txt_Cod_Cliente.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(151, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 120;
            this.label2.Text = "Codigo Cliente";
            // 
            // txt_Cod_Empleado
            // 
            this.txt_Cod_Empleado.Location = new System.Drawing.Point(344, 197);
            this.txt_Cod_Empleado.Name = "txt_Cod_Empleado";
            this.txt_Cod_Empleado.Size = new System.Drawing.Size(230, 20);
            this.txt_Cod_Empleado.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(151, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 118;
            this.label1.Text = "Codigo Empleado";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(26, 55);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 112;
            this.pictureBox6.TabStop = false;
            // 
            // txt_Cod_FormaPago
            // 
            this.txt_Cod_FormaPago.Location = new System.Drawing.Point(344, 139);
            this.txt_Cod_FormaPago.Name = "txt_Cod_FormaPago";
            this.txt_Cod_FormaPago.Size = new System.Drawing.Size(230, 20);
            this.txt_Cod_FormaPago.TabIndex = 117;
            // 
            // txt_Valor_Pagos
            // 
            this.txt_Valor_Pagos.Location = new System.Drawing.Point(344, 105);
            this.txt_Valor_Pagos.Name = "txt_Valor_Pagos";
            this.txt_Valor_Pagos.Size = new System.Drawing.Size(230, 20);
            this.txt_Valor_Pagos.TabIndex = 116;
            // 
            // lbl_TelefonoF
            // 
            this.lbl_TelefonoF.AutoSize = true;
            this.lbl_TelefonoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TelefonoF.ForeColor = System.Drawing.Color.Black;
            this.lbl_TelefonoF.Location = new System.Drawing.Point(151, 165);
            this.lbl_TelefonoF.Name = "lbl_TelefonoF";
            this.lbl_TelefonoF.Size = new System.Drawing.Size(54, 18);
            this.lbl_TelefonoF.TabIndex = 115;
            this.lbl_TelefonoF.Text = "Fecha";
            // 
            // lbl_TelefonoM
            // 
            this.lbl_TelefonoM.AutoSize = true;
            this.lbl_TelefonoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TelefonoM.ForeColor = System.Drawing.Color.Black;
            this.lbl_TelefonoM.Location = new System.Drawing.Point(151, 139);
            this.lbl_TelefonoM.Name = "lbl_TelefonoM";
            this.lbl_TelefonoM.Size = new System.Drawing.Size(160, 18);
            this.lbl_TelefonoM.TabIndex = 114;
            this.lbl_TelefonoM.Text = "Codigo Forma Pago";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.Black;
            this.lbl_Nombre.Location = new System.Drawing.Point(154, 107);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(47, 18);
            this.lbl_Nombre.TabIndex = 113;
            this.lbl_Nombre.Text = "Valor";
            // 
            // Grilla_Pagos
            // 
            this.Grilla_Pagos.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.Grilla_Pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Pagos.Location = new System.Drawing.Point(0, 339);
            this.Grilla_Pagos.Name = "Grilla_Pagos";
            this.Grilla_Pagos.Size = new System.Drawing.Size(810, 97);
            this.Grilla_Pagos.TabIndex = 129;
            // 
            // txt_Numero_Pagos
            // 
            this.txt_Numero_Pagos.Location = new System.Drawing.Point(344, 79);
            this.txt_Numero_Pagos.Name = "txt_Numero_Pagos";
            this.txt_Numero_Pagos.Size = new System.Drawing.Size(230, 20);
            this.txt_Numero_Pagos.TabIndex = 131;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(154, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 130;
            this.label7.Text = "Numero";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_Eliminar.Location = new System.Drawing.Point(18, 192);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(95, 46);
            this.btn_Eliminar.TabIndex = 132;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Consultar_Modificar_Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(808, 435);
            this.Controls.Add(this.txt_Numero_Pagos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Grilla_Pagos);
            this.Controls.Add(this.cmb_EstadoPagos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_Pagos);
            this.Controls.Add(this.txt_Cod_FactC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Cod_FactV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Cod_Cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Cod_Empleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txt_Cod_FormaPago);
            this.Controls.Add(this.txt_Valor_Pagos);
            this.Controls.Add(this.lbl_TelefonoF);
            this.Controls.Add(this.lbl_TelefonoM);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultar_Modificar_Pagos";
            this.Text = "Consultar_Pagos";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Pagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Consulta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_EstadoPagos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_Pagos;
        private System.Windows.Forms.TextBox txt_Cod_FactC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cod_FactV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Cod_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Cod_Empleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txt_Cod_FormaPago;
        private System.Windows.Forms.TextBox txt_Valor_Pagos;
        private System.Windows.Forms.Label lbl_TelefonoF;
        private System.Windows.Forms.Label lbl_TelefonoM;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.DataGridView Grilla_Pagos;
        private System.Windows.Forms.TextBox txt_Numero_Pagos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}