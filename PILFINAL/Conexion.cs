using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace PILFINAL
{

    class conexion
    {
        public static string id = "";
        public static string ap = "";
        public static string am = "";
        public static string nombre = "";
        public static string genero = "";
        public static string dia = "";
        public static string mes = "";
        public static string year = "";
        public static string correo = "";
        public static string password = "";
        private static Conexion_Instancia instancia = null;
        public static SQLiteConnection InstanciaDb()
        {
            if (instancia == null)
            {
                instancia = new Conexion_Instancia();
            }
            return instancia.con;

        }
        public static void ConsultaDB()
        {
            //a ver krnal pa que no se te olvide
            /*esta linea de acodigo de abajo sirve para crear la consultaosea creas una variable sql y le pones la consulta que quieras
            ya que haces la consulta we creas im comando sqlite y le pones el nombnre que quieras, ya que lo tengas pones entre parentesis la variable de tu consulta
            le pones una coma(,) y luego inicias la conexion a la base de datos mijo
             
             
             
             
             */
            var sql1 = "SELECT count(id) FROM registro_alumnos";
            var sql = "SELECT * FROM registro_alumnos";

            SQLiteCommand comando = new SQLiteCommand(sql, conexion.InstanciaDb());
            SQLiteCommand comando1 = new SQLiteCommand(sql1, conexion.InstanciaDb());

            //creamos el archivo pa la unidad 6 de poo carnal

            TextWriter archivo = new StreamWriter("Archivo.txt");



            /*Aqui viene donde tienes que poner atencion we
             * watcha utilizaremos un meotod llamado sqlitedatareader esa cosa lo que hace es leer todo lo que le mandemos, le vamos a dar un nombre
             * y luego el igual nuestro comando sql y ejecutamos el reader osea que lo lea todo lo que tenga el comando(osea la consulta)
             *ahora viene lo chido carnal:
             * hacemos un if en el cual si encontro algo escrito dentro del reader se ejecutara algo
             */
             //RECUERDA MODIFICARLO WEEEEY
            SQLiteDataReader registro = comando.ExecuteReader();
            
         
           
            for(int x=0;x<1000;x++)
            {
                if (registro.Read())

                {

                    /*Ok aqui se pone interesante krnal
                     * debes crear una variable por cada parametro de tu base de datos we
                     * esto sera igual al reader,en este caso registro y entre corchetes [  ] pondras el campo de la base de datos we
                     * despues para hacerlo cadena le tienes que poner el .ToString()
                     */

                    string maj = "······················································································";
                    id = registro["id"].ToString();
                    ap = registro["ap_paterno"].ToString();
                    am = registro["ap_materno"].ToString();
                    nombre = registro["nombre"].ToString();
                    genero = registro["genero"].ToString();
                    dia = registro["dia"].ToString();
                    mes = registro["mes"].ToString();
                    year = registro["year"].ToString();
                    correo = registro["correo"].ToString();
                    password = registro["password"].ToString();

                    //ya nada mas lo escribes en el archivo
                    archivo.WriteLine(maj);
                    archivo.Write("ID:");
                    archivo.WriteLine(id);
                    archivo.Write("Apellido Paterno:");
                    archivo.WriteLine(ap);

                    archivo.Write("Apellido Materno:");
                    archivo.WriteLine(am);

                    archivo.Write("Nombre(s): ");
                    archivo.WriteLine(nombre);

                    archivo.Write("Genero: ");
                    archivo.WriteLine(genero);

                    archivo.Write("Fecha de Nacimiento:");
                    archivo.Write(dia);

                    archivo.Write("/");
                    archivo.Write(mes);
                    archivo.Write("/");
                    archivo.WriteLine(year);
                    archivo.Write("Correo: ");
                    archivo.WriteLine(correo);
                    archivo.Write("Clave: ");
                    archivo.WriteLine(password);
                 
                    



                }
                else
                {

                    //si no encuentra nada saldra este mensajito
                    //ponte trucha papi no dejes todo al ultimo jaja
                    Console.Write("Error");


                }

            }
            archivo.Close();

        }//CLase conexion

        public class Conexion_Instancia
        {
            public SQLiteConnection con = null;

            public Conexion_Instancia()
            {
                con = new SQLiteConnection("Data Source=C: \\Users\\Arzate\\Documents\\Visual Studio 2015\\Projects\\PILFINAL\\PILFINAL\\bin\\Debug\\final.s3db;");
                con.Open();

            }
            public Conexion_Instancia(string h)
            {
                con = new SQLiteConnection("Data Source=C: \\Users\\Arzate\\Documents\\Visual Studio 2015\\Projects\\PILFINAL\\PILFINAL\\bin\\Debug\\final.s3db;");
                con.Open();

            }

            /* ~Conexion_Instancia()
             {
                 con.Close();

             }
             */




        }//clase conexion instancia

        public class Cerrar_Conexion
        {
            public SQLiteConnection con = null;
            public Cerrar_Conexion()
            {

                con = new SQLiteConnection("Data Source=C: \\Users\\Arzate\\Documents\\final.s3db;");
                con.Close();
            }
        }
    }
}

