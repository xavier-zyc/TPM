using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TPM.Framework.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("LocalMySqlServer")
        {
            Database.SetInitializer(new MySqlInitializer());
        }
    }
}