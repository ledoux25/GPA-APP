using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetbasic.Types.Commons
{
    public class Membres
    {
        public int id_membre { get; set; }
        public  int id_utilisateur { get; set; }
        public int id_auteur { get; set; }
        public String categorie { get; set; }
        public static int INC_ID = 0;

        public Membres( int id_utilisateur, int id_auteur, string categorie)
        {
            this.id_utilisateur = id_utilisateur;
            this.id_auteur=id_auteur;
            this.categorie = categorie;
            this.id_membre = ++INC_ID;
        }
    }
}
