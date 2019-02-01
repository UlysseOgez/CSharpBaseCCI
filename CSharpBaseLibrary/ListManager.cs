using System;
using System.Collections.Generic;
using System.Text;
using CSharpBase.Personne;

namespace CSharpBaseLibrary
{
    public class ListManager
    {
        private List<int> listeNombres;
        private List<Personne> listePersonnes;

        public ListManager()
        {
            listeNombres = new List<int>();
            listePersonnes = new List<Personne>();
        }

        public List<int> ListeNombres { get => listeNombres; set => listeNombres = value; }
        public List<Personne> ListePersonnes { get => listePersonnes; set => listePersonnes = value; }

        // Ajouter un element à une liste
        public void AjouterNombre(int nombre)
        {
            ListeNombres.Add(nombre);


            // Si ou voulait ajouter plusieurs elements 
            // ( une liste preéxistante ) à une liste
            // il faudrait utiliser la fonction AddRange

            // listeNombres.AddRange()
        }

        public void AjouterPersonne(Personne p)
        {
            ListePersonnes.Add(p);
        }

        // Pour parcourir une liste et afficher tous ses éléments
        public void AfficherNomsPersonnes()
        {
            foreach (Personne p in ListePersonnes)
            {
                Console.WriteLine(p.NomComplet);
            }
        }

    }
}
