using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBApp.entity
{
    public class utilisateurEntity
    {
        public int id_utilisateur { get; set; }
        public string nom { get; set; }

        public string prenom { get; set;}
        public string email { get; set; }
        public string mot_de_passe{ get; set; }
        public string conctact { get; set; }
        public string adresse { get; set; }
        public int id_membre { get; set; }
        public membreEntity membreEntity { get; set; }

        public static int occurence;


        public utilisateurEntity(int id_utilisateur, string nom, string prenom, string email, string mot_de_passe, string conctact, string adresse, int id_membre)
        {
            this.id_utilisateur = id_utilisateur;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.mot_de_passe = mot_de_passe;
            this.conctact = conctact;
            this.adresse = adresse;
            this.id_membre = id_membre;
        }

        public utilisateurEntity(string nom, string prenom, string email, string mot_de_passe, string conctact, string adresse, int id_membre)
        {
            this.id_utilisateur = ++occurence;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.mot_de_passe=mot_de_passe;
            this.conctact = conctact;
            this.adresse = adresse;
            this.id_membre=id_membre;
        }
    }
}
