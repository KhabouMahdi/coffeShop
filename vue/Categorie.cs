using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metiers
{
    public class Categorie
    {
        int idCat;
        String nom, description;
        byte[] img;

        public Categorie(int idCat, string nom, string description, byte[] img)
        {
            this.idCat = idCat;
            this.nom = nom;
            this.description = description;
            this.img = img;
        }
        public int GetId()
        {
            return this.idCat;
        }

        public int IdCat { get => idCat; set => idCat = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Description { get => description; set => description = value; }
        public byte[] Img { get => img; set => img = value; }

        public override bool Equals(object obj)
        {
            var categorie = obj as Categorie;
            return categorie != null &&
                   idCat == categorie.idCat;
        }

        public override String ToString()
        {
            return nom + "";
        }

    }

}
