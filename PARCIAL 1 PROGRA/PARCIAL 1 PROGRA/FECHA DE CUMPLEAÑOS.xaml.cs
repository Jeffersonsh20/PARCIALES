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
    public partial class FECHA_DE_CUMPLEAÑOS : ContentPage
    {
        public FECHA_DE_CUMPLEAÑOS()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            BOTONRESULTADO1.Clicked += BOTONRESULTADO1_Clicked;
        }

        private void BOTONRESULTADO1_Clicked(object sender, EventArgs e)
        {
            var entero = Enter1.Text;
            var nnumero = Convert.ToInt64(entero);
            var resultante = nnumero - 365;
            var convert2 = Convert.ToString(resultante);
            var largo1 = convert2.Length;
            if(largo1!=4)
            {
                var nuevo = convert2.Substring(0, largo1 - 2);
                var nuevo1 = convert2.Substring(largo1-2);
                var convert = Convert.ToDouble(nuevo);
                var convert1 = Convert.ToDouble(nuevo1);
                var fin = convert+ "/"+convert1;
                Resultado1.Text = fin.ToString();
            }
            else
            {
                var nuevo = convert2.Substring(0, largo1 - 2);
                var nuevo1 = convert2.Substring(largo1 - 2);
                var convert = Convert.ToInt32(nuevo);
                var convert1 = Convert.ToInt32(nuevo1);
                var fin = convert + "/" + convert1;
                Resultado1.Text = fin.ToString();
            }

        }
    }
}