using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBApp.entity
{
    public class projetEntity
    {
        public int id_projet { get; set; }
        public string nom_projet { get; set; }
        public string description_projet { get; set;}
        public DateTime date_projet { get; set; }
        public int id_auteur { get; set; }
        public autuerEntity autuerEntity { get; set; }

        public static int occurrecne;

        public projetEntity(int id_projet, string nom_projet, string description_projet, DateTime date_projet, int id_auteur)
        {
            this.id_projet = id_projet;
            this.nom_projet = nom_projet;
            this.description_projet = description_projet;
            this.date_projet = date_projet;
            this.id_auteur = id_auteur;
        }

        public projetEntity(string nom_projet, string description_projet, DateTime date_projet, int id_auteur)
        {
            this.id_projet = ++occurrecne;
            this.nom_projet = nom_projet;
            this.description_projet = description_projet;
            this.date_projet = date_projet;
            this.id_auteur = id_auteur;
        }
    }

}
