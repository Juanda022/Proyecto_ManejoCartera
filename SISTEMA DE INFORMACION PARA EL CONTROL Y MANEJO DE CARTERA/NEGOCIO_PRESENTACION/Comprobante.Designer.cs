namespace NEGOCIO_PRESENTACION
{
    partial class Comprobante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprobante));
            this.Grilla_Comprobante = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ptb_Regresar = new System.Windows.Forms.PictureBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Razon_Comprobante = new System.Windows.Forms.TextBox();
            this.txt_Nombre_Comprobante = new System.Windows.Forms.TextBox();
            this.dtp_Fecha_Comprobante = new System.Windows.Forms.DateTimePicker();
            this.cmb_Comprobante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Comprobante)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // Grilla_Comprobante
            // 
            this.Grilla_Comprobante.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.Grilla_Comprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Comprobante.Location = new System.Drawing.Point(62, 274);
            this.Grilla_Comprobante.Name = "Grilla_Comprobante";
            this.Grilla_Comprobante.Size = new System.Drawing.Size(390, 88);
            this.Grilla_Comprobante.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_Nuevo);
            this.panel1.Location = new System.Drawing.Point(539, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 393);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(13, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 46);
            this.button1.TabIndex = 27;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSalmon;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(13, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 46);
            this.button3.TabIndex = 26;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(13, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 46);
            this.button2.TabIndex = 25;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nuevo.ForeColor = System.Drawing.Color.Black;
            this.btn_Nuevo.Location = new System.Drawing.Point(13, 110);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(95, 46);
            this.btn_Nuevo.TabIndex = 24;
            this.btn_Nuevo.Text = "Consultar";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.ptb_Regresar);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 43);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "Comprobante";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(614, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ptb_Regresar
            // 
            this.ptb_Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Regresar.Image")));
            this.ptb_Regresar.Location = new System.Drawing.Point(572, 8);
            this.ptb_Regresar.Name = "ptb_Regresar";
            this.ptb_Regresar.Size = new System.Drawing.Size(36, 31);
            this.ptb_Regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Regresar.TabIndex = 58;
            this.ptb_Regresar.TabStop = false;
            this.ptb_Regresar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.Color.Black;
            this.lbl_codigo.Location = new System.Drawing.Point(73, 90);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(57, 18);
            this.lbl_codigo.TabIndex = 60;
            this.lbl_codigo.Text = "Razon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(73, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 61;
            this.label1.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(73, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "Nombre";
            // 
            // txt_Razon_Comprobante
            // 
            this.txt_Razon_Comprobante.Location = new System.Drawing.Point(182, 88);
            this.txt_Razon_Comprobante.Name = "txt_Razon_Comprobante";
            this.txt_Razon_Comprobante.Size = new System.Drawing.Size(178, 20);
            this.txt_Razon_Comprobante.TabIndex = 63;
            this.txt_Razon_Comprobante.TextChanged += new System.EventHandler(this.txt_Razon_Comprobante_TextChanged);
            this.txt_Razon_Comprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Razon_Comprobante_KeyPress);
            // 
            // txt_Nombre_Comprobante
            // 
            this.txt_Nombre_Comprobante.Location = new System.Drawing.Point(182, 177);
            this.txt_Nombre_Comprobante.Name = "txt_Nombre_Comprobante";
            this.txt_Nombre_Comprobante.Size = new System.Drawing.Size(178, 20);
            this.txt_Nombre_Comprobante.TabIndex = 65;
            this.txt_Nombre_Comprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_Comprobante_KeyPress);
            // 
            // dtp_Fecha_Comprobante
            // 
            this.dtp_Fecha_Comprobante.Location = new System.Drawing.Point(182, 130);
            this.dtp_Fecha_Comprobante.Name = "dtp_Fecha_Comprobante";
            this.dtp_Fecha_Comprobante.Size = new System.Drawing.Size(178, 20);
            this.dtp_Fecha_Comprobante.TabIndex = 66;
            // 
            // cmb_Comprobante
            // 
            this.cmb_Comprobante.FormattingEnabled = true;
            this.cmb_Comprobante.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmb_Comprobante.Location = new System.Drawing.Point(182, 213);
            this.cmb_Comprobante.Name = "cmb_Comprobante";
            this.cmb_Comprobante.Size = new System.Drawing.Size(178, 21);
            this.cmb_Comprobante.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(74, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 96;
            this.label3.Text = "Estado";
            // 
            // Comprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(657, 387);
            this.Controls.Add(this.cmb_Comprobante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_Fecha_Comprobante);
            this.Controls.Add(this.txt_Nombre_Comprobante);
            this.Controls.Add(this.txt_Razon_Comprobante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grilla_Comprobante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comprobante";
            this.Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Comprobante)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Regresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla_Comprobante;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptb_Regresar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Razon_Comprobante;
        private System.Windows.Forms.TextBox txt_Nombre_Comprobante;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Comprobante;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Comprobante;
        private System.Windows.Forms.Label label3;
    }
}