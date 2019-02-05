using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBaseLibrary
{
    public static class Fonctions
    {
        public static int Additionne(int x, int y)
        {
            return x + y;
        }

        public static int Multiplie(int x, int y)
        {
            return x * y;
        }

        public static double Divise(int x, int y)
        {
            if (y == 0)
            {
                throw new Exception();
            }
            return x / y;
        }
    }

    public class Animal
    {
        private string prenom;
        private string nom;
        private DateTime dateNaissance;

        public string Nom {
            get {
                return nom.ToUpper();
            }
            set {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le nom ne peut pas être vide", "Nom");
                }
                if (value.Length > 128)
                {
                    throw new ArgumentException("Le nom ne peut pas depasser 128 caractères", "Nom");
                }
                int res;
                if (int.TryParse(value[0].ToString(),out res))
                {
                    throw new ArgumentException("Le nom ne peut pas commencer par un chiffre", "Nom");
                }
                nom = value;
            }
        }
        public string Prenom {
            get => prenom;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le nom ne peut pas être vide", "prenom");
                }
                if (value.Length > 128)
                {
                    throw new ArgumentException("Le nom ne peut pas depasser 128 caractères", "prenom");
                }
                int res;
                if (int.TryParse(value[0].ToString(), out res))
                {
                    throw new ArgumentException("Le nom ne peut pas commencer par un chiffre", "prenom");
                }
                prenom = value;
            }
        }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }

        public Animal()
        {
        }

        public Animal(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public Animal(string nom, string prenom, DateTime dateNaissance) : this(nom, prenom)
        {
            DateNaissance = dateNaissance;
        }
    }
}
