using System;
namespace _208Interfaces.Payments {
    public interface IOnlinePaymentService {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}

