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
    public partial class ADIVINAR_TU_FECHA_DE_CUMPLEAÑOS : ContentPage
    {
        public ADIVINAR_TU_FECHA_DE_CUMPLEAÑOS()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            Botonresul.Clicked += Botonresul_Clicked;  
        }

        private void Botonresul_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FECHA_DE_CUMPLEAÑOS());
        }
    }
}