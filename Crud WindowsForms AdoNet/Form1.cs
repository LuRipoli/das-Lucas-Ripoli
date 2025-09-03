using System.Windows.Forms;

namespace Crud_WindowsForms_AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            PeopleDB oPeopleDB = new PeopleDB();
            dataGridView1.DataSource = oPeopleDB.Get();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmNuevo frm = new FrmNuevo();
            frm.ShowDialog();
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                FrmNuevo frmEdit = new FrmNuevo(Id);
                frmEdit.ShowDialog();
                Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            try
            {
                if (Id != null)
                {
                    PeopleDB oPeopleDB = new PeopleDB();
                    oPeopleDB.Delete((int)Id);
                    Refresh();
                }
            }
            catch
            {

            }
        }

        #region HELPER
        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
       
    }
}
