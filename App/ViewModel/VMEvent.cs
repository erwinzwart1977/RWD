using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ViewModel
{
    internal class VMEvent
    {
        private readonly AppContext _context;
        public VMEvent(AppContext context)
        {
            _context = context;
        }
    }
}
