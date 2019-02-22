using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace XF.Procesando
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Procesando : PopupPage
    {
		public Procesando ()
		{
			InitializeComponent ();
		}
        public async Task CargandoPagina(bool activo)
        {
            var LoadingPage = new Procesando();
            if (activo)
            {
                await Navigation.PushPopupAsync(LoadingPage);

            }
            else
            {
                await Navigation.PopPopupAsync();
            }

        }
    }
}