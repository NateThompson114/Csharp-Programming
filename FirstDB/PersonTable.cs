using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDB
{
    public class PersonTable
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class TableContext : DbContext
    {
        public DbSet<PersonTable> Person { get; set; }
    }
}
