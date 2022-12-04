using projetbasic.Types.Commons;
using projetbasic.Views.Direct_Tache;

namespace projetbasic
{
    public partial class Main : Form
    {
        public List<Direct_Tache> direct_Taches;
        public List<Membres> membres; 
        public Main()
        {
            InitializeComponent();
            direct_Taches = new List<Direct_Tache>();
            membres = new List<Membres>();
        }

        private void directTacheFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Direct_TacheForm direct_TacheForm = new Direct_TacheForm(this);
            direct_TacheForm.MdiParent= this;
            direct_TacheForm.Show();
        }

        private void MdiParent_Load(object sender, EventArgs e)
        {

        }

        private void directtacheListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Direct_TacheList direct_TacheForml = new Direct_TacheList(this);
            direct_TacheForml.MdiParent = this;
            direct_TacheForml.Show();

        }
    }
}