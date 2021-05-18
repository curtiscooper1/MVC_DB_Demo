using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBMVC.Models
{
    [Table("category")]
    public class Category
    { 
        [Key]
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            return $"{categoryId} {categoryName} {description }";
        }
    }
}
