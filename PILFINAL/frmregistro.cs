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
using System.Text.RegularExpressions;

namespace PILFINAL
{
    public partial class frmregistro : Form
    {
        //Creamos estas variables para el forecolor de los textbox

        string ap = "";
        string am = "";
        string nombre1 = "";
        string dia = "";
        string mes = "";
        string año = "";
        string genero = "";
        string correo1= "";

        validar v = new validar();
        public string nombre = "";
        public string correo = "";
        public frmregistro()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtnombre.Text) ||
                string.IsNullOrWhiteSpace(txtap.Text) ||
                string.IsNullOrWhiteSpace(txtam.Text) ||
                string.IsNullOrWhiteSpace(lbdia.Text) ||
                string.IsNullOrWhiteSpace(lbmes.Text) ||
                string.IsNullOrWhiteSpace(lbaño.Text) ||
                string.IsNullOrWhiteSpace(lbgenero.Text) ||
                string.IsNullOrWhiteSpace(txtcorreo.Text))
            {
                MessageBox.Show("Introduzca todos los datos");
                return;
            }

            // Verificar que los campos no contengan los valores predeterminados
            if (txtnombre.Text == "Introduzca su Nombre(s)" ||
                txtap.Text == "Introduzca su Apellido Paterno" ||
                txtam.Text == "Introduzca su Apellido Materno" ||
                lbgenero.Text == "Genero")
            {
                MessageBox.Show("Introduzca los datos correctamente");
                return;
            }

            try
            {
                // Validación de año
                int año = Convert.ToInt32(lbaño.Text);
                if (año < 2010 && año > 1970)
                {
                    // Validación de mes
                    int mes = Convert.ToInt32(lbmes.Text);
                    if (mes < 12 && mes > 0)
                    {
                        // Validación de día
                        int dia = Convert.ToInt32(lbdia.Text);
                        if (dia <= 31 && dia > 0)
                        {
                            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 9 || mes == 11)
                            {
                                if (dia <= 31 && dia > 0)
                                {
                                    RegistrarUsuario();
                                }
                            }
                            else if (mes == 2)
                            {
                                if (dia <= 29 && dia > 0)
                                {
                                    RegistrarUsuario();
                                }
                                else
                                {
                                    MessageBox.Show("Introduzca una fecha válida para Febrero");
                                }
                            }
                            else
                            {
                                if (dia <= 30 && dia > 0)
                                {
                                    RegistrarUsuario();
                                }
                                else
                                {
                                    MessageBox.Show("Introduzca una fecha válida");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Introduzca un valor válido para el día");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Introduzca un valor válido para el mes");
                    }
                }
                else
                {
                    MessageBox.Show("Introduzca un valor válido para el año");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduzca valores numéricos válidos para día, mes y año");
            }
        }

        /*  private void RegistrarUsuario()
          {
              //string password = "12345678";
              var sql = "insert into registro_alumnos(ap_paterno,ap_materno,nombre,genero,dia,mes,year,correo,password) values (@ap_paterno,@ap_materno,@nombre,@genero,@dia,@mes,@year,@correo,'12345678')";
              SQLiteCommand cmd = new SQLiteCommand(sql, conexion.InstanciaDb());

              //Enviamos los parametros
              //Nombre
              cmd.Parameters.Add(new SQLiteParameter("@nombre", txtnombre.Text));
              //Ap Paterno
              cmd.Parameters.Add(new SQLiteParameter("@ap_paterno", txtap.Text));
              //Ap materno
              cmd.Parameters.Add(new SQLiteParameter("@ap_materno", txtam.Text));
              //dia
              cmd.Parameters.Add(new SQLiteParameter("@dia", lbdia.Text));
              //mes
              cmd.Parameters.Add(new SQLiteParameter("@mes", lbmes.Text));
              //año
              cmd.Parameters.Add(new SQLiteParameter("@year", lbaño.Text));
              //genero
              cmd.Parameters.Add(new SQLiteParameter("@genero", lbgenero.Text));
              //correo
              cmd.Parameters.Add(new SQLiteParameter("@correo", txtcorreo.Text));
              //password
              // cmd.Parameters.Add(new SQLiteParameter("@correo", password));
              cmd.Parameters.Add(new SQLiteParameter("@id"));
              cmd.ExecuteNonQuery();

              MessageBox.Show("Usuario Registrado.");
              //bloqueamos los textbox
              txtnombre.Enabled = false;
              txtap.Enabled = false;
              txtam.Enabled = false;
              lbdia.Enabled = false;
              lbmes.Enabled = false;
              lbaño.Enabled = false;
              lbgenero.Enabled = false;
              txtcorreo.Enabled = false;
              btnAceptar.Enabled = false;
              MessageBox.Show("Tu usuario es " + txtcorreo.Text + " y tu contraseña es : 12345678");
              //contrato.Ejecutar(txtnombre.Text);
              //contrato.Ejecutar(txtcorreo.Text);
          }*/


        private void RegistrarUsuario()
        {
            try
            {
                // Definir el comando SQL para la inserción
                var sql = "insert into registro_alumnos(ap_paterno,ap_materno,nombre,genero,dia,mes,year,correo,password) values (@ap_paterno,@ap_materno,@nombre,@genero,@dia,@mes,@year,@correo,'12345678')";
                SQLiteCommand cmd = new SQLiteCommand(sql, conexion.InstanciaDb());

                // Enviar los parámetros
                cmd.Parameters.Add(new SQLiteParameter("@nombre", txtnombre.Text));
                cmd.Parameters.Add(new SQLiteParameter("@ap_paterno", txtap.Text));
                cmd.Parameters.Add(new SQLiteParameter("@ap_materno", txtam.Text));
                cmd.Parameters.Add(new SQLiteParameter("@dia", lbdia.Text));
                cmd.Parameters.Add(new SQLiteParameter("@mes", lbmes.Text));
                cmd.Parameters.Add(new SQLiteParameter("@year", lbaño.Text));
                cmd.Parameters.Add(new SQLiteParameter("@genero", lbgenero.Text));
                cmd.Parameters.Add(new SQLiteParameter("@correo", txtcorreo.Text));

                // Ejecutar el comando
                cmd.ExecuteNonQuery();

                // Mostrar mensaje de éxito
                MessageBox.Show("Usuario Registrado.");

                // Bloquear los campos de texto y el botón
                txtnombre.Enabled = false;
                txtap.Enabled = false;
                txtam.Enabled = false;
                lbdia.Enabled = false;
                lbmes.Enabled = false;
                lbaño.Enabled = false;
                lbgenero.Enabled = false;
                txtcorreo.Enabled = false;
                btnAceptar.Enabled = false;

                // Mostrar información del usuario
                MessageBox.Show("Tu usuario es " + txtcorreo.Text + " y tu contraseña es : 12345678");
            }
            catch (SQLiteException ex)
            {
                // Manejar la excepción y mostrar un mensaje de error
                if (ex.ResultCode == SQLiteErrorCode.Constraint && ex.Message.Contains("UNIQUE"))
                {
                    MessageBox.Show("El correo ya está registrado. Introduzca un correo diferente.");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar el usuario: " + ex.Message);
                }
            }
        }



        private void txtap_TextChanged(object sender, EventArgs e)
        {
            validarcampovacio();
        }

        private  void txtnombre_TextChanged(object sender, EventArgs e)
        {
            validarcampovacio();
        }
        private void ValidateFields(object sender, EventArgs e)
        {
            // Verificar si todos los campos no están vacíos
            btnAceptar.Enabled = !string.IsNullOrWhiteSpace(txtnombre.Text) &&
                                 !string.IsNullOrWhiteSpace(txtap.Text) &&
                                 !string.IsNullOrWhiteSpace(txtam.Text) &&
                                 !string.IsNullOrWhiteSpace(lbdia.Text) &&
                                 !string.IsNullOrWhiteSpace(lbmes.Text) &&
                                 !string.IsNullOrWhiteSpace(lbaño.Text) &&
                                 !string.IsNullOrWhiteSpace(lbgenero.Text) &&
                                 !string.IsNullOrWhiteSpace(txtcorreo.Text);
        }
        private void frmregistro_Load(object sender, EventArgs e)
        {
            // Agregar eventos TextChanged a los campos de texto para la validación
            txtnombre.TextChanged += new EventHandler(ValidateFields);
            txtap.TextChanged += new EventHandler(ValidateFields);
            txtam.TextChanged += new EventHandler(ValidateFields);
            lbdia.TextChanged += new EventHandler(ValidateFields);
            lbmes.TextChanged += new EventHandler(ValidateFields);
            lbaño.TextChanged += new EventHandler(ValidateFields);
            lbgenero.TextChanged += new EventHandler(ValidateFields);
            txtcorreo.TextChanged += new EventHandler(ValidateFields);

            btnAceptar.Enabled = false;
            //hacemos que tengan un texto los tectbox en color gris

            txtap.Text = "Introduzca su Apellido Paterno";
            txtap.ForeColor = Color.Gray;

            txtam.Text = "Introduzca su Apellido Materno";
            txtam.ForeColor = Color.Gray;

            txtnombre.Text = "Introduzca su Nombre(s)";
            txtnombre.ForeColor = Color.Gray;

            lbdia.Text = "Dia";
            lbdia.ForeColor = Color.Gray;

            lbmes.Text = "Mes";
            lbmes.ForeColor = Color.Gray;


            lbaño.Text = "Año ";
            lbaño.ForeColor = Color.Gray;


            lbgenero.Text = "Genero";
            lbgenero.ForeColor = Color.Gray;

            txtcorreo.Text = "Introduzca su Correo Electronico";
            txtcorreo.ForeColor = Color.Gray;



            

        }

        public void validarcampovacio()
        {
            var vr = !string.IsNullOrEmpty(txtam.Text) &&
                    !string.IsNullOrEmpty(txtap.Text) &&
                    !string.IsNullOrEmpty(txtnombre.Text) &&
                    !string.IsNullOrEmpty(lbdia.Text) &&
                    !string.IsNullOrEmpty(lbmes.Text) &&
                    !string.IsNullOrEmpty(lbaño.Text) &&
                    !string.IsNullOrEmpty(txtcorreo.Text) &&
                    !string.IsNullOrEmpty(lbgenero.Text);
            btnAceptar.Enabled = vr;
        }
       public IContract contrato {get; set;}

        private void txtap_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txtam_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void lbdia_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void lbmes_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void lbaño_TextChanged(object sender, EventArgs e)
        {
            validarcampovacio();
        }

        private void lbaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void lbgenero_TextChanged(object sender, EventArgs e)
        {
            validarcampovacio();
        }

        private void lbgenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
            validarcampovacio();

        }

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
           // v.soloLetras(e);
        }

        private void lbdia_TextChanged(object sender, EventArgs e)
        {
            validarcampovacio();
        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtcorreo.Text,pattern))
            {
                errorProvider1.Clear();
            }//if
            else
            {
                errorProvider1.SetError(this.txtcorreo, "Introduzca un correo valido");
                MessageBox.Show("introduzca un correo");
                return;
            }
        }

        private void txtam_TextChanged(object sender, EventArgs e)
        {
            validarcampovacio();
        }

        private void lbmes_TextChanged(object sender, EventArgs e)
        {
            validarcampovacio();
        }

        private void txtap_Enter(object sender, EventArgs e)
        {
            txtap.Text = "";
            txtap.ForeColor = Color.Black;
        }

        private void txtap_Leave(object sender, EventArgs e)
        {
            ap = txtap.Text;
            if(ap.Equals("Introduzca su Apellido Paterno")){
                txtap.Text = "Introduzca su Apellido Paterno";
                txtap.ForeColor = Color.Gray;

            }//if
            else
            {
                if (ap.Equals(""))
                {
                    txtap.Text = "Introduzca su Apellido Paterno";
                    txtap.ForeColor = Color.Gray;
                }//if
                else
                {
                    txtap.Text = ap;
                    txtap.ForeColor = Color.Black;
                }
            }
        }

        private void txtam_Leave(object sender, EventArgs e)
        {
            am = txtam.Text;
            if (am.Equals("Introduzca su apellido Materno"))
            {
                txtam.Text = "Introduzca su apellido Materno";
                txtam.ForeColor = Color.Gray;

            }//if
            else
            {
                if (am.Equals(""))
                {
                    txtam.Text = "Introduzca su apellido Materno";
                    txtam.ForeColor = Color.Gray;
                }//if
                else
                {
                    txtam.Text = am;
                    txtam.ForeColor = Color.Black;
                }
            }
        }

        private void txtam_Enter(object sender, EventArgs e)
        {
            txtam.Text = "";
            txtam.ForeColor = Color.Black;
        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtnombre.ForeColor = Color.Black;
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            nombre1 = txtnombre.Text;
            if (nombre1.Equals("Introduzca su Nombre(s)"))
            {
                txtnombre.Text = "Introduzca su Nombre(s)";
                txtnombre.ForeColor = Color.Gray;

            }//if
            else
            {
                if (nombre1.Equals(""))
                {
                    txtnombre.Text = "Introduzca su Nombre(s) ";
                    txtnombre.ForeColor = Color.Gray;
                }//if
                else
                {
                    txtnombre.Text = nombre1;
                    txtnombre.ForeColor = Color.Black;
                }
            }
        }

        private void lbdia_Enter(object sender, EventArgs e)
        {
            lbdia.Text = "";
            lbdia.ForeColor = Color.Black;
        }

        private void lbdia_Leave(object sender, EventArgs e)
        {
            dia = lbdia.Text;
            if (dia.Equals("Dia"))
            {
                lbdia.Text = "Dia";
                lbdia.ForeColor = Color.Gray;

            }//if
            else
            {
                if (dia.Equals(""))
                {
                    lbdia.Text = "Dia";
                    lbdia.ForeColor = Color.Gray;
                }//if
                else
                {
                    lbdia.Text = dia;
                    lbdia.ForeColor = Color.Black;
                }
            }
        }

        private void lbmes_Enter(object sender, EventArgs e)
        {
            lbmes.Text = "";
            lbmes.ForeColor = Color.Black;
        }

        private void lbmes_Leave(object sender, EventArgs e)
        {
            mes = lbmes.Text;
            if (mes.Equals("Mes")){
                lbmes.Text = "Mes";
                lbmes.ForeColor = Color.Gray;

            }//if
            else
            {
                if (mes.Equals(""))
                {
                    lbmes.Text = "Mes";
                    lbmes.ForeColor = Color.Gray;
                }//if
                else
                {
                    lbmes.Text = mes;
                    lbmes.ForeColor = Color.Black;
                }
            }
        }

        private void lbaño_Enter(object sender, EventArgs e)
        {
            lbaño.Text = "";
            lbaño.ForeColor = Color.Black;
        }

        private void lbaño_Leave(object sender, EventArgs e)
        {
            año = lbaño.Text;
            if (año.Equals("Año"))
            {
                lbaño.Text = "Año";
                lbaño.ForeColor = Color.Gray;

            }//if
            else
            {
                if (año.Equals(""))
                {
                    lbaño.Text = "Año";
                    lbaño.ForeColor = Color.Gray;
                }//if
                else
                {
                    lbaño.Text = año;
                    lbaño.ForeColor = Color.Black;
                }
            }
        }

        private void lbgenero_Enter(object sender, EventArgs e)
        {
            lbgenero.Text = "";
            lbgenero.ForeColor = Color.Black;
        }

        private void lbgenero_Leave(object sender, EventArgs e)
        {
            genero = lbgenero.Text;
            if (genero.Equals("Genero"))
            {
                lbgenero.Text = "Genero";
                lbgenero.ForeColor = Color.Gray;

            }//if
            else
            {
                if (genero.Equals(""))
                {
                    lbgenero.Text = "Genero";
                    lbgenero.ForeColor = Color.Gray;
                }//if
                else
                {
                    lbgenero.Text = genero;
                    lbgenero.ForeColor = Color.Black;
                }
            }
        }

        private void txtcorreo_Enter(object sender, EventArgs e)
        {
             txtcorreo.Text = "";
               txtcorreo.ForeColor = Color.Black;
        }
    }
}
