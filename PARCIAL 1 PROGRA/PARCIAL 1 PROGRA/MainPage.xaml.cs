using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PARCIAL_1_PROGRA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            inicializar();
        }

        private void inicializar()
        {
            BOTON1.Clicked += BOTON1_Clicked;
            BOTON2.Clicked += BOTON2_Clicked;
        }

        private void BOTON2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ADIVINAR_TU_FECHA_DE_CUMPLEAÑOS());
        }

        private void BOTON1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Adivinar_tu_numero());
        }
    }
}
