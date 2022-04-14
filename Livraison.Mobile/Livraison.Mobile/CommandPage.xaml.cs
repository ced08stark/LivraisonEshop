using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Livraison.Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommandPage : ContentPage
    {
        public CommandPage()
        {
            InitializeComponent();
            title.Text = MainPage.CurrentCommandModel.Reference;
            name.Text = MainPage.CurrentCommandModel.NomClient;
            phone.Text = MainPage.CurrentCommandModel.Telephone;
            reference.Text = MainPage.CurrentCommandModel.Reference;
            date.Text = MainPage.CurrentCommandModel.DateHeure;
            lieu.Text = MainPage.CurrentCommandModel.Lieu;
        }


    }
}