using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metiers
{
    public class Employer
    {
        int id;
        string nomUtilisateur;
        string nom,prenom, sexe, tel, email, adresse, type, password;
        DateTime dateNaiss, dateInscription;
        byte[] img;

        public Employer(int id, string nom, string prenom, string sexe, string tel, string email, string adresse, string type, string nomUtilisateur, string password, DateTime dateNaiss, DateTime dateInscription, byte[] img)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.tel = tel;
            this.email = email;
            this.adresse = adresse;
            this.type = type;
            this.nomUtilisateur = nomUtilisateur;
            this.password = password;
            this.dateNaiss = dateNaiss;
            this.dateInscription = dateInscription;
            this.img = img;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Sexe { get => sexe; set => sexe = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Type { get => type; set => type = value; }
        public string NomUtilisateur { get => nomUtilisateur; set => nomUtilisateur = value; }
        public string Password { get => password; set => password = value; }
        public DateTime DateNaiss { get => dateNaiss; set => dateNaiss = value; }
        public DateTime DateInscription { get => dateInscription; set => dateInscription = value; }
        public byte[] Img { get => img; set => img = value; }

        public override bool Equals(object obj)
        {
            var employer = obj as Employer;
            return employer != null &&
                   id == employer.id &&
                   nomUtilisateur == employer.nomUtilisateur;
        }

        public override String ToString()
        {
            return nomUtilisateur + "";
        }
    }
}
