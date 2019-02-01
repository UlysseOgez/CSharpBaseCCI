using System;
using System.Collections.Generic;
using System.Text;
using CSharpBase.Data;

namespace CSharpBase.Personne
{
    public class Personne
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private string nationalite;
        public bool salarie;
        private string pseudo;
        protected bool lunette;
        private List<int> maList = new List<int>();


        public Personne()
        {
        }

        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
            lunette = true;
        }

        public Personne(string nom, string prenom, DateTime dateNaissance) : this(nom, prenom)
        {
            DateNaissance = dateNaissance;
        }

        public string Nom
        {
            get => nom;
            set {
                try
                {
                    DataAccess.IsCorrectString(value);
                    nom = value;
                }
                catch (InvalidStringException)
                {
                    throw new InvalidStringException("Le nom n'est pas valable");
                }
            }
        }
        public string Prenom
        {
            get => prenom;
            set
            {
                try
                {
                    DataAccess.IsCorrectString(value);
                    prenom = value;
                }
                catch (InvalidStringException)
                {
                    throw new InvalidStringException("Le prenom n'est pas valable");
                }
            }
        }
        public string NomComplet { get => Prenom + " " + Nom; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public int Age {
            get {

                int age = DateTime.Now.Year - DateNaissance.Year;
                DateTime dateAnniversaire =
                    new DateTime(
                        DateTime.Now.Year,
                        DateNaissance.Month,
                        DateNaissance.Day);

                if (dateAnniversaire >= DateTime.Now)
                {
                    age--;
                }

                return age;
            }
        }
        public string Nationalite {
            get => nationalite;
            set => nationalite = value;
        }
        public string Pseudo { get => pseudo; set => pseudo = value; }
        public List<int> MaList { get => maList; set => maList = value; }

        public static String Presenter()
        {
            String presentation = "Bonjour je suis une personne";

            return presentation;
        }

        //Ceci n'est pas une méthode ! C'est une fonction
        public static string AfficherPseudo(Personne p)
        {
            return "Coucou sur Fortnite mon peseudo c'est" + p.Pseudo;
        }

        public static Personne SauvegarderEnBDD(Personne p)
        {
            return p;
        }

        // le mot clé protected permet d'utiliser cette fonction dans les classe dérivées
        protected virtual void Dab()
        {
            //CODE
        }

        //Les listes !
        public void UseList()
        {
            //Ajouter une element à une liste
            MaList.Add(3);

            //Ajouter une list existante à une autre liste
            List<int> liste2 = new List<int>();
            liste2.Add(4);
            liste2.Add(2);
            liste2.Add(5);

            MaList.AddRange(liste2);

        }

    }

    public class Leo : Personne
    {

        public Leo()
        {
            Nom = "test";
            salarie = true;
            // On a declaré le champ lunette dans la classe Personne et on l'a defini
            //comme un champ protected
            //lunette est accessible depuis Leo car Leo herite de Personne
            lunette = true;
            Personne p = new Personne();
            //Mais on ne peut pas acceder à lunette dans un objet de type personne
            //p.lunette = true;
        }

        // le mot clé override est permis ici car dans la classe mere
        //la methode est virtual
        sealed protected override void Dab()
        {
            //CODE
        }
    }

    public class Lea : Leo
    {
        public void test()
        {
            Leo leo = new Leo();
            Lea lea = new Lea();

            //leo.Dab();
            lea.Dab();
        }
    }

}
