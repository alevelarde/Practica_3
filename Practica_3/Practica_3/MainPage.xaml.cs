using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Datos ingresados", "Hola Tus datos personales son:\n Nombre:" + nombre.Text + "\n Apellidos: " + ape_pat.Text + " " + ape_mat.Text +  "\n Direccion:  " + direccion.Text + "\n Telefono: " + telefono.Text + "\n TUS DATOS ESCOLARES SON:\n Carrera: "+carrera.Text+ "\n Semestre: " +semestre.Text+ "\n Matricula: " +matricula.Text+ "\n TUS DATOS DE CONTACTO SON: \n Correo: " +correo.Text+ "\n GitHub: " +github.Text+  "ok", "cancel");
        }
    }
}
