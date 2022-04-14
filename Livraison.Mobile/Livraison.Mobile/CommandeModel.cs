using System;
using System.Collections.Generic;
using System.Text;

namespace Livraison.Mobile
{
    public class CommandeModel: LivraisonModel
    {

        public string NomClient { get; set; }
        public string Telephone { get; set; }
        public CommandeModel(string reference, string Dateheure, string lieu, string nom, string tel) 
            :base(reference, Dateheure, lieu)
        {
            NomClient = nom;
            Telephone = tel;
        }
    }
}
