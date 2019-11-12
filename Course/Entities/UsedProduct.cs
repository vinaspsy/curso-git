using System;
using System.Globalization;

namespace Course.Entities
{
    class UsedProduct : Product
    {

        public DateTime ManufacturateDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacturateDate) 
            : base(name, price)
        {
            ManufacturateDate = manufacturateDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: "
                + ManufacturateDate.ToString("dd/MM/yyyy") + ")";
        }

    }
}
