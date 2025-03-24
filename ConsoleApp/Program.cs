using System;

class Contact
{
    public string Nom;
    public string Telephone;
    public string Email;
}

class Annuaire
{
    public static Contact[] contacts = new Contact[10];
    public static int nombreContacts = 0;

    /* partie Loukas */

    public static void AjouterContact()
    {
        if (nombreContacts >= contacts.Length)
        {
            Console.WriteLine("Liste de contacts pleine");
            return;
        }

        Contact contact = new Contact();
        Console.Write("Nom : ");
        contact.Nom = Console.ReadLine();
        Console.Write("Téléphone : ");
        contact.Telephone = Console.ReadLine();
        Console.Write("Email : ");
        contact.Email = Console.ReadLine();

        contacts[nombreContacts] = contact;
        nombreContacts++;
        Console.WriteLine("Contact ajouté");
    }

    /* partie Luka */

    public static void AfficherContacts()
    {
        Console.WriteLine("\nListe des contacts :");
        if (nombreContacts == 0)
        {
            Console.WriteLine("Aucun contact enregistré.");
            return;
        }

        for (int i = 0; i < nombreContacts; i++)
        {
            Console.WriteLine($"Nom: {contacts[i].Nom}, Téléphone: {contacts[i].Telephone}, Email: {contacts[i].Email}");
        }
    }

    /* partie Xavier */
    public static void RechercherContact()
    {
        Console.Write("\nEntrez le nom à rechercher : ");
        string nomRecherche = Console.ReadLine();
        bool trouve = false;

        for (int i = 0; i < nombreContacts; i++)
        {
            if (contacts[i].Nom.Equals(nomRecherche, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Nom: {contacts[i].Nom}, Téléphone: {contacts[i].Telephone}, Email: {contacts[i].Email}");
                trouve = true;
            }
        }

        if (!trouve)
        {
            Console.WriteLine("Aucun contact trouvé.");
        }
    }

    public static void SupprimerContact()
    {
        Console.Write("\nEntrez le nom du contact à supprimer : ");
        string nomASupprimer = Console.ReadLine();
        bool trouve = false;

        for (int i = 0; i < nombreContacts; i++)
        {
            if (contacts[i].Nom.Equals(nomASupprimer, StringComparison.OrdinalIgnoreCase))
            {
                for (int j = i; j < nombreContacts - 1; j++)
                {
                    contacts[j] = contacts[j + 1];
                }
                contacts[nombreContacts - 1] = null;
                nombreContacts--;
                trouve = true;
                Console.WriteLine("Contact supprimé.");
                break;
            }
        }

        if (!trouve)
        {
            Console.WriteLine("Aucun contact trouvé.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Annuaire.AjouterContact();
        Annuaire.AfficherContacts();
        Annuaire.RechercherContact();
        Annuaire.SupprimerContact();
        Annuaire.AfficherContacts();
    }
}
