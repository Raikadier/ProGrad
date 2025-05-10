using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class Advisor : User
    {
        private string major { get; set; }
        private Project project { get; set; }
        private Internship internship { get; set; }

        public Advisor() { }

        public Advisor(string major, Project project, Internship internship)
        {
            this.major = major;
            this.project = project;
            this.internship = internship;
        }

        public void evaluateProject(Project project, float score) { }

        public void evaluateIntership(Internship internship, float score) { }

        public void assingRetroalimentation(Project project, string comment) { }

        public override string ToString()
        {
            return base.ToString() + $"{major};{project};{internship}";
        }
    }
}
