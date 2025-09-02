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
    }
}
