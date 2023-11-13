using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DDAC_Assignment.Models
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }

        [NotNull]
        public string username { get; set; }
        [NotNull]
        public string password { get; set; }

        public long balance { get; set; }

        public string gender { get; set; }

        public string role { get; set; }

        public string mobile { get; set; }

        public string realname { get; set; }

        public string email { get; set; }

        public string status { get; set; }
    }
}
