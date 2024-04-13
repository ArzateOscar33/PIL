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
using System.IO;


namespace PILFINAL
{
    public partial class formulariocontacto : Form
    {
    
        public formulariocontacto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            examen ex = new examen();
            ex.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El archivo se creo correctamente");
          //  var sql = "SELECT * FROM registro_alumnos where (ID=@id)";
            conexion.ConsultaDB();
        }

      
    }
}
