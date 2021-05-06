using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projet_GSB
{
    public class Vehicule
    {
        private string dateAchat;
        private string typePayement;
        private double prixVehicule;
        private int kilometrageVehicule;
        private string immatriculationVehicule;
        private string modelVehicule;
        private string typeVehicule;
        private string etatVehicule;
        private int stockageVehicule;
        private string statueVehicule;

        public Vehicule()
        {
            dateAchat = "0000-00-00";
            typePayement = "null";
            prixVehicule = 0.0;
            kilometrageVehicule = 0;
            modelVehicule = "null";
            immatriculationVehicule = "null";
            typeVehicule = "null";
            etatVehicule = "null";
            stockageVehicule = 0;
            statueVehicule = "null";
        }
        public Vehicule(string dateAchat, string typePayement, double prixVehicule, int kilometrageVehicule, string immatriculationVehicule, string modelVehicule, string typeVehicule, string etatVehicule, int stockageVehicule, string statueVehicule)
        {
            this.dateAchat = dateAchat ;
            this.typePayement = typePayement;
            this.prixVehicule = prixVehicule;
            this.kilometrageVehicule = kilometrageVehicule;
            this.modelVehicule = modelVehicule;
            this.immatriculationVehicule = immatriculationVehicule;
            this.typeVehicule = typeVehicule;
            this.etatVehicule = etatVehicule;
            this.stockageVehicule = stockageVehicule;
            this.statueVehicule = statueVehicule;
        }
        public string getDateAchat()
        {
            return this.dateAchat;
        }
        public void setDateAchat(string date)
        {
            this.dateAchat = date;

        }
        public string getTypePayement()
        {
            return this.typePayement;
        }
        public void setTypePayement(string typePaye)
        {
            this.typePayement = typePaye;

        }
        public double getPrix()
        {
            return this.prixVehicule;
        }
        public void setPrix(double prix)
        {
            this.prixVehicule = prix;

        }
        public int getKilometrage()
        {
            return this.kilometrageVehicule;
        }
        public void setKilometrage(int km)
        {
            this.kilometrageVehicule = km;

        }
        public string getModel()
        {
            return this.modelVehicule;
        }
        public void setModel(string mdl)
        {
            this.modelVehicule = mdl;

        }
        public string getImmatriculation()
        {
            return this.immatriculationVehicule;
        }
        public void setImmatriculation(string imt)
        {
            this.immatriculationVehicule = imt;

        }
        public string getTypeVehi()
        {
            return this.typeVehicule;
        }
        public void setTypeVehi(string tv)
        {
            this.typeVehicule = tv;

        }
        public string getEtat()
        {
            return this.etatVehicule;
        }
        public void setEtat(string ev)
        {
            this.etatVehicule = ev;

        }
        public int getStock()
        {
            return this.stockageVehicule;
        }
        public void setStock(int stock)
        {
            this.stockageVehicule = stock;
        }
        public string getStatut()
        {
            return this.statueVehicule;
        }
        public void setStatut(string stat)
        {
            this.statueVehicule = stat;
        }
    }
}
