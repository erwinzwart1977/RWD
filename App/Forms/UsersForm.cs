using App.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class UsersForm : Form
    {
        private VM _vm;

        public UsersForm(IEnumerable<User> users, VM vm)
        {
            InitializeComponent();

            this.userBindingSource.ResetBindings(true);
            this.userBindingSource.DataSource = users;
            this.dgUsers.Update();
            _vm = vm;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgUsers.SelectedRows.Count > 0)
            {
                try
                {
                    User user = dgUsers.SelectedRows[0].DataBoundItem as User;
                    dgUsers.Rows.RemoveAt(dgUsers.SelectedRows.Count - 1);  
                    _vm.DeleteUser(user);
                    
                }
                catch (Exception ex)    
                {
                    MessageBox.Show("oeps something went wrong" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select row to delete user");
            }

            
        }
    }
}
