using System;
using CSharpBaseLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Additionne_2_Et_3_Doit_Faire_5()
        {
            int resutatAddition = Fonctions.Additionne(2, 3);
            Assert.AreEqual(5, resutatAddition);      
        }

        [TestMethod]
        public void Multiplie_2_Et_3_Doit_Faire_6()
        {
            int resutatMultiplication = Fonctions.Multiplie(2, 3);
            Assert.AreEqual(6, resutatMultiplication);
        }

        [TestMethod]
        public void Divise_6_par_2_Doit_Faire_3()
        {
            double resutatDivision = Fonctions.Divise(6, 2);
            Assert.AreEqual(3, resutatDivision);
        }

        [TestMethod]
        public void Divise_par_0_Doit_Lever_Exception()
        {
            Assert.ThrowsException<Exception>(
                () => Fonctions.Divise(6, 0)
                );
        }

        [TestMethod]
        public void L_Animal_Doit_S_Appeler_Felix()
        {
            var chat = new Animal();
            chat.Prenom = "Felix";

            Assert.AreEqual("Felix", chat.Prenom);
        }

        [TestMethod]
        public void L_Animal_Doit_S_Appeler_Felix_LECHAT()
        {
            var chat = new Animal();
            chat.Nom = "lechat";

            Assert.AreEqual("LECHAT", chat.Nom);
        }

        [TestMethod]
        public void Le_Nom_Ne_Doit_Pas_Etre_Vide()
        {
            var chat = new Animal();
            Assert.ThrowsException<ArgumentException>(
                () => chat.Nom = ""
                );
        }


        [TestMethod]
        public void Le_Nom_Ne_Doit_Pas_Etre_Superieur_A_128_Caracateres()
        {
            var chat = new Animal();
            Assert.ThrowsException<ArgumentException>(
                () => chat.Prenom = "This works in at least NUnit and xUnit; if you're using a different testing framework you should look for similar functionality. If it doesn't exist, I'd recommend implementing it yourself - it's easy enough to do, and much cleaner than the alternatives (a try/catch block, or a method-wide ExpectedException attribute). Alternatively, change unit test framework if you can..."
                );
        }

        [TestMethod]
        public void Le_Nom_Ne_Doit_Pas_Commencer_Par_Un_Chiffre()
        {
            var chat = new Animal();
            Assert.ThrowsException<ArgumentException>(
                () => chat.Prenom= "1Test"
                );
        }

    }
}
