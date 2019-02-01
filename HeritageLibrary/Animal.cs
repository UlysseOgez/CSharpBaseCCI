using System;

namespace HeritageLibrary
{
    public class Animal
    {
        private String nom;
        private String espece;
        private String nomCommun;
        private String son;

        public string Nom { get => nom; set => nom = value; }
        public string Espece { get => espece; set => espece = value; }
        public string NomCommun { get => nomCommun; set => nomCommun = value; }
        public string Infos { get => Nom + " " + Espece + " " + NomCommun; }
        public string Son { get => son; set => son = value; }

        public Animal(string nom)
        {
            Nom = nom;
        }

        public Animal(string nom, string espece, string nomCommun)
        {
            Nom = nom;
            Espece = espece;
            NomCommun = nomCommun;
        }

        public void Crie()
        {
            Console.WriteLine(Son);
        }
    }
}
