using projetbasic.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetbasic.Types.Commons;


namespace projetbasic.Services
{
    public class Direct_TacheService
    {
        public Direct_tacheDal direct_TacheDal;

        public Direct_TacheService(Main parent)
        {
            this.direct_TacheDal = new Direct_tacheDal(parent);
        }




        public void Save(Direct_Tache direct_Tache)
        {
            // verifier si le building existe
            if (!Exists(direct_Tache.name_direct_tache))
            {
                // creer le building
                this.direct_TacheDal.AddDirect_tache(direct_Tache);
            }
            else
            {
                throw new Exception("Le direct_tache que vous voulez creer existe deja!");
            }
        }

        public bool Exists(String Direct_tacheName)
        {
            List<Direct_Tache> direct_Taches = direct_TacheDal.GetDirect_Tache();
            List<Direct_Tache> FoundDirect_Tache = direct_Taches.FindAll(delegate (Direct_Tache item)
            {
                return item.name_direct_tache == Direct_tacheName;
            });
            return FoundDirect_Tache.Count > 0 ? true : false;
        }

        public Direct_Tache Update(Direct_Tache direct_Tache)
        {
            // Verifier (par son ID) que le direct tache quon veut modifier existe
            Direct_Tache ExistDirect_Tache = this.direct_TacheDal.FindById(direct_Tache.id_direct_tache);
            if (!ExistDirect_Tache.IsNull())
            {
                ExistDirect_Tache.name_direct_tache = direct_Tache.name_direct_tache;
                ExistDirect_Tache.direct_tache_description = direct_Tache.direct_tache_description;
                ExistDirect_Tache.datte_direct = direct_Tache.datte_direct;
                ExistDirect_Tache.heure_direct = direct_Tache.heure_direct;
                ExistDirect_Tache.id_projet = direct_Tache.id_projet;
                // Sauvegarder
                return direct_TacheDal.Update(ExistDirect_Tache);
            }
            else
            {
                throw new Exception("direct_tache non existant!");
            }
        }

        public int Delete(int Id)
        {
            Direct_Tache DirectToDelete = direct_TacheDal.FindById(Id);
            if (!DirectToDelete.IsNull())
            {
                // supprimer le building
                return direct_TacheDal.Delete(Id);
            }
            else
            {
                throw new Exception("Le direct_tache que vous voulez supprimer n'existe pas!");
            }
        }

        public List<Direct_Tache> Filter(String Direct_tacheName)
        {
            return direct_TacheDal.FindAllByName(Direct_tacheName);
        }

        public Direct_Tache FindByName(String Direct_tacheName)
        {
            return direct_TacheDal.FindByName(Direct_tacheName);
        }

        public List<Direct_Tache> FindAll()
        {
            return direct_TacheDal.GetDirect_Tache();
        }
    }
}
