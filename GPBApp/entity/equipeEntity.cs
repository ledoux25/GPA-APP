using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBApp.entity
{
    public class equipeEntity
    {
        public int id_equipe { get; set; }
        public int id_membre { get; set; }
        public int id_projet { get; set; }
        public int nombre_membre { get; set; }
        public projetEntity projetEntity { get; set; }
        public membreEntity membreEntity { get; set; }

        static int occurence;

        public equipeEntity(int id_equipe, int id_membre, int id_projet, int nombre_membre)
        {
            this.id_equipe = id_equipe;
            this.id_membre = id_membre;
            this.id_projet = id_projet;
            this.nombre_membre = nombre_membre;
        }

        public equipeEntity(int id_membre, int id_projet, int nombre_membre)
        {
            this.id_equipe = ++occurence;
            this.id_membre = id_membre;
            this.id_projet = id_projet;
            this.nombre_membre = nombre_membre;
        }
    }
}
