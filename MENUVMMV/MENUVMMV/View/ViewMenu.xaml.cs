using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MENUVMMV.ViewModel;

namespace MENUVMMV.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewMenu : ContentPage
	{
		public ViewMenu ()
		{
			InitializeComponent ();
		}

        private void Buttn_Clicked(object sender, EventArgs e)
        {
            VMMenu menu = new VMMenu(EntryNombre.Text, Convert.ToDouble(EntryPrecio.Text),
                Convert.ToInt16(NumeroIngredientes.Text), Nacionalidad.Text, Convert.ToInt16(Accion.Text));
            DisplayAlert("Notificacion", menu.retornarMensaje(), "ok");
        }
    }
}