namespace Einheit11
{
    public partial class Adressverwaltung : Form
    {
        public Adressverwaltung()
        {
            InitializeComponent();
        }

        private void Adressverwaltung_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CmdCreatePerson_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = "Larissa";
            string data = person.GetData();
            LblShow.Text = data;
        }
    }
}