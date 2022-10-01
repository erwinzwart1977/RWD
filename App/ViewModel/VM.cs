using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ViewModel
{
    public class VM
    {
        private AppContext _context = new AppContext();

        //User ViewModel
        private readonly VMUser vmUser;
        private readonly VMEvent vmEvent;
        
        public VM()
        {
            vmUser = new VMUser(_context);
            vmEvent = new VMEvent(_context);
        }
        #region USER
        public void AddUser(User user)          { vmUser.AddUser(user); }
        public IEnumerable<User> GetAllUsers()  { return vmUser.GetAllUsers(); }
        public void DeleteUser(User user)       { vmUser.DeleteUser(user); }
        #endregion
    }

}
