using System.Collections.Generic;

public class Roman
{
    // Déclaration d'un dictionnaire pour mapper les caractères romains avec leurs valeurs numériques correspondantes
    private static Dictionary<char, int> ListOfMapping = new Dictionary<char, int>
    {
       {'I', 1},
       {'V', 5},
       {'X', 10},
       {'L', 50},
       {'C', 100},
       {'D', 500},
       {'M', 1000}
    };

    // Fonction pour convertir un nombre en chiffre romain
    public static string RomanConversion(int number)
    {
        var res = "";
        foreach (var num in ListOfMapping)
        {
            // Boucle pour parcourir chaque élément du dictionnaire
            while (number >= num.Value) // Vérifie si le nombre est supérieur ou égal à la valeur numérique actuelle du caractère romain
            {
                res += num.Key; // Ajoute le caractère romain correspondant à la chaîne de résultat
                number -= num.Value; // Soustrait la valeur numérique du caractère romain du nombre
            }
        }
        return res; // Retourne la chaîne de résultat contenant la conversion du nombre en chiffre romain
    }
}
