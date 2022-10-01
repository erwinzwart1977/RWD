using App.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Forms
{
    public partial class UserNewForm : Form
    {
        VM _vm;

        public UserNewForm(VM vm)
        {
            _vm = vm;

            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Phone = txtPhone.Text;
            user.Diets = txtAlergies.Text;
            user.Team = txtTeam.Text;
            user.Remarks = txtRemarks.Text;

            try
            {
                user.DayOfBirth = DateTime.ParseExact(txtDoB.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                _vm.AddUser(user);
                Close();

            }
            catch
            {
                MessageBox.Show("Invalid date provided for date of birth (DD-MM-YYYY)");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
