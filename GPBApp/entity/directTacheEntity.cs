using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBApp.entity
{
    public class directTacheEntity
    {
        public int id_direct_tache { get; set; }
        public string nom_direct { get; set; }
        public string description_direct { get; set; }
        public DateTime date_direct { get; set; }
        public string duree_direct { get; set; }
        public int id_projet { get; set; }
        public projetEntity projetEntityprojet { get; set; }
        static int occurence;

        public directTacheEntity(){}
        public directTacheEntity(int id_direct_tache, string nom_direct, string description_direct, DateTime date_direct, string duree_direct, int id_projet)
        {
            this.id_direct_tache = id_direct_tache;
            this.nom_direct = nom_direct;
            this.description_direct = description_direct;
            this.date_direct = date_direct;
            this.duree_direct = duree_direct;
            this.id_projet = id_projet;
        }

        public directTacheEntity(string nom_direct, string description_direct, DateTime date_direct, string duree_direct, int id_projet)
        {
            this.id_direct_tache = ++occurence;
            this.nom_direct = nom_direct;
            this.description_direct = description_direct;
            this.date_direct = date_direct;
            this.duree_direct = duree_direct;
            this.id_projet = id_projet;
        }
    }
}
