using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCarApp.Infrastructure.Data.Domain
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Address { get; set; } = null!;

        public virtual IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}
