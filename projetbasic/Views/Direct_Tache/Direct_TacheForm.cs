using projetbasic.Controller;
using projetbasic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetbasic.Types.Commons;

namespace projetbasic.Views.Direct_Tache
{
    public partial class Direct_TacheForm : Form
    {
        public Direct_TacheForm()
        {
            InitializeComponent();
        }


        public bool IsUpdate;
        public int DirectId;

        Direct_TacheController direct_TacheController;
        public Direct_TacheForm(Main Parent)
        {
            direct_TacheController = new Direct_TacheController(Parent);
            InitializeComponent();
            IsUpdate = false;
            DirectId = 0;
        }
        public Direct_TacheForm(Main Parent, bool IsUpdate, int DirectId)
        {

            direct_TacheController = new Direct_TacheController(Parent);
            this.IsUpdate = IsUpdate;
            this.DirectId = DirectId;
            InitializeComponent();
        }
        
        private void ClearForm()
        {
            textenom.Text = "";
            textedescr.Text = "";
            texte_date.Text = "";
            texteheure.Text = "";
            textid.Text = "";
        }
        private void DefineView()
        {
            if (this.IsUpdate)
            {
                labelnom.Text = "EDIT BUILDING";
                btn_submit.Text = "Edit";
            }
            else
            {
                labelnom.Text = "NEW BUILDING";
               btn_submit.Text = "Submit";
            }
        }

        private void BuildingForm_Load(object sender, EventArgs e)
        {
            DefineView();
        }
        private void CreateDirect()
        {

            projetbasic.Types.Commons.Direct_Tache objDirect = direct_TacheController.Save(textenom.Text, textedescr.Text, DateTime.Parse(texte_date.Text),int.Parse(texteheure.Text),int.Parse(textid.Text));
            if (!objDirect.IsNull())
            {
                ClearForm();
                MessageBox.Show($"Direct_Tache ({objDirect.name_direct_tache}) created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error when creating Direct ({objDirect.name_direct_tache}), try again please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateDirect_Tache()
        {
            projetbasic.Types.Commons.Direct_Tache objDirect = new projetbasic.Types.Commons.Direct_Tache(textenom.Text,textedescr.Text,DateTime.Parse(texte_date.Text),int.Parse(texteheure.Text),int.Parse(textid.Text));

            projetbasic.Types.Commons.Direct_Tache UpdateDirect_Tache = direct_TacheController.Update(objDirect);
            if (!UpdateDirect_Tache.IsNull())
            {
                ClearForm();
                MessageBox.Show($"Building ({UpdateDirect_Tache.name_direct_tache}) Update!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error when Updating Building ({UpdateDirect_Tache.name_direct_tache}), try again please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SubmitBuildingForm_btn_Click_1(object sender, EventArgs e)
        {

            
        }

        private void Direct_TacheForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (this.IsUpdate == true)
            {
                this.UpdateDirect_Tache();
            }
            else
            {
                this.CreateDirect();
            }
        }
    }
}

