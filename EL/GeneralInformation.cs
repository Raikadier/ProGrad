using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class GeneralInformation
    {
        private int idInformation {  get; set; }
        private string tittle {  get; set; }
        private string content { get; set; }

        public GeneralInformation() { }

        public GeneralInformation(int idInformation, string tittle, string content)
        {
            this.idInformation = idInformation;
            this.tittle = tittle;
            this.content = content;
        }

        public void updateContent(string content) { }

        public string contultContent() {  return content; }

        public override string ToString()
        {
            return base.ToString() + $"{idInformation};{tittle};{content}";
        }

    }
}
