using System;



namespace Entidades
{
    public class E_Customer
    {

        #region Constructor



        public E_Customer()
        {
            CustmerId = 0;
            NameStyle = false;
            FirstName = string.Empty;
            LastName = string.Empty;
            PasswordHash = string.Empty;
            PasswordSalt = string.Empty;

        }
         #endregion

        #region Encapsulamiento de atributos

        public int CustmerId { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }

        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string CompanyName { get; set; }
        public string SalesPerson { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime ModifiedDate { get; set; }
        #endregion  

    }
}
