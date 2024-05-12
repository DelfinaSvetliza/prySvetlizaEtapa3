using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace prySvetlizaEtapa3
{
    internal class clsVehiculo
    {
        public string nombre { get; set; }
        public string tipo { get; set; }
        public PictureBox imgAuto { get; set; }
        public PictureBox imgAvion { get; set; }
        public PictureBox imgBarco { get; set; }


        public clsVehiculo(string nombre, string tipo, Image imagen)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            imgAuto = imgAuto;
            imgAvion = imgAvion;
            imgBarco = imgBarco;
        }
        public void crearVehiculo()
        {
            imgAuto = new PictureBox();
            imgAvion = new PictureBox();
            imgBarco = new PictureBox();
            imgAuto.Image=  Properties.Resources.auto;
            imgAvion.Image = Properties.Resources.avion;
            imgBarco.Image = Properties.Resources.barco;
            imgAuto.SizeMode = PictureBoxSizeMode.StretchImage;
            imgAvion.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBarco.SizeMode = PictureBoxSizeMode.StretchImage;
            MessageBox.Show($"Vehículo creado: {nombre}, Tipo: {tipo}");
        }
    }
}
