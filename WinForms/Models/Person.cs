using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Views;

namespace WinForms.Models
{
    internal class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
