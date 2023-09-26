using System;
using System.Security.AccessControl;

namespace _142HerancaPolimorfismo.Entities {
    public class UsedProduct : Product {
        public DateTime ManufactureDate { get; set; }
        public UsedProduct(DateTime manufactureDate, string name, double price) : base(name, price) {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag() {
            return $"{Name} (used): ${Price:N2} (Manufacture Date: {ManufactureDate:dd/MM/yyyy})";

        }
    }
}

