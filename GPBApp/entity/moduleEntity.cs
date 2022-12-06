using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBApp.entity
{
    public class moduleEntity
    {
        public int id_module { get; set; }
        public string nom_module { get; set; }
        public string description_module { get; set;}
        public int id_projet { get; set; }
        public projetEntity projetEntityprojet { get; set; }

        static int occurence;

        public moduleEntity(int id_module, string nom_module, string description_module, int id_projet, projetEntity projetEntityprojet)
        {
            this.id_module = id_module;
            this.nom_module = nom_module;
            this.description_module = description_module;
            this.id_projet = id_projet;
        }

        public moduleEntity(string nom_module, string description_module, int id_projet, projetEntity projetEntityprojet)
        {
            this.id_module = ++occurence;
            this.nom_module = nom_module;
            this.description_module = description_module;
            this.id_projet = id_projet;
        }

    }
    }

