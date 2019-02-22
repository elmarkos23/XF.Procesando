using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.Procesando
{
    public partial class MainPage : ContentPage
    {
        Procesando objProcesando = new Procesando();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await objProcesando.CargandoPagina(true);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                await objProcesando.CargandoPagina(false);
            }
        }
    }
}
