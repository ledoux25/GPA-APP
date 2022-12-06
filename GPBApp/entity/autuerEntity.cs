using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBApp.entity
{
    public class autuerEntity
    {
        public int id_auteur { get; set; }
        public int id_membre { get; set; }
        public membreEntity membreEntity { get; set; }
        static int occurence;

        public autuerEntity(){}
        public autuerEntity(int id_auteur, int id_member)
        {
            this.id_auteur = id_auteur;
            this.id_membre = id_member;
        }

        public autuerEntity(int id_member)
        {
            this.id_auteur = ++occurence;
            this.id_membre = id_member;
        }

    }
}
