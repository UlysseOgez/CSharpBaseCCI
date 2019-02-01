using HeritageLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal monAnimal = new Animal("Billy", "Canide", "Loup");
            Console.WriteLine(monAnimal.Infos);
            Chat monChat = new Chat("Felix");
            Console.WriteLine(monChat.Infos);
            monChat.Crie();
            Console.ReadKey(true);
        }
    }
}
