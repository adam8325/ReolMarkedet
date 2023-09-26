using ReolMarkedet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.ViewModels
{
    public class BillingViewModel
    {
        public Billing Billing { get; set; }

        private ItemRepo _itemRepo;
        public BillingViewModel(int shelfTenantId) {

            _itemRepo = new ItemRepo();
            var billing = new Billing();
            billing.Items = _itemRepo.GetItemsForTenant(shelfTenantId);
            billing.SetSale();
            billing.SetCommission();
            Billing = billing;
        }
    }
}
