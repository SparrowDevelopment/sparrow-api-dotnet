using System;
using System.Collections.Generic;
using System.Text;

namespace Sparrow
{
    public class AchAccount: IPaymentType, ISparrowApi
    {
        public string BankName { get; set; }
        public string Routing { get; set; }
        public string Account { get; set; }
        public string AccountType { get; set; }
        public string AccountSubType { get; set; }
        public string CourtesyCardId { get; set; }
        public string CheckNumber { get; set; }
    }

    public interface ISparrowApi
    {
    }

    public interface IPaymentType: ISparrowApi
    {
    }
}
