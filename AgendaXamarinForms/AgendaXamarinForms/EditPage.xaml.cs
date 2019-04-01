using AgendaXamarinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaXamarinForms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditPage : ContentPage
	{
        private Contato _contato;

		public EditPage (Contato contato)
		{
            _contato = contato;
            BindingContext = _contato;
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Instance.Connection.InsertOrReplace(_contato);
            Navigation.PopAsync();
        }
    }
}