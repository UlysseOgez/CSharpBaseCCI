using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBaseLibrary
{
    class Exemples
    {
    }

    //public static class PersonneManager
    //{
    //    public static Personne Embaucher(Personne p1)
    //    {
    //        Console.WriteLine("Bonjour {0}, merci d'avoir traversé la rue ! Vous etes embauché ! {1}",
    //            p1.NomComplet,
    //            "Merci manu !");
    //        p1.salarie = true;
    //        return p1;
    //    }
    //}

            //bool isPersonneOK = false;

            //Personne personne1 = new Personne();
            //personne1.Prenom = "Jean";
            //        personne1.Nom = "Paul 2";

            //Personne personne2 = personne1;

            //Personne personne3 = new Personne("Jean", "Kevin");

            //int numero1 = 1;
            //int numero2 = numero1;
            //numero1 = 5;

            //Leo meo = new Leo();




            //while (!isPersonneOK)
            //{
            //    try
            //    {
            //        Console.WriteLine("Entrez votre prénom");
            //        personne1.Prenom = Console.ReadLine();
            //        isPersonneOK = true;
            //    }
            //    catch (InvalidStringException e)
            //    {
            //        Console.WriteLine(e.errorMessage);
            //    }
            //}
            
            //isPersonneOK = false;

            //while (!isPersonneOK)
            //{
            //    try
            //    {
            //        Console.WriteLine("Entrez votre nom");
            //        personne1.Nom = Console.ReadLine();
            //        isPersonneOK = true;
            //    }
            //    catch (InvalidStringException e)
            //    {
            //        Console.WriteLine(e.errorMessage);
            //    }
            //}

            // Console.WriteLine(personne1.Presenter());

            //Personne p = new Personne(
            //    "Valjean",
            //    "Jean",
            //    new DateTime(1900,2,5));
            //Console.Write(p.NomComplet + " a " + p.Age + "ans");
            //Console.ReadKey(true);
            //Console.WriteLine("DEBUT - Creation de la base");
            //DataAccess.InitializeDatabase();
            //Console.WriteLine("FIN - Creation de la base");

            //Console.WriteLine("DEBUT - Lecture de la base");
            //List<string> datas = DataAccess.GetData();
            //Console.WriteLine("Fin - Lecture de la base");

            //if (datas.Count < 5)
            //{
            //    Console.WriteLine("La base est vide");
            //    Console.WriteLine("Ajout de donnee");
            //    DataAccess.AddData("test4");
            //    DataAccess.AddData("test5");
            //    DataAccess.AddData("test6");

            //} else
            //{
            //    Console.WriteLine("La base a " + datas.Count + " lignes");

            //    datas.ForEach(delegate (String line)
            //    {
            //        Console.WriteLine(line);
            //    });
            //}
}
