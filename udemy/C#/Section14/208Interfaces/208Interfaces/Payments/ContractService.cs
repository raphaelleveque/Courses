using System;
using _208Interfaces.Entities;
namespace _208Interfaces.Payments {
    public class ContractService {
        private IOnlinePaymentService _service;
        public ContractService(IOnlinePaymentService service) {
            _service = service;
        }

        public void ProcessContract(Contract contract, int months) {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++) {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = _service.Interest(basicQuota, i);
                double fullQuota = _service.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}

