   using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyBox
{
    public class PureParking
    {

        /// <summary>
        /// Nom du parking
        /// </summary>
        private string parkingName;

        /// <summary>
        /// Obtient et Définit le nom du parking
        /// </summary>
        public string ParkingName
        {
            get { return parkingNumber; }
            set { parkingNumber = value; }
        }

        /// <summary>
        /// Numéro du parking
        /// </summary>
        private string parkingNumber;

        /// <summary>
        /// Obtient et Définit le numéro du parking
        /// </summary>
        public string ParkingNumber
        {
            get { return parkingNumber; }
            set { parkingNumber = value; }
        }

        /// <summary>
        /// Adresse principale du parking
        /// </summary>
        private string parkingAdd1;

        /// <summary>
        /// Obtient et Définit l'adresse principale du parking
        /// </summary>
        public string ParkingAdd1
        {
            get { return parkingAdd1; }
            set { parkingAdd1 = value; }
        }

        /// <summary>
        /// Adresse complémentaire du parking
        /// </summary>
        private string parkingAdd2;

        /// <summary>
        /// Obtient et Définit l'adresse principale du parking
        /// </summary>
        public string ParkingAdd2
        {
            get { return parkingAdd2; }
            set { parkingAdd2 = value; }
        }

        /// <summary>
        /// Numéro de voie de l'adresse du parking
        /// </summary>
        private string parkingStNb;

        /// <summary>
        /// Obtient et Définit le numéro de voie de l'adresse du parking
        /// </summary>
        public string ParkingStNb
        {
            get { return parkingStNb; }
            set { parkingStNb = value; }
        }

        /// <summary>
        /// Le constructeur pour le formulaire frmCreateParking
        /// </summary>
        public PureParking(string PkNm, string PkNb, string PkAdd1, string PkAdd2, string PkStNb)
        {
            this.ParkingName = PkNm;
            this.ParkingNumber = PkNb;
            this.ParkingAdd1 = PkAdd1;
            this.ParkingAdd2 = PkAdd2;
            this.ParkingStNb = PkStNb;

        }



    } // end class
} // end namespace
