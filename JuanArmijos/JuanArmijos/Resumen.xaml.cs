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
    public partial class Resumen : ContentPage
    {
        public Resumen(string user, double total,string nombre)
        {
            InitializeComponent();
            lblUser.Text =  user;
            lblNombre.Text = nombre;
            lblTotal.Text = total.ToString();
        }
    }
}