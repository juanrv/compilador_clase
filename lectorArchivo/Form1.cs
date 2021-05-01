using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using lectorArchivo.Analizador;
using lectorArchivo.GestorErrores;
using lectorArchivo.Tablas;
using lectorArchivo.Transversal;

namespace lectorArchivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textRuta_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if(buscar.ShowDialog() == DialogResult.OK)
            {
                textRuta.Text = buscar.FileName;
            }

        }
        private void Resetear()
        {
            Cache.obtenerCache().Limpiar();
            ManejadorErrores.Limpiar();
            TablaMaestra.Limpiar();
        }

        private void botonCargarInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void cargarInfoConsola_Click(object sender, EventArgs e)
        {
            String[] lineasEntradas = entradaDatosConsola.Lines;
            String[] lineasSalidas = lineasEntradas;
            for(int i = 0; i < lineasEntradas.Length;i++)
            {
                lineasSalidas[i] = i + " -> " + lineasEntradas[i];
            }
            salidaDatos.Lines = lineasSalidas;
            Resetear();
            for (int i = 0; i < lineasEntradas.Count(); i++)
            {
                Linea.Crear(i + 1, lineasEntradas[i]);
            }
            try
            {
                AnalizadorLexico analizador = new AnalizadorLexico();
                ComponenteLexico componente = analizador.Analizar();
                while (!componente.ObtenerCategoria().Equals(Categoria.FIN_DE_ARCHIVO))
                {
                    MessageBox.Show(componente.ToString());

                    componente = analizador.Analizar();

                }
                if (ManejadorErrores.HayErrores())
                {
                    MessageBox.Show("El proceso de compilacion ha finalizado con errores");
                }
                else
                {
                    MessageBox.Show("El proceso de compilacion ha finalizado exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            salidaDatos.Lines = lineasSalidas.ToArray();
        }

        private void checkConsola_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();

            if (checkConsola.Checked)
            {
                entradaDatosConsola.Enabled = true;
                checkArchivo.Enabled = false;
                cargarInfoConsola.Enabled = true;
                botonLimpiar.Enabled = true;
                
            }
            else
            {
                entradaDatosConsola.Enabled = false;
                checkArchivo.Enabled = true;
                cargarInfoConsola.Enabled = false;
                botonLimpiar.Enabled = false;
            }

        }
        private void checkArchivo_CheckedChanged(object sender, EventArgs e)
        {
           

        }


        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            textRuta.Clear();
            entradaDatosConsola.Clear();
            salidaDatos.Clear();
        }

        private void tabIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkArchivo_CheckedChanged_1(object sender, EventArgs e)
        {
            limpiarCampos();

            if (checkArchivo.Checked)
            {
                textRuta.Enabled = true;
                botonBuscar.Enabled = true;
                botonCargarInfo.Enabled = true;
                botonLimpiar.Enabled = true;
                checkConsola.Enabled = false;
            }
            else
            {
                textRuta.Enabled = false;
                botonBuscar.Enabled = false;
                botonCargarInfo.Enabled = false;
                checkConsola.Enabled = true;
                botonLimpiar.Enabled = false;
            }
        }

        private void botonBuscar_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textRuta.Text = buscar.FileName;
            }
        }

        private void botonCargarInfo_Click_1(object sender, EventArgs e)
        {
            String ruta = textRuta.Text;
            StreamReader lector = new StreamReader(@"" + ruta);
            List<String> lineasEntrada = new List<string>();
            
            Resetear();
            for (int i = 0; i < lineasEntrada.Count(); i++)
            {
                Cache.obtenerCache().AgregarLinea(lineasEntrada[i]);
            }
            try
            {
                AnalizadorLexico analizador = new AnalizadorLexico();
                ComponenteLexico componente = analizador.Analizar();
                while (!componente.ObtenerCategoria().Equals(Categoria.FIN_DE_ARCHIVO))
                {
                    MessageBox.Show(componente.ToString());
                    
                    componente = analizador.Analizar();
                    switch (componente.ObtenerTipo())
                    {
                        case TipoComponente.SIMBOLO:
                            dataSimbolos.Rows.Add(componente.ToString());
                            break;
                        case TipoComponente.DUMMY:
                            dataDummys.Rows.Add(componente.ToString());
                            break;
                        case TipoComponente.LITERAL:
                            dataLiterales.Rows.Add(componente.ToString());
                            break;
                        case TipoComponente.PALABRA_RESERVADA:
                            dataPalabrasReservadas.Rows.Add(componente.ToString());
                            break;
                        default:
                            MessageBox.Show("El componente no tiene tipo");
                            break;
                    }

                }
                if (ManejadorErrores.HayErrores())
                {
                    MessageBox.Show("El proceso de compilacion ha finalizado con errores");
                }
                else
                {
                    MessageBox.Show("El proceso de compilacion ha finalizado exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void checkConsola_CheckedChanged_1(object sender, EventArgs e)
        {
            limpiarCampos();

            if (checkConsola.Checked)
            {
                entradaDatosConsola.Enabled = true;
                checkArchivo.Enabled = false;
                cargarInfoConsola.Enabled = true;
                botonLimpiar.Enabled = true;

            }
            else
            {
                entradaDatosConsola.Enabled = false;
                checkArchivo.Enabled = true;
                cargarInfoConsola.Enabled = false;
                botonLimpiar.Enabled = false;
            }
        }

        private void botonLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();

        }

        private void cargarInfoConsola_Click_1(object sender, EventArgs e)
        {
            String[] lineasEntradas = entradaDatosConsola.Lines;
            
            Resetear();
            for (int i = 0; i < lineasEntradas.Length; i++)
            {
                Cache.obtenerCache().AgregarLinea(lineasEntradas[i]);
            }
            try
            {
                AnalizadorLexico analizador = new AnalizadorLexico();
                ComponenteLexico componente = analizador.Analizar();
               
                while (!componente.ObtenerCategoria().Equals(Categoria.FIN_DE_ARCHIVO))
                {
                    MessageBox.Show(componente.ToString());

                    componente = analizador.Analizar();
                   

                }
                
                if (ManejadorErrores.HayErrores())
                {
                    MessageBox.Show("El proceso de compilacion ha finalizado con errores");
                }
                else
                {
                    MessageBox.Show("El proceso de compilacion ha finalizado exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
