namespace PILFINAL
{
    partial class frmregistro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmregistro));
            this.txtap = new System.Windows.Forms.TextBox();
            this.txtam = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbaño = new System.Windows.Forms.TextBox();
            this.lbmes = new System.Windows.Forms.TextBox();
            this.lbdia = new System.Windows.Forms.TextBox();
            this.lbgenero = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtap
            // 
            this.txtap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtap.Location = new System.Drawing.Point(101, 268);
            this.txtap.Name = "txtap";
            this.txtap.Size = new System.Drawing.Size(219, 13);
            this.txtap.TabIndex = 0;
            this.txtap.TextChanged += new System.EventHandler(this.txtap_TextChanged);
            this.txtap.Enter += new System.EventHandler(this.txtap_Enter);
            this.txtap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtap_KeyPress);
            this.txtap.Leave += new System.EventHandler(this.txtap_Leave);
            // 
            // txtam
            // 
            this.txtam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtam.Location = new System.Drawing.Point(101, 313);
            this.txtam.Name = "txtam";
            this.txtam.Size = new System.Drawing.Size(219, 13);
            this.txtam.TabIndex = 1;
            this.txtam.TextChanged += new System.EventHandler(this.txtam_TextChanged);
            this.txtam.Enter += new System.EventHandler(this.txtam_Enter);
            this.txtam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtam_KeyPress);
            this.txtam.Leave += new System.EventHandler(this.txtam_Leave);
            // 
            // txtnombre
            // 
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Location = new System.Drawing.Point(101, 354);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(219, 13);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            this.txtnombre.Enter += new System.EventHandler(this.txtnombre_Enter);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            this.txtnombre.Leave += new System.EventHandler(this.txtnombre_Leave);
            // 
            // txtcorreo
            // 
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcorreo.Location = new System.Drawing.Point(101, 441);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(219, 13);
            this.txtcorreo.TabIndex = 4;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged);
            this.txtcorreo.Enter += new System.EventHandler(this.txtcorreo_Enter);
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcorreo_KeyPress);
            this.txtcorreo.Leave += new System.EventHandler(this.txtcorreo_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(93, 496);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 38);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(209, 496);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(101, 38);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbaño
            // 
            this.lbaño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbaño.Location = new System.Drawing.Point(188, 397);
            this.lbaño.Name = "lbaño";
            this.lbaño.Size = new System.Drawing.Size(34, 13);
            this.lbaño.TabIndex = 11;
            this.lbaño.TextChanged += new System.EventHandler(this.lbaño_TextChanged);
            this.lbaño.Enter += new System.EventHandler(this.lbaño_Enter);
            this.lbaño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbaño_KeyPress);
            this.lbaño.Leave += new System.EventHandler(this.lbaño_Leave);
            // 
            // lbmes
            // 
            this.lbmes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbmes.Location = new System.Drawing.Point(145, 397);
            this.lbmes.Name = "lbmes";
            this.lbmes.Size = new System.Drawing.Size(28, 13);
            this.lbmes.TabIndex = 12;
            this.lbmes.TextChanged += new System.EventHandler(this.lbmes_TextChanged);
            this.lbmes.Enter += new System.EventHandler(this.lbmes_Enter);
            this.lbmes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbmes_KeyPress);
            this.lbmes.Leave += new System.EventHandler(this.lbmes_Leave);
            // 
            // lbdia
            // 
            this.lbdia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbdia.Location = new System.Drawing.Point(101, 397);
            this.lbdia.Name = "lbdia";
            this.lbdia.Size = new System.Drawing.Size(29, 13);
            this.lbdia.TabIndex = 13;
            this.lbdia.TextChanged += new System.EventHandler(this.lbdia_TextChanged);
            this.lbdia.Enter += new System.EventHandler(this.lbdia_Enter);
            this.lbdia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbdia_KeyPress);
            this.lbdia.Leave += new System.EventHandler(this.lbdia_Leave);
            // 
            // lbgenero
            // 
            this.lbgenero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbgenero.Location = new System.Drawing.Point(251, 397);
            this.lbgenero.Name = "lbgenero";
            this.lbgenero.Size = new System.Drawing.Size(79, 13);
            this.lbgenero.TabIndex = 14;
            this.lbgenero.TextChanged += new System.EventHandler(this.lbgenero_TextChanged);
            this.lbgenero.Enter += new System.EventHandler(this.lbgenero_Enter);
            this.lbgenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbgenero_KeyPress);
            this.lbgenero.Leave += new System.EventHandler(this.lbgenero_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmregistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PILFINAL.Properties.Resources.FORMULARIO_REGISTRO;
            this.ClientSize = new System.Drawing.Size(404, 570);
            this.Controls.Add(this.lbgenero);
            this.Controls.Add(this.lbdia);
            this.Controls.Add(this.lbmes);
            this.Controls.Add(this.lbaño);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtam);
            this.Controls.Add(this.txtap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmregistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmregistro";
            this.Load += new System.EventHandler(this.frmregistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtap;
        private System.Windows.Forms.TextBox txtam;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox lbaño;
        private System.Windows.Forms.TextBox lbmes;
        private System.Windows.Forms.TextBox lbdia;
        private System.Windows.Forms.TextBox lbgenero;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}