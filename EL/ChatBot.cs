using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class ChatBot
    {
        private int idChatbot { get; set; }
        private string chatbotStatus { get; set; }

        private GeneralInformation generalInformation { get; set; }

        public ChatBot() { }

        public ChatBot(int idChatbot, string chatbotStatus)
        {
            this.idChatbot = idChatbot;
            this.chatbotStatus = chatbotStatus;
        }

        public void answerQuestion(string question) { }
        public void consultInDataBase(string question) { }

        public override string ToString()
        {
            return base.ToString() + $"{idChatbot};{chatbotStatus}";
        }
    }
}
