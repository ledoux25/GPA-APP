using projetbasic.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetbasic.Views.Direct_Tache;

namespace projetbasic.Views.Direct_Tache
{
    public partial class Direct_TacheList : Form
    {
        Direct_TacheController direct_TacheController;
        new Main Parent;
        public Direct_TacheList()
        {
            InitializeComponent();
        }
        public Direct_TacheList(Main Parent)
        {
            direct_TacheController= new Direct_TacheController(Parent);
            this.Parent = Parent;
            InitializeComponent();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadDirect_Tache();
        }

       

        public int GetDirect_TacheIdFromRowList()
        {
            int Id = 0;
            int RowSelected = RowsCountListSelected();
            if (RowSelected == 1)
            {
                for (int i = 0; i < DataGridView.Rows.Count - 1; i++)
                {
                    int cellsCount = DataGridView.Rows[i].Cells.Count - 1;
                    if (
                            DataGridView.Rows[i].Cells[cellsCount] != null &&
                        (bool)DataGridView.Rows[i].Cells[cellsCount].Value == true
                        )
                    {
                        Id = (int)DataGridView.Rows[i].Cells[0].Value;
                    }
                }
            }
            else if (RowSelected > 1)
            {
                MessageBox.Show("You have to select only one item from the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (RowSelected < 1)
            {
                MessageBox.Show("You have to select an item from the list to process!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Id;
        }

        public int RowsCountListSelected()
        {
            int RowsSelected = 0;
            try
            {
                for (int i = 0; i < DataGridView.Rows.Count - 1; i++)
                {
                    int cellsCount = DataGridView.Rows[i].Cells.Count;
                    if ((bool)DataGridView.Rows[i].Cells[cellsCount - 1].Value == true)
                    {
                        RowsSelected++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return RowsSelected;
        }

        public void PopulateDirect_TacheListView(List<projetbasic.Types.Commons.Direct_Tache> direct_Taches)
        {
            DataGridView.Rows.Clear();
            direct_Taches.ForEach(delegate (projetbasic.Types.Commons.Direct_Tache item) {
                DataGridView.Rows.Add(item.id_direct_tache, item.name_direct_tache, item.direct_tache_description, item.datte_direct, item.heure_direct, item.id_projet);
            });
        }

        public void LoadDirect_Tache()
        {
            List<projetbasic.Types.Commons.Direct_Tache> direct_Taches = direct_TacheController.FindAll();
            PopulateDirect_TacheListView(direct_Taches);
        }

        private projetbasic.Types.Commons.Direct_Tache GetDataFormSelectedItemInRows()
        {

            int RowSelected = RowsCountListSelected();
            if (RowSelected == 1)
            {
                for (int i = 0; i < DataGridView.Rows.Count - 1; i++)
                {
                    int id_direct_Tache = (int)DataGridView.Rows[i].Cells[0].Value;
                    String name_direct_tache = (String)DataGridView.Rows[i].Cells[1].Value;
                    String direct_tache_description = (String)DataGridView.Rows[i].Cells[2].Value;
                    DateTime datte_direct  = (DateTime)DataGridView.Rows[i].Cells[3].Value;
                    int heure_direct = (int)DataGridView.Rows[i].Cells[4].Value;
                    int id_projet = (int)DataGridView.Rows[i].Cells[5].Value;

                    return new projetbasic.Types.Commons.Direct_Tache(id_direct_Tache, name_direct_tache, direct_tache_description, datte_direct, heure_direct, id_projet);
                }

            }
            else if (RowSelected > 1)
            {
                MessageBox.Show("You have to select only one item from the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (RowSelected < 1)
            {
                MessageBox.Show("You have to select an item from the list to process!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        private void update_Click(object sender, EventArgs e)
        {

            try
            {
                int Id = GetDirect_TacheIdFromRowList();
                if (Id > 0)
                {
                    //recuperation de la ligne a modifier
                    projetbasic.Types.Commons.Direct_Tache SelectedDirect_Tache = GetDataFormSelectedItemInRows();
                    //action
                    Direct_TacheForm d = new Direct_TacheForm(this.Parent, true, SelectedDirect_Tache.id_direct_tache)
                    {
                        MdiParent = this.MdiParent
                    };

                    d.textenom.Text = SelectedDirect_Tache.name_direct_tache;
                    d.textedescr.Text = SelectedDirect_Tache.direct_tache_description;
                    d.texte_date.Text = $"{SelectedDirect_Tache.datte_direct}";
                    d.texteheure.Text = $"{SelectedDirect_Tache.heure_direct}";
                    d.textid.Text = $"{SelectedDirect_Tache.id_projet}";
                    d.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delate_Click(object sender, EventArgs e)
        {

            try
            {
                int Id = GetDirect_TacheIdFromRowList();
                if (Id > 0)
                {
                    DialogResult CanDelete = MessageBox.Show("Do you really want to delete this item?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (CanDelete == DialogResult.Yes)
                    {
                        direct_TacheController.Delete(Id);
                        MessageBox.Show("Item deleted!");
                        LoadDirect_Tache();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Direct_TacheList_Load(object sender, EventArgs e)
        {
            LoadDirect_Tache();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
