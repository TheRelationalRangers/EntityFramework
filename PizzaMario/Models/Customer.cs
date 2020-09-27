using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMario.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addition { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }

        public string Password
        {
            get => Password; // TODO: UnHash password or password check
            set => GetPasswordHash(Password);
        }

        public Address Address { get; set; }
        public int AddressId { get; set; }

        public static string GetPasswordHash(string password)
        {
            using (var sha1 = new SHA1Managed())
            {
                var hash = Encoding.UTF8.GetBytes(password);
                var generatedHash = sha1.ComputeHash(hash);
                var generatedHashString = Convert.ToBase64String(generatedHash);
                return generatedHashString;
            }
        }
    }
}