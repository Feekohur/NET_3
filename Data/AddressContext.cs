using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NET_3.Models;
using Microsoft.EntityFrameworkCore;

namespace NET_3.Data
{
    public class AddressContext : DbContext
    {
        public AddressContext(DbContextOptions options) : base(options) { }
        public DbSet<Address> Address { get; set; }

    }
}
