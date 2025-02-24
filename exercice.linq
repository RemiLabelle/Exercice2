<Query Kind="Statements" />

public class Entreprise
{
	public string nomEntreprise;

	public List<Employé> employes;

	public Entreprise(string nomEntreprise)
	{
		this.nomEntreprise = nomEntreprise;
		this.employes = new List<Employé>();
	}

	public void AjouterEmploye(Employé employe)
	{
		this.employes.Add(employe);
	}
}

class Employé
{ //rdytufg
	//fields nmnb
	private string _nom;
	private string _prenom;
	private int _id;
	private DateOnly _dateEmbauche;

	//constructor
	public Employé(string nom, string prenom, int id, DateOnly dateEmbauche)
	{
		SetNom(nom);
		SetPrenom(prenom);
		SetId(id);
		SetDateEmbauche(dateEmbauche);
	}

	//getters
	public string GetNom() => _nom;
	public string GetPrenom() => _prenom;
	public int GetId() => _id;
	public DateOnly GetDateEmbauche() => _dateEmbauche;

	//setters
	public void SetNom(string nom)
	{
		if (nom is null) throw new ArgumentNullException(nameof(nom));
		if (nom.Trim() == "") throw new ArgumentException("Le nom ne peut être blanc", nameof(nom));
		_nom = nom;
	}
	public void SetPrenom(string prenom)
	{
		if (prenom is null) throw new ArgumentNullException(nameof(prenom));
		if (prenom.Trim() == "") throw new ArgumentException("Le nom ne peut être blanc", nameof(prenom));
		_prenom = prenom;
	}
	public void SetId(int id)
	{
		if (id < 1) throw new ArgumentException("Id ne peut pas être inférieur à 1");
		_id = id;
	}
	public void SetDateEmbauche(DateOnly dateEmbauche)
	{
		_dateEmbauche = dateEmbauche;
	}

	//functions
	public int CalculerAncienneté()
	{
		return DateTime.Now.Year - this.GetDateEmbauche().Year;
	}

	public void AfficherInfo()
	{
		new[] {
		("ID: " + this.GetId()),
		("Nom: " + this.GetNom()),
		("Prénom: " + this.GetPrenom()),
		("Date d'embauche: " + this.GetDateEmbauche()),
		("Ancienneté: " + CalculerAncienneté())
		}.Dump();
	}
}
