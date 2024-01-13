using System;

namespace matrix
{
    public class matrix
    {
        public static int[,] CreerMatrice (int NombreDeLignes, int NombreDeColonnes)
        {
            int [,] Matrice = new int[NombreDeLignes, NombreDeColonnes];
            for (int Ligne = 0; Ligne < NombreDeLignes; Ligne++)
            {
                int NumeroLigne = Ligne + 1;
                Console.Write("\nLigne " + NumeroLigne);
                for (int Colonne = 0; Colonne < NombreDeColonnes; Colonne++)
                {
                    int NumeroColonne = Colonne + 1;
                    Console.Write("\t\tEntrez la valeur de la colonne " + NumeroColonne + ": ");
                    int Valeur = Convert.ToInt32(Console.ReadLine());
                    Matrice[Ligne, Colonne] = Valeur;
                }
            }            
            return Matrice;
        }

        public static void Main (string[] args)
        {
            Console.Write("Entrez le nombre de lignes: ");
            int NombreDeLignes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez le nombre de colonnes: ");
            int NombreDeColonnes = Convert.ToInt32(Console.ReadLine());
            int [,] LaMatrice = CreerMatrice(NombreDeLignes, NombreDeColonnes);
            foreach (int i in LaMatrice)
            {
                Console.WriteLine(i);
            }
        }
    }
}
