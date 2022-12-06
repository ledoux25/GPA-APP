using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBApp.entity
{
    public class planificationEntity
    {
        public int id_planification { get; set; }
        public TimeSpan duree { get; set; }
        public int id_tache { get; set; }
        public int id_membre { get; set; }
        public tacheEntity tacheEntity { get; set; }
        public membreEntity membreEntity{ get; set; }

        public static int occcurence;
        public tacheEntity tacheEntitytache { get; set; }

        public planificationEntity(int id_planification, TimeSpan duree, int id_tache, int id_membre) 
        {
            this.id_planification = id_planification;
            this.duree = duree;
            this.id_tache = id_tache;
            this.id_membre = id_membre;
        }

        public planificationEntity(TimeSpan duree, int id_tache, int id_membre)
        {
            this.id_planification = ++occcurence;
            this.duree = duree;
            this.id_tache = id_tache;
            this.id_membre = id_membre;
        }
    }
}
