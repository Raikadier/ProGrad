using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class Internship
    {
        private int idIntership {  get; set; }
        private string intershipCompany { get; set; }
        private string intershipDescription { get; set; }
        private string intershipStatus { get; set; }
        private User User { get; set; }

        public Internship() { }

        public Internship(int idIntership, string intershipCompany, string intershipDescription, string intershipStatus, User user)
        {
            this.idIntership = idIntership;
            this.intershipCompany = intershipCompany;
            this.intershipDescription = intershipDescription;
            this.intershipStatus = intershipStatus;
            User = user;
        }

        public void updateStatus(string newState) { }

        public void assignStudent(Student student) { }

        public override string ToString()
        {
            return base.ToString() + $"{idIntership};{intershipCompany};{intershipDescription};{intershipStatus}";
        }
    }
}
