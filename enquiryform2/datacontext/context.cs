using enquiryform2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace enquiryform2.datacontext
{
    public class context : DbContext
    {
        public context()
            : base("name=myconnection")
        {

        }
        public virtual DbSet<enquiry> customerenquiry { get; set; }
    }
}