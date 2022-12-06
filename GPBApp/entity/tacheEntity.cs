using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBApp.entity
{
    public class tacheEntity
    {
        public int id_tache { get; set; }
        public string nom_tache { get; set; }
        public string description_tache { get; set;}
        public DateTime date_tache { get; set; }
        public TimeSpan duree { get; set; }
        public int id_module { get; set; }
        public moduleEntity moduleEntity { get; set; }

        public static int occurence;

        public tacheEntity(int id_tache, string nom_tache, string description_tache, DateTime date_tache, TimeSpan duree, int id_module)
        {
            this.id_tache = id_tache;
            this.nom_tache = nom_tache;
            this.description_tache = description_tache;
            this.date_tache = date_tache;
            this.duree = duree;
            this.id_module = id_module;
        }

        public tacheEntity(string nom_tache, string description_tache, DateTime date_tache, TimeSpan duree, int id_module)
        {
            this.id_tache = ++occurence;
            this.nom_tache = nom_tache;
            this.description_tache = description_tache;
            this.date_tache = date_tache;
            this.duree = duree;
            this.id_module = id_module;
        }

    }

   
}
