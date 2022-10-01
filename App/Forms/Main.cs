using App.Forms;
using App.ViewModel;

namespace App
{
    public partial class Main : Form
    {
        ViewModel.VM _vm = new ViewModel.VM();

        public Main()
        {
            InitializeComponent();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserNewForm unf = new UserNewForm(_vm);
            unf.ShowDialog();
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //_vm.DeleteUser("Erwin");
        }

        private void listUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<User> users = _vm.GetAllUsers();
            UsersForm ud;
                ud = new UsersForm(users, _vm);
            ud.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}