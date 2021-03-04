using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PARCIAL_1_PROGRA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Adivinar_tu_numero : ContentPage
    {
        public Adivinar_tu_numero()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            BotonFinal.Clicked += BotonFinal_Clicked;
        }

        private void BotonFinal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resultado_de_adivinar_tu_numero());
        }
    }
}