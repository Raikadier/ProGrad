using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class AccessManager
    {
        private int idAccess { get; set; }
        private string accessRole { get; set; }
        private string accessStatus { get; set; }
        private User accessUser { get; set; }

        public AccessManager() { }

        public AccessManager(int idAccess, string accessRole, string accessStatus, User accessUser)
        {
            this.idAccess = idAccess;
            this.accessRole = accessRole;
            this.accessStatus = accessStatus;
            this.accessUser = accessUser;
        }

        public void updateStatus(string newStatus)
        {

        }

        public void assignStudent(Student student) 
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + $"{idAccess};{accessRole};{accessStatus};{accessUser}";
        }
    }
}
