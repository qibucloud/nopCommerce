using FluentValidation.Attributes;
using Nop.Web.Areas.Admin.Models.Common;
using Nop.Web.Areas.Admin.Validators.Customers;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Admin.Models.Customers
{
    [Validator(typeof(CustomerAddressValidator))]
    public partial class CustomerAddressModel : BaseNopModel
    {
        public int CustomerId { get; set; }

        public AddressModel Address { get; set; }
    }
}