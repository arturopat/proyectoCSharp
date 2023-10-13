using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _2_Formulario
{
    public partial class Form1 : Form
    {

        int con = 0;
        String[] data;
        String line;
        string lectura;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                bool servidoresSeleccionado = cb1.Checked;
                bool redesSeleccionado = cb2.Checked;
                string genero = rbt1.Checked ? "Hombre" : rbt2.Checked ? "Mujer" : "";


                using (StreamWriter sw = new StreamWriter("C:\\Users\\artur\\source\\repos\\introduccion C#\\2-Formulario\\2-Formulario\\database.txt", true))
                {


                    if (servidoresSeleccionado && redesSeleccionado) 
                    {
                        sw.WriteLine(txt1.Text + "," + txt2.Text + "," + cb1.Text + "," + cb2.Text + "," + genero + "," + comBox1.Text + "," + dtp1.Text );
                    }
                    else
                    {
                        sw.WriteLine($"{txt1.Text}, {txt2.Text}, {(servidoresSeleccionado ? cb1.Text + "" : "")}{(redesSeleccionado ? cb2.Text + "" : "")}, {genero}, {comBox1.Text}, {dtp1.Text}");

                    }

                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Exception: " + error.Message);
            }
            finally
            {
                MessageBox.Show("Usuario registrado");
            }

        }


    

        private void rbt1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbt2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contador_TextChanged(object sender, EventArgs e)
        {
        }
        private StreamReader sr;
        

        private void despues_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (sr == null)
                {
                    sr = new StreamReader("C:\\Users\\artur\\source\\repos\\introduccion C#\\2-Formulario\\2-Formulario\\database.txt");
                }

                line = sr.ReadLine();


                if (line != null)
                {
                    MessageBox.Show(line);
                    con++;
                    contador.Text = con.ToString();

                    // mostrar datos en el textbox



                    data = line.Split(',');


                    
                    txt1.Text = data[0];
                    txt2.Text = data[1];

                    if (line.Contains("Usuario modificado"))
                    {
                        MessageBox.Show("¡Integridad del archivo comprometida! Se ha detectado un usuario modificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                    // checkbox seleccion
                    if (data[2] == "Servidores" && data[3] == "Redes" )
                    {

                        // checkbox
                        cb1.Checked = true;
                        cb2.Checked = true;

                        // radio button
                        if (data[4] == "Hombre")
                        {
                            rbt1.Checked = true;

                        }
                        else
                        {
                            rbt2.Checked = true;
                        }

                        // lista desplegable

                        comBox1.Text = data[5];

                        // fecha

                        dtp1.Text = data[6] + ", " + data[7];
                    }
                    else if (data[2] == " Servidores")
                    {
                        cb1.Checked = true;
                        cb2.Checked = false;

                        if (data[3] == " Hombre")
                        {
                            rbt1.Checked = true;

                            // lista desplegable

                            if (data[4] == " Rodolfo")
                            {
                                comBox1.Text = "Rodolfo";
                            }
                            else
                            {
                                comBox1.Text = "Astolfo";
                            }
                            // no funciona esta porqueria 
                            

                            // fecha
                            dtp1.Text = data[5] + ", " + data[6];

                        }
                        else
                        {
                            rbt2.Checked = true;

                        }

                    }
                    else
                    {
                        cb2.Checked = true;
                        cb1.Checked = false;

                        if (data[3] == " Hombre")
                        {
                            rbt1.Checked = true;

                        }
                        else
                        {
                            rbt2.Checked = true;
                        }
                    }

                    // radio button comprobar 


                    
                }
                else
                {
                    // cuando se llega al final del archivo terminas el proceso de streamreader
                    sr.Close();
                    sr = null;
                    contador.Text = "Fin del archivo";
                    con = 0;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Exception: " + error.Message);
            }
            finally
            {
                Console.WriteLine("Lectura de archivo.");


                

            }


        }

        // boton de retroceso
        private void antes_Click(object sender, EventArgs e)
        {
            // con--;
            // contador.Text = con.ToString();
            /*

            if (sr == null)
            {
                sr = new StreamReader("C:\\Users\\artur\\source\\repos\\introduccion C#\\2-Formulario\\2-Formulario\\database.txt");
            }
            
            line = sr.ReadLine();
            MessageBox.Show(line);
            */

            /*
            int num = int.Parse(contador.Text);

            if(num > 1)
            {
                num--;
                contador.Text = num.ToString();

                try
                {
                    StreamReader sr = new StreamReader("C:\\Users\\artur\\source\\repos\\introduccion C#\\2-Formulario\\2-Formulario\\database.txt");
                    line = sr.ReadLine();
                    lectura = line;

                    int c = 1;

                    
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        c++;
                        if(c == num)
                        {
                            lectura = line;
                            break;
                        }
                    }
                    sr.Close();

                }
                catch(Exception error)
                {
                    Console.WriteLine("Exception: " + error.Message);
                }
                finally
                {
                    string[] partes = lectura.Split(',');
                    txt1.Text = partes[0];
                    txt2.Text = partes[1];
                }
            }
            */

            int num = int.Parse(contador.Text);

            if (num > 1)
            {
                num--;
                contador.Text = num.ToString();

                try
                {
                    StreamReader sr = new StreamReader("C:\\Users\\artur\\source\\repos\\introduccion C#\\2-Formulario\\2-Formulario\\database.txt");
                    line = sr.ReadLine();
                    lectura = line;

                    int c = 1;

                    while (line != null)
                    {
                        line = sr.ReadLine();
                        c++;

                        
                        if (c == num)
                        {
                            lectura = line;
                            if (line.Contains("Usuario modificado"))
                            {
                                MessageBox.Show("¡Integridad del archivo comprometida! Se ha detectado un usuario modificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        }
                    }
                    sr.Close();

                    string[] partes = lectura.Split(',');

                    txt1.Text = partes[0];
                    txt2.Text = partes[1];

                    
                }
                catch (Exception error)
                {
                    Console.WriteLine("Exception: " + error.Message);
                }
            }
        }


        // boton de limpiar
        private void button3_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            cb1.Checked = false;
            cb2.Checked = false;
            rbt1.Checked = false;
            rbt2.Checked = false;
        }

        // boton de actualizar
        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(contador.Text);

            if (num < 1)
            {
                MessageBox.Show("No hay datos para actualizar.");
                return;
            }

            string archivo = "C:\\Users\\artur\\source\\repos\\introduccion C#\\2-Formulario\\2-Formulario\\database.txt";
            string archivoTemp = "C:\\Users\\artur\\source\\repos\\introduccion C#\\2-Formulario\\2-Formulario\\database_temp.txt";
            string archivoRespaldo = "C:\\Users\\artur\\source\\repos\\introduccion C#\\2-Formulario\\2-Formulario\\respaldo_global.txt";

            bool servidoresSeleccionado = cb1.Checked;
            bool redesSeleccionado = cb2.Checked;
            string genero = rbt1.Checked ? "Hombre" : rbt2.Checked ? "Mujer" : "";

            try
            {
                string[] lineas = File.ReadAllLines(archivo);

                if (num <= lineas.Length)
                {
                    string nuevaLinea;

                    if (servidoresSeleccionado && redesSeleccionado)
                    {
                        nuevaLinea = txt1.Text + "," + txt2.Text + "," + cb1.Text + "," + cb2.Text + "," + genero + "," + comBox1.Text + "," + dtp1.Text;
                    }
                    else
                    {
                        nuevaLinea = $"{txt1.Text}, {txt2.Text}, {(servidoresSeleccionado ? cb1.Text + "" : "")}{(redesSeleccionado ? cb2.Text + "" : "")}, {genero}, {comBox1.Text}, {dtp1.Text}";
                    }

                    string nuevoHash = CalculateMD5Hash(nuevaLinea);

                    string nuevaLineaRespaldo = nuevaLinea + "," + nuevoHash + ", Usuario modificado";
                    File.AppendAllText(archivoRespaldo, nuevaLineaRespaldo + Environment.NewLine);

                    nuevaLinea = nuevaLinea + "," + nuevoHash;
                    lineas[num - 1] = nuevaLinea;

                    if (sr != null)
                    {
                        sr.Close();
                        sr = null;
                    }

                    File.WriteAllLines(archivoTemp, lineas);

                    File.Delete(archivo);

                    File.Move(archivoTemp, archivo);

                    MessageBox.Show($"Usuario modificado:\n{nuevaLinea}\nHash: {nuevoHash}\nUsuario modificado", "Actualización Exitosa");
                }
                else
                {
                    MessageBox.Show("Número de registro inválido.");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Exception: " + error.Message);
            }
        }





        // metodo para generar el hash
        private string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }

        // boton para comprobar
        private void button2_Click_1(object sender, EventArgs e)
        {
            string archivoOriginal = "C:\\Users\\artur\\source\\repos\\introduccion C#\\2-Formulario\\2-Formulario\\database.txt";
            string archivoRespaldo = "C:\\Users\\artur\\source\\repos\\introduccion C#\\2-Formulario\\2-Formulario\\respaldo_global.txt";

            try
            {
                List<string> hashesDatabase = new List<string>();
                List<string> hashesRespaldo = new List<string>();

                // Leer todos los hashes del archivo de base de datos
                using (StreamReader sr = new StreamReader(archivoOriginal))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 9)
                        {
                            string hash = parts[8];
                            hashesDatabase.Add(hash);
                        }
                    }
                }

                // revisar nuevamente esta parte
                using (StreamReader sr = new StreamReader(archivoRespaldo))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 9)
                        {
                            string hash = parts[8];
                            hashesRespaldo.Add(hash);
                        }
                    }
                }

                // esto busca los datos en camunes (lineas)
                List<string> hashesComunes = hashesDatabase.Intersect(hashesRespaldo).ToList();

                if (hashesComunes.Any())
                {
                    StringBuilder usuariosEncontrados = new StringBuilder();
                    foreach (string hash in hashesComunes)
                    {
                        // busco la liena en el archivo original
                        string usuario = BuscarUsuarioPorHash(archivoOriginal, hash);
                        usuariosEncontrados.AppendLine(usuario);

                        string usuarioRespaldo = BuscarUsuarioPorHash(archivoRespaldo, hash);
                        usuariosEncontrados.AppendLine(usuarioRespaldo);
                    }

                    MessageBox.Show($"Usuarios encontrados en ambos archivos:\n{usuariosEncontrados.ToString()}", "Usuarios Comunes");
                }
                else
                {
                    MessageBox.Show("No se encontraron usuarios comunes en ambos archivos.", "Usuarios Comunes");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Exception: " + error.Message);
            }
        }

        private string BuscarUsuarioPorHash(string archivo, string hash)
        {
            using (StreamReader sr = new StreamReader(archivo))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 9)
                    {
                        string hashLinea = parts[8];
                        if (hashLinea == hash)
                        {
                            return line;
                        }
                    }
                }
            }

            // si no encontramos el hash devolvemos una cadena vacia
            return string.Empty;
        }


    }
}
