class Livre
{
    public string titre { get; set; }
    public string auteur { get; set; }
    public int nombreDePages { get; set; }
    public string editeur { get; set; }

    public Livre(string titre, string auteur, int nombreDePages, string editeur)
    {
        this.titre = titre;
        this.auteur = auteur;
        this.nombreDePages = nombreDePages;
        this.editeur = editeur;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instanciation d'un objet de type Livre
        Livre monLivre = new Livre("La programmation", "Paul Carouge", 22, "Golder");

        Console.WriteLine("Titre : " + monLivre.titre);
    }
}

