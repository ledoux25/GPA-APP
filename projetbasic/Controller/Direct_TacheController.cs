using projetbasic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetbasic.Types.Commons;

namespace projetbasic.Controller
{
    public class Direct_TacheController
    {

        public Direct_TacheService direct_TacheService;

        public Direct_TacheController(Main parent)
        {
            this.direct_TacheService = new Direct_TacheService(parent);
        }

        public Direct_Tache Save(string name_direct_tache, string direct_tache_description, DateTime datte_direct, int heure_direct, int id_projet)
        {
            try
            {
                Direct_Tache direct_Tache = new Direct_Tache(name_direct_tache,direct_tache_description,datte_direct,heure_direct,id_projet);
                direct_TacheService.Save(direct_Tache);
                return direct_Tache;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<Direct_Tache> FindAll()
        {
            return direct_TacheService.FindAll();
        }

        public Direct_Tache FindByName(String name)
        {
            return direct_TacheService.FindByName(name);
        }

        public List<Direct_Tache> FilterByName(String name)
        {
            return direct_TacheService.Filter(name);
        }

        public int Delete(int id)
        {
            return direct_TacheService.Delete(id);
        }
        public Direct_Tache Update(Direct_Tache direct_Tache)
        {
            return direct_TacheService.Update(direct_Tache);
        }

    }
}
