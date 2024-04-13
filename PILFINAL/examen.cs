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
    public partial class examen : Form
    {
        public examen()
        {
            InitializeComponent();
        }

        private void btnsalirexamen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       // private void button2_Click(object sender, EventArgs e)
//        {

        //}

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void examen_Load(object sender, EventArgs e)
        {
            Iniciar();
        }

        int resultado = 0;
        int seleccion = 1;
        private void Iniciar()
        {
            if (MessageBox.Show("Bienvenido a PIL", "Evaluacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.pregunta.Text = "¿Quien es el Dios del Trueno en la mitologia Griega?";
                this.opcion1.Text = "Hades";
                this.opcion2.Text = "Poseidon";
                this.opcion3.Text = "Zeus";
                this.opcion4.Text = "Apolo";
            }
            else
            {
                Application.Exit();
            }

        }

        private void pregunta2()
        {
            this.pregunta.Text = "¿Cómo se denomina el resultado de la multiplicación?";
            this.opcion1.Text = "Residuo";
            this.opcion2.Text = "Producto";
            this.opcion3.Text = "Dominio";
            this.opcion4.Text = "Rango";
            seleccion++;
        }
        private void pregunta3()
        {
            this.pregunta.Text = "¿Qué año llegó Cristóbal Colón a América?.";
            this.opcion1.Text = "1315";
            this.opcion2.Text = "1965";
            this.opcion3.Text = "1950";
            this.opcion4.Text = "1492";
            seleccion++;
        }
        private void pregunta4()
        {
            this.pregunta.Text = "¿En qué año comenzó la II Guerra Mundial? ";
            this.opcion1.Text = "1945";
            this.opcion2.Text = "1939";
            this.opcion3.Text = "1940";
            this.opcion4.Text = "1935";
            seleccion++;
        }
        private void pregunta5()
        {
            this.pregunta.Text = "¿A qué velocidad debe circular un auto de carreras para recorrer 50km en un cuarto de hora? ";
            this.opcion1.Text = "100 km/h";
            this.opcion2.Text = "189 km/h";
            this.opcion3.Text = "200 km/h";
            this.opcion4.Text = "200 m/s";
            seleccion++;
        }
        private void pregunta6()
        {
            this.pregunta.Text = "¿Cual es la regla gramatical de la letra B";
            this.opcion1.Text = "Se escribe b siempre que ésta va seguida de las consonantes l ó r.";
            this.opcion2.Text = "Después de –ol";
            this.opcion3.Text = "Las palabras que empiezan con di";
            this.opcion4.Text = "Ninguna de las anteriores ";
            seleccion++;
        }
        private void pregunta7()
        {
            this.pregunta.Text = "Si Alberto recorre con su patinete una pista de 300 metros en un minuto, ¿a qué velocidad circula?";
            this.opcion1.Text = "3 m/s ";
            this.opcion2.Text = "8 m/s ";
            this.opcion3.Text = "5 km/h ";
            this.opcion4.Text = "5 m/s";
            seleccion++;
        }
        private void pregunta8()
        {
            this.pregunta.Text = "¿Quien fue el escritor de la Divina Comedia?";
            this.opcion1.Text = "Homero";
            this.opcion2.Text = "Dante Alighieri";
            this.opcion3.Text = "Mauricio Hernandez";
            this.opcion4.Text = "Gabriel Garcia Marquez";
            seleccion++;
        }
        private void pregunta9()
        {
            this.pregunta.Text = "Palabra Escrita con el acento Correctamente";
            this.opcion1.Text = "Diá";
            this.opcion2.Text = "Minutó";
            this.opcion3.Text = "Artefácto ";
            this.opcion4.Text = "Acné";
            seleccion++;
        }
        private void pregunta10()
        {
            this.pregunta.Text = "¿Cual es el numero atomico del Oxigeno?";
            this.opcion1.Text = " 18";
            this.opcion2.Text = " 9";
            this.opcion3.Text = " 8";
            this.opcion4.Text = " 12";
            seleccion++;
        }
        private void Limpiar()
        {
            this.opcion1.Checked = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            switch (seleccion)
            {
                case 1:
                    if (this.opcion3.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta2();
                    Limpiar();
                    break;

                case 2:
                    if (this.opcion2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.opcion4.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.opcion2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta5();
                    Limpiar();
                    break;

                case 5:
                    if (this.opcion3.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta6();
                    Limpiar();
                    break;

                case 6:
                    if (this.opcion1.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta7();
                    Limpiar();
                    break;

                case 7:
                    if (this.opcion4.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta8();
                    Limpiar();
                    break;

                case 8:
                    if (this.opcion2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta9();
                    Limpiar();
                    break;

                case 9:
                    if (this.opcion4.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta10();
                    Limpiar();
                    break;

                case 10:
                    if (this.opcion3.Checked == true)
                    {
                        resultado++;
                    }
                    if (resultado >= 7)
                    {
                        MessageBox.Show(resultado.ToString(), "FELICITACIONES HAZ SIDO ACEPTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                        var sql = "INSERT into examen(id,puntaje) values (@id,@puntaje)";
                        var sqli = "INSERT INTO examen(id) SELECT id from registro_alumnos";

                        SQLiteCommand cmd1 = new SQLiteCommand(sqli, conexion.InstanciaDb());
                       ;
                        SQLiteCommand cmd = new SQLiteCommand(sql, conexion.InstanciaDb());
                        cmd.Parameters.Add(new SQLiteParameter("@puntaje",resultado));
                        cmd.Parameters.Add(new SQLiteParameter("@id", cmd1.ExecuteReader() ));

                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show(resultado.ToString(), "Suerte la Proxima", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var sql = "INSERT into examen(puntaje) values (@puntaje)";
                        SQLiteCommand cmd = new SQLiteCommand(sql, conexion.InstanciaDb());
                        cmd.Parameters.Add(new SQLiteParameter("@puntaje", resultado));
                        cmd.ExecuteNonQuery();
                        Application.Exit();
                    }

                    break;
                default:
                    break;
            }
        }





    }///hasta aqui
}
