using System;
namespace _208Interfaces.Payments {
    public class PaypalService : IOnlinePaymentService {
        private double _paymentFee = 0.02;
        private double _interest = 0.01;
        public PaypalService() {
        }
        public double PaymentFee(double amount) {
            return amount * (1 + _paymentFee);
        }
        public double Interest(double amount, int months) {
            return amount * (1 + (_interest * months));
        }
    }
}

