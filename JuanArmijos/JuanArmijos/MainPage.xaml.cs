using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JuanArmijos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text.Equals("estudiante2020") && txtPass.Text.Equals("uisrael2020"))
                {
                    string user = txtUser.Text;
                    await Navigation.PushModalAsync(new Registrar(user));
                }
                else
                {
                    DisplayAlert("Error", "Usuario o contraseña incorrectos", "Reintentar");
                }

            }
            catch (Exception ex)
            {

                DisplayAlert("Error", ex.ToString(), "Cerrar");
            }

        }
    }
}
