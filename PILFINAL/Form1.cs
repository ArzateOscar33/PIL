using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace PILFINAL
{
    public partial class Form1 : Form
    {

        
        string clave1 = "";
        string cl = "";
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

            txtcorreo.Text = "Introduzca su correo";
            txtcorreo.ForeColor = Color.Gray;

            txtclave.PasswordChar = '\0';
            txtclave.Text = "Introduzca su contraseña";
            txtclave.ForeColor = Color.Gray;
        }

    private void btnregistrarse_Click(object sender, EventArgs e)
        {
            frmregistro fregistro = new frmregistro();
            fregistro.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            principal p = new principal();
            p.Show();
            this.Hide();


        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            frmregistro r = new frmregistro();
            r.Show();

        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btniniciar_Click_1(object sender, EventArgs e)
        {
        
            if (Form1.autenticar(txtcorreo.Text,txtclave.Text)>0) {
                MessageBox.Show("Bienvenido");
                //MAÑANA LO CAMBIAS WEY TIENES QUE CRESR EL FORMULARIO PRINCIPAL
                principal p = new principal();
                p.Show();
                this.Hide();
                p.lblcorreo.Text = txtcorreo.Text;
                p.lblclave.Text = txtclave.Text;
               
                
            }else {
                MessageBox.Show("no se pudo iniciar sesion");
            }


        }

        public static int  autenticar(string pcorreo,string ppassword)
        {
            int resultado = -1;
            SQLiteCommand cmd = new SQLiteCommand(string.Format(
                "SELECT * FROM registro_alumnos WHERE correo='{0}' and password='{1}'", pcorreo, ppassword), conexion.InstanciaDb());
            SQLiteDataReader reader = cmd.ExecuteReader();
            while(reader.Read()) {
                resultado = 50;
            }
            return resultado;

        }

        private void txtcorreo_Enter(object sender, EventArgs e)
        {
            txtcorreo.Text = "";
            txtcorreo.ForeColor = Color.Black;
        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            cl = txtcorreo.Text;
            if (cl.Equals("Introduzca su Correo"))
            {
                txtcorreo.Text = "Introduzca su correo";
                txtcorreo.ForeColor = Color.Gray;

            }//if
            else
            {
                if (cl.Equals(""))
                {
                    txtcorreo.Text = "Introduzca su correo";
                    txtcorreo.ForeColor = Color.Gray;
                }//if
                else
                {
                    txtcorreo.Text = cl;
                    txtcorreo.ForeColor = Color.Black;
                }
            }
        }

        private void txtclave_Enter(object sender, EventArgs e)
        {

            txtclave.Text = "";
            txtclave.ForeColor = Color.Black;
            txtclave.PasswordChar = '*';
        }

        private void txtclave_Leave(object sender, EventArgs e)
        {
            clave1 = txtclave.Text;
            if (clave1.Equals("Introduzca su contraseña"))
            {
                txtclave.Text = "Introduzca su correo";
                txtclave.ForeColor = Color.Gray;

            }//if
            else
            {
                if (clave1.Equals(""))
                {
                    txtclave.PasswordChar = '\0';
                    txtclave.Text = "Introduzca su contraseña";
                    txtclave.ForeColor = Color.Gray;
                }//if
                else
                {
                    txtclave.PasswordChar = '*';
                    txtclave.Text = clave1;
                    txtclave.ForeColor = Color.Black;
                }
            }
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
