using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBaseLibrary
{
    class CSharpBaseExceptions
    {
    }

    // pour plus d'info sur les exceptions allez voir :
    // https://docs.microsoft.com/en-us/dotnet/api/system.exception?view=netframework-4.7.2
    // 

    // Une exception c'est une classe comme commes autres
    // il faut simplemùent qu'elle hérite d'un type d'exception existant


    // notre premiere erreur va dériver du type exception de base
    public class FirstException : Exception
    {
        public FirstException()
        {
        }

        public FirstException(String message): base(message)
        {
        }

    }

    public class SecondException : ArgumentException
    {

        public SecondException(string message)
           : base(message)
        {
        }

        public SecondException(string message, string paramName)
           : base(message, paramName)
        {
        }
    }

    public class TestException
    {
        private string testString;
        private int testInt;
        private DateTime testDateTime;

        public string TestString {
            get => testString;
            set {
                // if (value.toLower().Contains("z"))
                if (value.Contains("z") || value.Contains("Z"))
                {
                    // On renvoie une exception mais sans message d'erreur
                    // throw new FirstException();
                    // On renvoie une exception avec message d'erreur
                    throw new FirstException("La lettre Z est interdite !!!");
                }
                testString = value;
            }
        }
        public int TestInt {
            get => testInt;
            set
            {
                if ( value > 9000)
                {
                    throw new SecondException("It's Over 9000 !!!","TestInt incorrect");
                }
                testInt = value;
            }
        }
        public DateTime TestDateTime { get => testDateTime; set => testDateTime = value; }

        public TestException()
        {
        }

        public TestException(string testString)
        {
            TestString = testString;
        }

        public TestException(string testString, int testInt) : this(testString)
        {
            TestInt = testInt;
        }

        public TestException(string testString, int testInt, DateTime testDateTime) : this(testString, testInt)
        {
            TestDateTime = testDateTime;
        }

        public static void EnterInfos(String str, String strError, int index, int indexError)
        {





            //On appelle un premier objet TestExceptio sans faute :

            Console.WriteLine("Nouvel Objet sans Z donc sans faute");
            TestException TE1 = new TestException(str);
            Console.WriteLine("-----------------------------------");

            // On va creer un autre objet avec plusieurs fautes

            Console.WriteLine("Nouvel Objet avec Z donc avec faute");
            TestException TE2 = new TestException();
            bool isCompleted = false;
            try
            {
                TE2.TestString = "BBBBBB";
                Console.WriteLine(TE2.TestString);
                TE2.TestString = "CCCCCCC";
                Console.WriteLine(TE2.TestString);
                TE2.TestInt = 80000;
                Console.WriteLine(TE2.TestInt);
                TE2.TestString = "DDDDDDD";
                Console.WriteLine(TE2.TestString);
                isCompleted = true;
            }
            catch (FirstException Fe)
            {
                Console.WriteLine("ERREUR !!!! : " + Fe.Message);
            }
            catch (SecondException Se)
            {
                Console.WriteLine("ERREUR !!!! : " + Se.Message);
            }
            finally
            {
                Console.WriteLine("IsCompleted ? : " + isCompleted);
            }
            Console.WriteLine("-----------------------------------");
        }
    }

    
}
