using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JuanArmijos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrar : ContentPage
    {
        public Registrar(string user)
        {
            InitializeComponent(); 
            lblUser.Text = "Bienvenido "+user;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double valorInicial = double.Parse(txtMonto.Text); 
            double final = (valorInicial / 3) * 1.05;
            lblCuota.Text = final.ToString();
            
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            
            if (lblCuota.Text.Equals(""))
            {
                DisplayAlert("Error", "Por favor primero calcule el monto inical a pagar", "Reintentar");
            }
            else
            {
                string nombre = txtNombre.Text;
                string user = lblUser.Text;
                double valor = double.Parse(lblCuota.Text);
                double total = valor * 3;
                await Navigation.PushModalAsync(new Resumen(user,total,nombre));
            }
            
        }
    }
}