using AgendaXamarinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgendaXamarinForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            BindingContext = App.Instance.Connection.Table<Contato>().ToList();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Contato;
            var page = new EditPage(item);
            Navigation.PushAsync(page);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var page = new EditPage(new Contato());
            Navigation.PushAsync(page);
        }
    }
}
