using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Livraison.Mobile
{
    public partial class MainPage : ContentPage
    {

        public LivraisonModel CurrentLivraisonModel { get; set; }
        public static CommandeModel CurrentCommandModel { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }

        public List<LivraisonModel> listLivraison = new List<LivraisonModel>()
        {
            new LivraisonModel("PD01", DateTime.Now.ToLongDateString(), "bafoussam"),
            new LivraisonModel("PD02", DateTime.Now.ToLongDateString(), "yaounde"),
            new LivraisonModel("PD03", DateTime.Now.ToLongDateString(), "douala"),
            new LivraisonModel("PD04", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("PD05", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("PD06", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("PD07", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("PD08", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("PD09", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("PD10", DateTime.Now.ToLongDateString(), "Libreville")
        };

        public static List<CommandeModel> listCommande = new List<CommandeModel>()
        {
            new CommandeModel("PD01", DateTime.Now.ToLongDateString(), "bafoussam", "tomas", "6599388949"),
            new CommandeModel("PD02", DateTime.Now.ToLongDateString(), "yaounde", "henris", "6599388949"),
            new CommandeModel("PD03", DateTime.Now.ToLongDateString(), "douala", "mesmer", "6599388949"),
            new CommandeModel("PD04", DateTime.Now.ToLongDateString(), "bafoussam", "alexis", "6599388949"),
            new CommandeModel("PD05", DateTime.Now.ToLongDateString(), "douala", "sanchez", "6599388949"),
            new CommandeModel("PD06", DateTime.Now.ToLongDateString(), "yaounde", "tomas", "6599388949"),
            new CommandeModel("PD07", DateTime.Now.ToLongDateString(), "bafoussam", "tomas", "6599388949"),
            new CommandeModel("PD08", DateTime.Now.ToLongDateString(), "douala", "tomas", "6599388949"),
            new CommandeModel("PD09", DateTime.Now.ToLongDateString(), "yaounde", "tomas", "6599388949"),
            new CommandeModel("PD10", DateTime.Now.ToLongDateString(), "douala", "tomas", "6599388949")
        };




        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            CurrentCommandModel = new CommandeModel("PD02", DateTime.Now.ToLongDateString(), "bafoussam", "tomas", "6599388949");
            Navigation.PushModalAsync(new CommandPage());
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            CurrentCommandModel = new CommandeModel("PD01", DateTime.Now.ToLongDateString(), "bafoussam", "tomas", "6599388949");
            Navigation.PushModalAsync(new CommandPage());
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            CurrentCommandModel = new CommandeModel("PD06", DateTime.Now.ToLongDateString(), "yaounde", "tomas", "6599388949");
            Navigation.PushModalAsync(new CommandPage());
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            CurrentCommandModel = new CommandeModel("PD05", DateTime.Now.ToLongDateString(), "douala", "sanchez", "6599388949");
            Navigation.PushModalAsync(new CommandPage());
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            CurrentCommandModel = new CommandeModel("PD04", DateTime.Now.ToLongDateString(), "bafoussam", "alexis", "6599388949");
            Navigation.PushModalAsync(new CommandPage());
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            CurrentCommandModel = new CommandeModel("PD03", DateTime.Now.ToLongDateString(), "douala", "mesmer", "6599388949");
            Navigation.PushModalAsync(new CommandPage());
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            CurrentCommandModel = new CommandeModel("PD09", DateTime.Now.ToLongDateString(), "douala", "mesmer", "6599388949");
            Navigation.PushModalAsync(new CommandPage());
        }

        private void btn8_Clicked(object sender, EventArgs e)
        {
            CurrentCommandModel = new CommandeModel("PD08", DateTime.Now.ToLongDateString(), "douala", "mesmer", "6599388949");
            Navigation.PushModalAsync(new CommandPage());
        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            CurrentCommandModel = new CommandeModel("PD07", DateTime.Now.ToLongDateString(), "douala", "mesmer", "6599388949");
            Navigation.PushModalAsync(new CommandPage());
        }
    }
}
