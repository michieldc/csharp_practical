using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachTheTeacher
{
    public class Teacher
    {

        public void SetFirstname(string firstname)
        {
            this.firstname = firstname;
        }

        public void SetLastname(string lastname)
        {
            this.lastname = lastname;
        }

        public string Fullname()
        {
            return $"{firstname} {lastname}";
        }

        public string Email()
        {
            string email =  $"{firstname}.{lastname}@vives.be";
            return email.ToLower().Replace(" ", string.Empty);
        }

        public override string ToString()
        {
            return $"{firstname} {lastname} <{Email()}>";
        }

        private string firstname = string.Empty;
        private string lastname = string.Empty;
    }
}
