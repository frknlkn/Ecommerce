using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Model.ModelExtended
{
    public partial class User
    {
        public List<AspNetRole> UserRoles { get; set; }
        public bool IsAdmin { get; set; }
    }
}
