using System;
using System.Collections.Generic;
using System.Text;

namespace Livraison.Mobile
{
    public class LivraisonModel
    {

        public string Reference { get; set; }
     
        public string DateHeure { get; set; }
        public string Lieu { get; set; }



        public LivraisonModel(string reference, string Dateheure, string lieu)
        {
            Reference = reference;
           
            DateHeure = Dateheure;
            Lieu = lieu;
        }

    }
}
