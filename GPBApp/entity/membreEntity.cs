using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBApp.entity
{
    public class membreEntity
    {
        public int id_membre { get; set; }
        public string catégorie { get; set; }

        static int occurence;
        public membreEntity(int id_membre, string catégorie)
        {
            this.id_membre = id_membre;
            this.catégorie = catégorie;
        }
        public membreEntity( string catégorie)
        {
            this.id_membre = ++occurence;
            this.catégorie = catégorie;
        }
    }
}
