using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class History
    {
        private int idHistory {  get; set; }
        private string descriptionHistory { get; set; }
        private DateTime registrationDate { get; set; }
        private Project project { get; set; }
        private Internship internship { get; set; }

        public History() { }

        public History(int idHistory, string descriptionHistory, DateTime registrationDate, Project project, Internship internship)
        {
            this.idHistory = idHistory;
            this.descriptionHistory = descriptionHistory;
            this.registrationDate = registrationDate;
            this.project = project;
            this.internship = internship;
        }

        public string consultHistory(User user) { return descriptionHistory; }
    }
}
