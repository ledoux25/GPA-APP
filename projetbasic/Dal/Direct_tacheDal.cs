using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetbasic.Types.Commons;

namespace projetbasic.Dal
{
    public class Direct_tacheDal
    {

        public Main parent;
        public Direct_tacheDal(Main main)
        {
            this.parent = main;
        }
        
        public List<Direct_Tache> GetDirect_Tache()
        {
            return this.parent.direct_Taches;
        }
        public void AddDirect_tache(Direct_Tache direct_Tache)
        {
            this.parent.direct_Taches.Add(direct_Tache);
        }
        public Direct_Tache FindById(int Id)
        {
            List<Direct_Tache> direct_Taches = GetDirect_Tache();
            return direct_Taches.Find(delegate (Direct_Tache item)
            {
                return item.id_direct_tache == Id;
            });
        }
        public Direct_Tache Update(Direct_Tache direct_Tache)
        {
            int Direct_TacheIndex = parent.direct_Taches.FindIndex(delegate (Direct_Tache item)
            {
                return item.id_direct_tache == direct_Tache.id_direct_tache;
            });

            if (Direct_TacheIndex >= 0)
            {
                parent.direct_Taches[Direct_TacheIndex] = direct_Tache;
                return direct_Tache;
            }
            else
            {
                throw new Exception("Objet Direct_tache non existant!");
            }
        }

        public int Delete(int Id)
        {
            int Direct_TacheIndex = parent.direct_Taches.FindIndex(delegate (Direct_Tache direct_Tache)
            {
                return direct_Tache.id_direct_tache == Id;
            });

            if (Direct_TacheIndex >= 0)
            {
                parent.direct_Taches.RemoveAt(Direct_TacheIndex);
                return Direct_TacheIndex;
            }
            else
            {
                throw new Exception("Objet Direct_tache non existant!", new KeyNotFoundException("Objet non existant dans la collection"));
            }
        }

        public List<Direct_Tache> FindAllByName(String name_direct_tache)
        {
            return parent.direct_Taches.FindAll(delegate (Direct_Tache Item)
            {
                return Item.name_direct_tache.ToLower().Contains(name_direct_tache.ToLower());
            });
        }

        public Direct_Tache FindByName(String name_direct_tache)
        {
            return parent.direct_Taches.Find(delegate (Direct_Tache Item)
            {
                return Item.name_direct_tache == name_direct_tache;
            });
        }

    }
}
