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
        public MainPage()
        {
            InitializeComponent();
        }

        public List<LivraisonModel> listLivraison = new List<LivraisonModel>()
        {
            new LivraisonModel("LV01", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("LV02", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("LV03", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("LV04", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("LV05", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("LV06", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("LV07", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("LV08", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("LV09", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("LV010", DateTime.Now.ToLongDateString(), "Libreville")
        };

       

        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            CurrentLivraisonModel = 
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {

        }

        private void btn6_Clicked(object sender, EventArgs e)
        {

        }

        private void btn5_Clicked(object sender, EventArgs e)
        {

        }

        private void btn4_Clicked(object sender, EventArgs e)
        {

        }

        private void btn3_Clicked(object sender, EventArgs e)
        {

        }
    }
}
