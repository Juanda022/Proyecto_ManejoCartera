namespace NEGOCIO_PRESENTACION
{
    partial class Cargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargo));
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptb_Salir = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.btn_Nuevo_Cargo = new System.Windows.Forms.Button();
            this.Grilla_Cargo = new System.Windows.Forms.DataGridView();
            this.txt_Nombre_Cargo = new System.Windows.Forms.TextBox();
            this.txt_Codigo_Cargo = new System.Windows.Forms.TextBox();
            this.lbl_Nombre_Cargo = new System.Windows.Forms.Label();
            this.lbl_Codigo_Cargo = new System.Windows.Forms.Label();
            this.cmb_Cargo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Salir)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Cargo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1, 47);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(62, 61);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 88;
            this.pictureBox7.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.ptb_Salir);
            this.panel3.Location = new System.Drawing.Point(1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(732, 42);
            this.panel3.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cargo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(646, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ptb_Salir
            // 
            this.ptb_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_Salir.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Salir.Image")));
            this.ptb_Salir.Location = new System.Drawing.Point(688, 3);
            this.ptb_Salir.Name = "ptb_Salir";
            this.ptb_Salir.Size = new System.Drawing.Size(32, 32);
            this.ptb_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptb_Salir.TabIndex = 74;
            this.ptb_Salir.TabStop = false;
            this.ptb_Salir.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Modificar);
            this.panel1.Controls.Add(this.btn_Consulta);
            this.panel1.Controls.Add(this.btn_Nuevo_Cargo);
            this.panel1.Location = new System.Drawing.Point(609, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 377);
            this.panel1.TabIndex = 86;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_Eliminar.Location = new System.Drawing.Point(17, 268);
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
            this.btn_Modificar.Location = new System.Drawing.Point(17, 206);
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
            this.btn_Consulta.Location = new System.Drawing.Point(17, 147);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(95, 46);
            this.btn_Consulta.TabIndex = 24;
            this.btn_Consulta.Text = "Consulta";
            this.btn_Consulta.UseVisualStyleBackColor = false;
            this.btn_Consulta.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // btn_Nuevo_Cargo
            // 
            this.btn_Nuevo_Cargo.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Nuevo_Cargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nuevo_Cargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Nuevo_Cargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Nuevo_Cargo.ForeColor = System.Drawing.Color.Black;
            this.btn_Nuevo_Cargo.Location = new System.Drawing.Point(17, 81);
            this.btn_Nuevo_Cargo.Name = "btn_Nuevo_Cargo";
            this.btn_Nuevo_Cargo.Size = new System.Drawing.Size(95, 46);
            this.btn_Nuevo_Cargo.TabIndex = 23;
            this.btn_Nuevo_Cargo.Text = "Nuevo";
            this.btn_Nuevo_Cargo.UseVisualStyleBackColor = false;
            this.btn_Nuevo_Cargo.Click += new System.EventHandler(this.btn_Nuevo_Cargo_Click);
            // 
            // Grilla_Cargo
            // 
            this.Grilla_Cargo.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.Grilla_Cargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Cargo.Location = new System.Drawing.Point(112, 275);
            this.Grilla_Cargo.Name = "Grilla_Cargo";
            this.Grilla_Cargo.Size = new System.Drawing.Size(381, 91);
            this.Grilla_Cargo.TabIndex = 85;
            // 
            // txt_Nombre_Cargo
            // 
            this.txt_Nombre_Cargo.Location = new System.Drawing.Point(278, 187);
            this.txt_Nombre_Cargo.Name = "txt_Nombre_Cargo";
            this.txt_Nombre_Cargo.Size = new System.Drawing.Size(230, 20);
            this.txt_Nombre_Cargo.TabIndex = 84;
            this.txt_Nombre_Cargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_Cargo_KeyPress);
            // 
            // txt_Codigo_Cargo
            // 
            this.txt_Codigo_Cargo.Location = new System.Drawing.Point(278, 157);
            this.txt_Codigo_Cargo.Name = "txt_Codigo_Cargo";
            this.txt_Codigo_Cargo.Size = new System.Drawing.Size(230, 20);
            this.txt_Codigo_Cargo.TabIndex = 83;
            this.txt_Codigo_Cargo.TextChanged += new System.EventHandler(this.txt_Codigo_Cargo_TextChanged);
            this.txt_Codigo_Cargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_Cargo_KeyPress);
            // 
            // lbl_Nombre_Cargo
            // 
            this.lbl_Nombre_Cargo.AutoSize = true;
            this.lbl_Nombre_Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre_Cargo.ForeColor = System.Drawing.Color.Black;
            this.lbl_Nombre_Cargo.Location = new System.Drawing.Point(104, 189);
            this.lbl_Nombre_Cargo.Name = "lbl_Nombre_Cargo";
            this.lbl_Nombre_Cargo.Size = new System.Drawing.Size(68, 18);
            this.lbl_Nombre_Cargo.TabIndex = 82;
            this.lbl_Nombre_Cargo.Text = "Nombre";
            // 
            // lbl_Codigo_Cargo
            // 
            this.lbl_Codigo_Cargo.AutoSize = true;
            this.lbl_Codigo_Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo_Cargo.ForeColor = System.Drawing.Color.Black;
            this.lbl_Codigo_Cargo.Location = new System.Drawing.Point(105, 159);
            this.lbl_Codigo_Cargo.Name = "lbl_Codigo_Cargo";
            this.lbl_Codigo_Cargo.Size = new System.Drawing.Size(62, 18);
            this.lbl_Codigo_Cargo.TabIndex = 81;
            this.lbl_Codigo_Cargo.Text = "Codigo";
            // 
            // cmb_Cargo
            // 
            this.cmb_Cargo.FormattingEnabled = true;
            this.cmb_Cargo.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cmb_Cargo.Location = new System.Drawing.Point(278, 213);
            this.cmb_Cargo.Name = "cmb_Cargo";
            this.cmb_Cargo.Size = new System.Drawing.Size(234, 21);
            this.cmb_Cargo.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(109, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 94;
            this.label2.Text = "Estado";
            // 
            // Cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(733, 389);
            this.Controls.Add(this.cmb_Cargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grilla_Cargo);
            this.Controls.Add(this.txt_Nombre_Cargo);
            this.Controls.Add(this.txt_Codigo_Cargo);
            this.Controls.Add(this.lbl_Nombre_Cargo);
            this.Controls.Add(this.lbl_Codigo_Cargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cargo";
            this.Text = "Cargo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Salir)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Cargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptb_Salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Consulta;
        private System.Windows.Forms.Button btn_Nuevo_Cargo;
        private System.Windows.Forms.DataGridView Grilla_Cargo;
        private System.Windows.Forms.TextBox txt_Nombre_Cargo;
        private System.Windows.Forms.TextBox txt_Codigo_Cargo;
        private System.Windows.Forms.Label lbl_Nombre_Cargo;
        private System.Windows.Forms.Label lbl_Codigo_Cargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Cargo;
        private System.Windows.Forms.Label label2;
    }
}