class Voiture
{
    public string Marque;
    public string couleur;
    public int kilometrage;
    public string motorisation;
    public double prix;

    public Voiture(string marque, string couleur, int kilometrage, string motorisation, double prix)
    {
        this.Marque = marque;
        this.couleur = couleur;
        this.kilometrage = kilometrage;
        this.motorisation = motorisation;
        this.prix = prix;
    }
}