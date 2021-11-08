using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PS.Domain
{
    public class Provider:Concept
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        string password;
        string confirmpassword;
        [DataType(DataType.Password), 
         Required, 
         Compare("Password")]
        public string ConfirmPassword
        {
            get { return confirmpassword; }
            set
            {
                if (Password == value)
                    confirmpassword = value;
                else Console.WriteLine("mot de passe et confirm ne sont pas identiques");
            }
        }
        [DataType(DataType.Password), MinLength(8),Required]
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length >= 5 && value.Length <= 20)
                    password = value;
                else Console.WriteLine("la taille de password doiet etre ente 5 et 20");
            }
        }
        [EmailAddress, Required]
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
        public Boolean IsApproved { get; set; }
        public virtual IList<Product> ListProducts { get; set; }
        public override void GetDetails()
        {
            Console.WriteLine($"Id: {Id} \t" + 
                              $"UserName: {UserName}\t" +
                              $"Password: {Password}\t" +
                              $"ConfirmPassword: {ConfirmPassword}\t" +
                              $"Email :{Email}\t" +
                              $"DateCreated: {DateCreated}\t" +
                              $"IsApproved: {IsApproved}\t");
            foreach (var p in ListProducts)
            {
                p.GetDetails();
            }
        }
        public static void SetIsApproved(Provider P)
        {
            if (P.ConfirmPassword == P.Password) P.IsApproved = true;
        }


        public static void SetIsApproved(string password, string confirmpassword, bool isapproved)
        {
            if (password == confirmpassword) isapproved = true;
        }
        public bool Login(string pass, string user, string email = null)
        {
            if (email == null)
            {
                if (pass == Password && user == UserName) return true;
                else return false;

            }
            else
            {
                if (pass == Password && user == UserName && email == Email) return true;
                else return false;
            }

        }
        public void GetProducts(string filtreType, string filtreValue)
        {
            if (ListProducts != null)
            {
                switch (filtreType)
                {
                    case "DateProd":
                        foreach (Product p in ListProducts)

                            if (DateTime.Equals(p.DateProd, DateTime.Parse(filtreValue)))

                                p.GetDetails();

                        break;


                         

                }
            }
        }
    }
}