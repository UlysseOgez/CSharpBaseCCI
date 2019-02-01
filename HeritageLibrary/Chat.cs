using System;
using System.Collections.Generic;
using System.Text;

namespace HeritageLibrary
{
    public class Chat : Animal
    {
        public Chat(string nom) : base(nom)
        {
            Espece = "Felin";
            NomCommun = "Chat";
            Son = "Miaou";
        }

        public Chat(string nom, string espece, string nomCommun) : base(nom, "Felin", "Chat")
        {
        }
    }
}
