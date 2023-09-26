using System;
namespace _142HerancaPolimorfismo.Entities {
    public class ImportedProduct : Product {
        public double CustomFee { get; set; }

        public ImportedProduct(double customFee, string name, double price) : base(name, price) {
            CustomFee = customFee;
        }

        public override string PriceTag() {
            return $"{Name}: ${Price:N2} (Custom fees: ${CustomFee:N2})";

        }
    }
}

