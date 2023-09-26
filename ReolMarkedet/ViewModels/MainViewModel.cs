using ReolMarkedet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.ViewModels
{
    public class MainViewModel
    {
        public List<ShelfTenant> ShelfTenants { get; set; }
        private ShelfTenantRepo _shelfTenantRepo;
        public MainViewModel() {
            _shelfTenantRepo = new ShelfTenantRepo();
            ShelfTenants = _shelfTenantRepo.GetShelfTenants();
        }  
    }
}
