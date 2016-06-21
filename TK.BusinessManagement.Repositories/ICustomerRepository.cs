using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TK.BusinessManagement.Models;

namespace TK.BusinessManagement.Repositories
{
    public interface ICustomerRepository
    {
        bool SaveCustomer(CustomerModel customer);
        bool DeleteCustomer(CustomerModel customer);
    }
}
