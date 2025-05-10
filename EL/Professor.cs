using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class Professor : User
    {
        private string professorDepartment { get; set; }

        public Professor() { }

        public Professor(string professorDepartment)
        {
            this.professorDepartment = professorDepartment;
        }

        public void markingAdvance(Project project) { }
        public void writeObservation(Project project) { }

        public override string ToString()
        {
            return base.ToString() + $"{professorDepartment}";
        }
    }
}
