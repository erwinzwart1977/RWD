using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace App.ViewModel
{
    internal class VMUser
    {
        AppContext _context;

        public VMUser (AppContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public void DeleteUser(User user)
        {
            _context.Remove(user);
            _context.SaveChanges();
        }

    }
}
