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
    public partial class principal : Form
    {
        public principal()
        {

            InitializeComponent();

        }


        private void nombre_Click(object sender, EventArgs e)
        {
          




        }

       
        private void principal_Load(object sender, EventArgs e)
        {
          

        }
        public static int autenticar(string pcorreo, string ppassword)
        {
            int resultado = -1;
            SQLiteCommand cmd = new SQLiteCommand(string.Format(
                "SELECT * FROM registro_alumnos WHERE correo='{0}' and password='{1}'", pcorreo, ppassword), conexion.InstanciaDb());
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                resultado = 50;
            }
            return resultado;

        }

        private void correo_Click(object sender, EventArgs e)
        {

        }
   

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            examen ex = new examen();
            ex.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            formulariocontacto contacto = new formulariocontacto();
            contacto.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El archivo se creo correctamente");
            //  var sql = "SELECT * FROM registro_alumnos where (ID=@id)";
            conexion.ConsultaDB();
        }

        private void lblcorreo_Click(object sender, EventArgs e)
        {

        }
    }
}

