using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace SGS_Web.Models
{
    public class Client
    {
        public int ID { get; set; }
        private byte[] _key;
        public byte[] key
        {
            get
            {
                return _key;
            }
            set
            {
                RandomNumberGenerator rng = RandomNumberGenerator.Create();

                byte[] data = new byte[32];
                rng.GetBytes(data);
                _key = data;
            }
        }
        public string email { get; set; }
        public int limit { get; set; }
        public int expiration { get; set; }
    }

    public class MSA_Clients : DbContext
    {
        public DbSet<Client> Clients { get; set; }
    }
}