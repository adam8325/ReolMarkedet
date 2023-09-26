using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Models
{
    public class ShelfTenant
    {
        public int ShelfTenantId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        private string? AccountDetails { get; set; }

        public ShelfTenant(int id, string? name, string? email, string? phone, string? accountdetails)
        {
            this.ShelfTenantId = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.AccountDetails = accountdetails;
        }

    }
}
