using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class Project
    {
        private int idProject {  get; set; }
        private string projectTittle { get; set; }
        private string projectDescription { get; set; }
        private string projectStatus { get; set; }
        private DateTime startDate { get; set; }
        private DateTime endDate { get; set; }
        private string projectVersion { get; set; }
        private string projectFile { get; set; }

        public Project() { }

        public Project(int idProject, string projectTittle, string projectDescription, string projectStatus, DateTime startDate, DateTime endDate, string projectVersion, string projectFile)
        {
            this.idProject = idProject;
            this.projectTittle = projectTittle;
            this.projectDescription = projectDescription;
            this.projectStatus = projectStatus;
            this.startDate = startDate;
            this.endDate = endDate;
            this.projectVersion = projectVersion;
            this.projectFile = projectFile;
        }

        public void updateStatus(string newState) { }
        public void assignStudent(Student student) { }

        public override string ToString()
        {
            return base.ToString() + $"{idProject};{projectDescription};{projectFile};{projectStatus};{projectTittle};{projectVersion}";
        }
    }
}
