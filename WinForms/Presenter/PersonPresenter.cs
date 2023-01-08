using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Views;

namespace WinForms.Presenter
{
    internal class PersonPresenter
    {
        private readonly IPerson _person;
        public PersonPresenter(IPerson person)
        {
            _person = person;
        }

        public string SayFullName()
        {
            return _person.FirstName + " " + _person.LastName;
        }
    }
}
