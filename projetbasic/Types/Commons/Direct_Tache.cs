using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetbasic.Types.Commons
{
    public class Direct_Tache
    {
        public int id_direct_tache { get; set; }
        public String name_direct_tache { get;set; }
        public String direct_tache_description {get;set; }
        public DateTime datte_direct { get; set; }
        public int heure_direct { get; set; }
        public int id_projet { get; set; }
        public static int INC_ID;
        public Direct_Tache(string name_direct_tache, string direct_tache_description, DateTime datte_direct, int heure_direct, int id_projet)
        {
            this.name_direct_tache = name_direct_tache;
            this.direct_tache_description = direct_tache_description;
            this.datte_direct = datte_direct;
            this.heure_direct = heure_direct;
            this.id_projet = id_projet;
            this.id_direct_tache = ++INC_ID;
            
        }

        public Direct_Tache(int id_direct_tache, string name_direct_tache, string direct_tache_description, DateTime datte_direct, int heure_direct, int id_projet)
        {
            this.id_direct_tache = id_direct_tache;
            this.name_direct_tache = name_direct_tache;
            this.direct_tache_description = direct_tache_description;
            this.datte_direct = datte_direct;
            this.heure_direct = heure_direct;
            this.id_projet = id_projet;
        }

        public bool IsNull()
        {
            return this == null;
        }
    }
}
