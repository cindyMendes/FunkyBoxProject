using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FunkyBox
{
    internal class Customer
    {
        /// <summary>
        /// Prénom du client
        /// </summary>
        private string firstName;

        /// <summary>
        /// Obtient et Définit le prénom du client
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        /// <summary>
        /// Nom de famille du client
        /// </summary>
        private string lastName;

        /// <summary>
        /// Obtient et Définit le nom de famille du client
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        /// <summary>
        /// Le numéro de voie
        /// </summary>
        private int streetNumber;
        /// <summary>
        /// Obtient et Définit le numéro de voie
        /// </summary>
        public int StreetNumber
        {
            get { return streetNumber; }
            set { streetNumber = value; }
        }

        /// <summary>
        /// Le type de voie
        /// </summary>
        private string streetType;

        /// <summary>
        /// Obtient et Définit le type de voie
        /// </summary>
        public string StreetType

        {
            get { return streetType; }
            set { streetType = value; }
        }

        /// <summary>
        /// Le nom de la rue
        /// </summary>
        private string streetName;

        /// <summary>
        /// Obtient et Définit le nom de la rue
        /// </summary>
        public string StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }

        /// <summary>
        /// Le code postal
        /// </summary>
        private string postalCode;

        /// <summary>
        /// Obtient et Définit le code postal
        /// </summary>
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        /// <summary>
        /// Le nom de la ville
        /// </summary>
        private string city;

        /// <summary>
        /// Obtient et Définit le nom de la ville
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        ///// <summary>
        ///// La liste des plaques d'immatriculation
        ///// </summary>
        //private List<string> licencePlate;

        ///// <summary>
        ///// Obtient et définit la liste des plaques d'immatriculation
        ///// </summary>
        //public List<string> LicencePlate
        //{
        //    get { return licencePlate; }
        //    set { licencePlate = value; }
        //}


        /// <summary>
        /// constructeur d'initialisation
        /// </summary>
        /// <param name="FN"></param>
        /// <param name="LN"></param>
        /// <param name="SNb"></param>
        /// <param name="ST"></param>
        /// <param name="SNa"></param>
        /// <param name="PC"></param>
        /// <param name="Ct"></param>
        //public Customer(string FN, string LN, int SNb, string ST, string SNa, string PC, string Ct, List<string> LP)
        //{
        //    this.FirstName = FN;
        //    this.LastName = LN;
        //    this.StreetNumber = SNb;
        //    this.StreetType = ST;
        //    this.StreetName = SNa;
        //    this.PostalCode = PC;
        //    this.City = Ct;
        //    this.LicencePlate = LP;
        //}


        private string licencePlate;

        public string LicencePlate
        {
            get { return licencePlate; }
            set { licencePlate = value; }
        }

        public Customer(string FN, string LN, int SNb, string ST, string SNa, string PC, string Ct, string LP)
        {
            this.FirstName = FN;
            this.LastName = LN;
            this.StreetNumber = SNb;
            this.StreetType = ST;
            this.StreetName = SNa;
            this.PostalCode = PC;
            this.City = Ct;
            this.LicencePlate = LP;
        }



        //public override string ToString()
        //{
        //    return "Résultats : " + this.FirstName + " " + this.LastName + " " + this.StreetNumber + " " + this.StreetType + " " + this.StreetName + " " + this.PostalCode + " " + this.City;
        //}


    } //endclass
}//endnamespace
