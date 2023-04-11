using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyBox
{
    internal class Garage
    {
        /// <summary>
        /// Identifiant du box
        /// </summary>
        private string garageId;

        /// <summary>
        /// Obtient et définit l'identifiant du box
        /// </summary>
        public string GarageId
        {
            get { return garageId; }
            set { garageId = value; }
        }
        /// <summary>
        /// Nom du parking
        /// </summary>
        private string parkingName;

        /// <summary>
        /// Obtient et définit le nom du parking
        /// </summary>
        public string ParkingName
        {
            get { return parkingName; }
            set { parkingName = value; }
        }
        /// <summary>
        /// Loyer mensuel
        /// </summary>
        private double monthlyRent;

        /// <summary>
        /// Obtient et définit le loyer mensuel
        /// </summary>
        public double MonthlyRent
        {
            get { return monthlyRent; }
            set { monthlyRent = value; }
        }
        /// <summary>
        /// Charges mensuelles
        /// </summary>
        private double monthlyFees;

        /// <summary>
        /// Obtient et définit les charges mensuelles
        /// </summary>
        public double MonthlyFees
        {
            get { return monthlyFees; }
            set { monthlyFees = value; }
        }
        /// <summary>
        /// Nom du locataire
        /// </summary>
        private string tenantName;

        /// <summary>
        /// Obtient et définit le nom du locataire
        /// </summary>
        public string TenantName
        {
            get { return tenantName; }
            set { tenantName = value; }
        }
        /// <summary>
        /// Date de début de location
        /// </summary>
        private DateTime startRent;

        /// <summary>
        /// Obtient et définit la date de début de location
        /// </summary>
        public DateTime StartRent
        {
            get { return startRent; }
            set { startRent = value; }
        }

        public Garage(string GarageId, string ParkingName, double MonthlyRent, double MonthlyFees, string TenantName, DateTime StartRent)
        {
            this.GarageId = GarageId;
            this.ParkingName = ParkingName;
            this.MonthlyRent = MonthlyRent;
            this.MonthlyFees = MonthlyFees;
            this.TenantName = TenantName;
            this.StartRent = StartRent;
        }
    }// endclass
}//endnamespace
