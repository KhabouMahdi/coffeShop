using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace metiers

{
   public class Produit
    {
        int id;
        String nom,description;
        Categorie idCat;
        decimal prix;
        byte[] img;

        public Produit(int id, string nom, string description, Categorie idCat, decimal prix, byte[] img)
        {
            this.id = id;
            this.nom = nom;
            this.description = description;
            this.idCat = idCat;
            this.prix = prix;
            this.img = img;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Description { get => description; set => description = value; }
        public Categorie IdCat { get => idCat; set => idCat = value; }
        public decimal Prix { get => prix; set => prix = value; }
        public byte[] Img { get => img; set => img = value; }

        public override bool Equals(object obj)
        {
            var produit = obj as Produit;
            return produit != null &&
                   id == produit.id;
        }
    }
}
