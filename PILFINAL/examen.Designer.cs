namespace PILFINAL
{
    partial class examen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(examen));
            this.button1 = new System.Windows.Forms.Button();
            this.btnsalirexamen = new System.Windows.Forms.Button();
            this.pregunta = new System.Windows.Forms.Label();
            this.opcion1 = new System.Windows.Forms.RadioButton();
            this.opcion2 = new System.Windows.Forms.RadioButton();
            this.opcion3 = new System.Windows.Forms.RadioButton();
            this.opcion4 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsalirexamen
            // 
            this.btnsalirexamen.Location = new System.Drawing.Point(239, 475);
            this.btnsalirexamen.Name = "btnsalirexamen";
            this.btnsalirexamen.Size = new System.Drawing.Size(75, 23);
            this.btnsalirexamen.TabIndex = 2;
            this.btnsalirexamen.Text = "Salir";
            this.btnsalirexamen.UseVisualStyleBackColor = true;
            this.btnsalirexamen.Click += new System.EventHandler(this.btnsalirexamen_Click);
            // 
            // pregunta
            // 
            this.pregunta.AutoSize = true;
            this.pregunta.Location = new System.Drawing.Point(57, 131);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(35, 13);
            this.pregunta.TabIndex = 3;
            this.pregunta.Text = "label1";
            // 
            // opcion1
            // 
            this.opcion1.AutoSize = true;
            this.opcion1.Location = new System.Drawing.Point(83, 179);
            this.opcion1.Name = "opcion1";
            this.opcion1.Size = new System.Drawing.Size(85, 17);
            this.opcion1.TabIndex = 4;
            this.opcion1.TabStop = true;
            this.opcion1.Text = "radioButton1";
            this.opcion1.UseVisualStyleBackColor = true;
            // 
            // opcion2
            // 
            this.opcion2.AutoSize = true;
            this.opcion2.Location = new System.Drawing.Point(83, 240);
            this.opcion2.Name = "opcion2";
            this.opcion2.Size = new System.Drawing.Size(85, 17);
            this.opcion2.TabIndex = 5;
            this.opcion2.TabStop = true;
            this.opcion2.Text = "radioButton2";
            this.opcion2.UseVisualStyleBackColor = true;
            // 
            // opcion3
            // 
            this.opcion3.AutoSize = true;
            this.opcion3.Location = new System.Drawing.Point(83, 306);
            this.opcion3.Name = "opcion3";
            this.opcion3.Size = new System.Drawing.Size(85, 17);
            this.opcion3.TabIndex = 6;
            this.opcion3.TabStop = true;
            this.opcion3.Text = "radioButton3";
            this.opcion3.UseVisualStyleBackColor = true;
            this.opcion3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // opcion4
            // 
            this.opcion4.AutoSize = true;
            this.opcion4.Location = new System.Drawing.Point(83, 360);
            this.opcion4.Name = "opcion4";
            this.opcion4.Size = new System.Drawing.Size(85, 17);
            this.opcion4.TabIndex = 7;
            this.opcion4.TabStop = true;
            this.opcion4.Text = "radioButton4";
            this.opcion4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PILFINAL.Properties.Resources.cuadroparaborrarbotones;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(48, 463);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PILFINAL.Properties.Resources.INTERFAZ_EXAMEN;
            this.ClientSize = new System.Drawing.Size(807, 525);
            this.Controls.Add(this.opcion4);
            this.Controls.Add(this.opcion3);
            this.Controls.Add(this.opcion2);
            this.Controls.Add(this.opcion1);
            this.Controls.Add(this.pregunta);
            this.Controls.Add(this.btnsalirexamen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "examen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "examen";
            this.Load += new System.EventHandler(this.examen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsalirexamen;
        private System.Windows.Forms.Label pregunta;
        private System.Windows.Forms.RadioButton opcion1;
        private System.Windows.Forms.RadioButton opcion2;
        private System.Windows.Forms.RadioButton opcion3;
        private System.Windows.Forms.RadioButton opcion4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}