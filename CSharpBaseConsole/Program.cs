using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBase.Personne;
using CSharpBaseLibrary;
using CSharpBase.Data;

namespace CSharpBaseConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //TestException TE = new TestException();

            bool isUserInputValid = false;
            string s = null;
            int i = 0;

            while (!isUserInputValid)
            {
                try
                {
                    
                    if (s == null)
                    {
                        Console.WriteLine("Entrez une chaine de caractere");
                        s = Console.ReadLine();
                    }

                    

                    if ( i == 0)
                    {
                        Console.WriteLine("Entrez un nombre");
                        i = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Les variables saisies sont : " + s + " et " + i);
                    TestException TE = new TestException(s, i);
                    Console.WriteLine("Nouvel Objet cree avec succes");
                    //TE.TestString = Console.ReadLine();
                    isUserInputValid = true;
                }
                catch (FirstException firstException)
                {
                    Console.WriteLine("Erreur : " + firstException.Message);
                    s = null;
                }
                catch (SecondException secondException)
                {
                    Console.WriteLine("Erreur : " + secondException.Message + "Paramètre :" + secondException.ParamName);
                    i = 0;
                }

            }

            Console.ReadKey(true);

        }

        //static void Main(string[] args)
        //{

        //    ListManager lm = new ListManager();
        //    Personne PresidentObama = new Personne("Barack", "Obama");
        //    lm.AjouterPersonne(PresidentObama);
        //    lm.AjouterPersonne(new Personne("Georges W", "Bush"));
        //    lm.AjouterPersonne(new Personne("Bill", "Clinton"));
        //    lm.AjouterPersonne(new Personne("Georges", "Bush"));

        //    lm.AfficherNomsPersonnes();

        //    lm.AjouterNombre(1);
        //    lm.AjouterNombre(2);
        //    lm.AjouterNombre(3);
        //    lm.AjouterNombre(666);

        //    Console.WriteLine("Est ce que la liste contient le numéro 3");
        //    Console.WriteLine(lm.ListeNombres.Contains(3));

        //    Console.WriteLine("Et pour un objets ? Comment faire ?");
        //    Console.WriteLine(lm.ListePersonnes.Contains(new Personne("Barack", "Obama")));

        //    // Les objets meme s'ils contiennent les même informations ne sont pas egaux !
        //    // pour voir si un objet et presentil faut lui passer une reference à cet objet
        //    Console.WriteLine("Il faut lui passer la reference !");
        //    Console.WriteLine(lm.ListePersonnes.Contains(PresidentObama));

        //    //Creer une liste et lui donner des valeurs immédiatement
        //    List<int> listeChiffres = new List<int>() { 0, 1, 2, 3 };
        //    Console.WriteLine("On affiche la longueur de notre liste de chiffres");
        //    Console.WriteLine(listeChiffres.Count);

        //    //Comment trouver une element spécifique dans une liste
        //    // par exemple trouver la personne qui s'appelle Obama
        //    //lm.ListePersonnes.Find(x => x.Prenom.Contains("Obama"))

        //    string nomCompletObama = lm.ListePersonnes.Find(x => x.Prenom.Contains("Oba")).NomComplet;
        //    Console.WriteLine(nomCompletObama);

        //    //Comment trouver plusieurs elements qui correspondent à nos critères ?
        //    // on utilise la fonction FindAll

        //    IEnumerable<Personne> results = lm.ListePersonnes.FindAll(x => x.NomComplet.Contains("Georges"));

        //    Console.WriteLine("Voici toutes les personnes dont le nom complet contient Georges");
        //    foreach (var prez in results)
        //    {
        //        Console.WriteLine(prez.NomComplet);
        //    }



        //    Console.ReadKey(true);

        //}


    }

   
}
