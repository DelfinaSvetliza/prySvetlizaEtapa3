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
            switch (e.KeyCode)
            {
                case Keys.C: // Tecla "C" para el auto
                    MostrarImagen(imgAuto);
                    break;
                case Keys.B: // Tecla "B" para el barco
                    MostrarImagen(imgBarco);
                    break;
                case Keys.P: // Tecla "P" para el avión
                    MostrarImagen(imgAvion);
                    break;
                default:
                    // Si se presiona una tecla diferente, no se hace nada
                    break;

            }
        }

        // Método para mostrar la imagen en el formulario
        private void MostrarImagen(PictureBox pictureBox)
        {
            // Agregar el PictureBox al formulario si aún no está agregado
            if (!this.Controls.Contains(pictureBox))
            {
                this.Controls.Add(pictureBox);
                pictureBox.Dock = DockStyle.Fill;
            }

            // Mostrar el PictureBox y traerlo al frente
            pictureBox.Visible = true;
            pictureBox.BringToFront();
        }
    }
}

    
    

