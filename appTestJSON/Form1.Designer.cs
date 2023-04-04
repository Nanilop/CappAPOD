namespace appTestJSON
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.btnNorm = new System.Windows.Forms.RadioButton();
            this.btnHD = new System.Windows.Forms.RadioButton();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.listFotos = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(633, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consulta a NASA: Foto del día";
            // 
            // dtpInicial
            // 
            this.dtpInicial.CustomFormat = "yyyy-MM-dd";
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicial.Location = new System.Drawing.Point(6, 35);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(99, 20);
            this.dtpInicial.TabIndex = 3;
            // 
            // dtpFinal
            // 
            this.dtpFinal.CustomFormat = "yyyy-MM-dd";
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinal.Location = new System.Drawing.Point(111, 35);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(99, 20);
            this.dtpFinal.TabIndex = 4;
            // 
            // btnNorm
            // 
            this.btnNorm.AutoSize = true;
            this.btnNorm.Checked = true;
            this.btnNorm.Location = new System.Drawing.Point(6, 19);
            this.btnNorm.Name = "btnNorm";
            this.btnNorm.Size = new System.Drawing.Size(58, 17);
            this.btnNorm.TabIndex = 5;
            this.btnNorm.TabStop = true;
            this.btnNorm.Text = "Normal";
            this.btnNorm.UseVisualStyleBackColor = true;
            this.btnNorm.CheckedChanged += new System.EventHandler(this.btnNorm_CheckedChanged);
            // 
            // btnHD
            // 
            this.btnHD.AutoSize = true;
            this.btnHD.Location = new System.Drawing.Point(109, 19);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(41, 17);
            this.btnHD.TabIndex = 6;
            this.btnHD.Text = "HD";
            this.btnHD.UseVisualStyleBackColor = true;
            this.btnHD.CheckedChanged += new System.EventHandler(this.btnHD_CheckedChanged);
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(12, 117);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(696, 366);
            this.picFoto.TabIndex = 8;
            this.picFoto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fin:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNorm);
            this.groupBox1.Controls.Add(this.btnHD);
            this.groupBox1.Location = new System.Drawing.Point(242, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 48);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calidad";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(633, 55);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 14;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // listFotos
            // 
            this.listFotos.FormattingEnabled = true;
            this.listFotos.Location = new System.Drawing.Point(6, 18);
            this.listFotos.Name = "listFotos";
            this.listFotos.Size = new System.Drawing.Size(188, 21);
            this.listFotos.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpInicial);
            this.groupBox2.Controls.Add(this.dtpFinal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(19, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 65);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listFotos);
            this.groupBox3.Location = new System.Drawing.Point(422, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 48);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fotografías:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 495);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "NASA APOD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.RadioButton btnNorm;
        private System.Windows.Forms.RadioButton btnHD;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox listFotos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

