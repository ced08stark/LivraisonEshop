using System;
using System.Collections.Generic;
using System.Text;

namespace Livraison.Mobile
{
    public class LivraisonViewModel
    {


        public LivraisonViewModel()
        {

        }

        List<LivraisonModel> list = new List<LivraisonModel>()
        {
            new LivraisonModel("LV01", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("LV01", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("LV01", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("LV01", DateTime.Now.ToLongDateString(), "Libreville"),
            new LivraisonModel("LV01", DateTime.Now.ToLongDateString(), "Libreville")
        };

       
    }
}
