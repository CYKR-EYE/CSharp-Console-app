// TODO : Remplacer le ?? par le code approprié pour créer une liste de chaînes

using System.Collections.Generic;

// LES LISTES

IList<string> invites = new List<string> ();

// TODO : Ajouter Joe, Martin et Marie à la liste.
invites.Add("Joe");
invites.Add("Martin");
invites.Add("Marie");

// TODO : Compléter l'instruction suivante en remplaçant le ?? pour afficher la taille de la liste
Console.WriteLine(invites.Count);

// TODO : Remplacer Martin par Jean dans la liste
invites[1] = "Jean";

// TODO : Retirer Joe de la liste
invites.RemoveAt(0);



// Afficher le contenu de la liste
Console.WriteLine("Les invités sont :");
foreach (string invite in invites)
{
    Console.WriteLine(invite);
}

// LES ENSEMBLES

ISet<string> ingredients = new HashSet<string>();
ingredients.Add("sucre");
ingredients.Add("chocolat");
ingredients.Add("beurre");
ingredients.Add("vanille");

// TODO : ajouter un autre ingrédient à l'ensemble
ingredients.Add("farine");


// TODO : retirer la vanille de l'ensemble
ingredients.Remove("vanille");


// Afficher la liste des ingrédients
Console.WriteLine("Voici la liste de nos ingrédients");
foreach (string ingredient in ingredients)
{
    Console.WriteLine(ingredient);
}

// LES DICTIONNAIRES

IDictionary<string, int> mois = new Dictionary<string, int>();

// TODO : Remplacer les noms par des constantes de type chaine de caractères
const string cleJuin = "Juin";
const string cleSeptembre = "Septembre";
const string cleMars = "Mars";
mois.Add(cleJuin, 6);
mois.Add(cleSeptembre, 9);
mois.Add(cleMars, 5);

// TODO : Corriger la valeur de Mars avec (3)
mois[cleMars] = 3;


// TODO : Retirer Juin
mois.Remove(cleJuin);


// Afficher le contenu du dictionnaire
Console.WriteLine("La liste des mois est :");
foreach (KeyValuePair<string, int> clePaire in mois)
{
    Console.WriteLine(clePaire.Key.ToString() + " est le numéro du mois de " + clePaire.Value + " de l'année ");
}