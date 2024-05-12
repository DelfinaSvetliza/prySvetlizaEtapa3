using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySvetlizaEtapa3
{
    public partial class Form1 : Form
    {
        private PictureBox imgAuto;
        private PictureBox imgAvion;
        private PictureBox imgBarco;
        
        
        
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            // Crear los PictureBox y configurar sus propiedades
            imgAuto = new PictureBox();
            imgAuto.Image = Properties.Resources.auto;
            imgAuto.SizeMode = PictureBoxSizeMode.StretchImage;
            imgAuto.Visible = false;

            imgAvion = new PictureBox();
            imgAvion.Image = Properties.Resources.avion;
            imgAvion.SizeMode = PictureBoxSizeMode.StretchImage;
            imgAvion.Visible = false;

            imgBarco = new PictureBox();
            imgBarco.Image = Properties.Resources.barco;
            imgBarco.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBarco.Visible = false;
        }
        public void CargarImagenes()
        {
            // Asignar la imagen del recurso a cada PictureBox
            
            
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string nombre = "";
            string tipo = "";
            Image imagen = null;
            switch (e.KeyCode)
            {
                

                case Keys.C: // Tecla "C" para el auto
                    imagen = Properties.Resources.auto;
                    nombre = "auto";
                    tipo = "terrestre";
                    break;
                case Keys.B: // Tecla "B" para el barco
                    imagen = Properties.Resources.barco;
                    nombre = "barco";
                    tipo = "maritimo";
                    break;
                case Keys.P: // Tecla "P" para el avión
                    imagen = Properties.Resources.avion;
                    nombre = "avion";
                    tipo = "aereo";
                    break;
                default:
                    // Si se presiona una tecla diferente, no se hace nada
                    break;
                
            }
            MostrarImagen(nombre, tipo, imagen);
        }

        // Método para mostrar la imagen en el formulario
        private void MostrarImagen(string nombre, string tipo, Image imagen)
        {
            // Mostrar los detalles del vehículo en un MessageBox
            MessageBox.Show($"Vehículo: {nombre}\nTipo: {tipo}");
            // Crear el PictureBox y configurar sus propiedades
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = imagen;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Visible = true;
            pictureBox.Dock = DockStyle.Fill;
            // Agregar el PictureBox al formulario si aún no está agregado
            if (!Controls.Contains(pictureBox))
            {
                Controls.Add(pictureBox);//agrega pctbox para hacerlo visibe
                pictureBox.Dock = DockStyle.Fill;//ocupe todo el formulario
            }
            // Mostrar el PictureBox y traerlo al frente
            pictureBox.Visible = true;
            pictureBox.BringToFront();
        }
       
    }
}

    
    

