using api.premier.Models.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.premier.Models.WorkOrder
{
    public class ContractDetailDto
    {
        public int ContractDetailId { get; set; }
        public DateTime? LeaseStartDate { get; set; }
        public DateTime? LeaseEndDate { get; set; }
        public DateTime? PaymentsDue { get; set; }
        public decimal? ListRentPrice { get; set; }
        public int? Currency { get; set; }
        public decimal? FinalRentPrice { get; set; }
        public int? CurrencyFinal { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        //public virtual HousingListDto ContractDetailNavigation { get; set; }
        public virtual CatCurrencyDto CurrencyNavigation { get; set; }
        public virtual ICollection<PropertyExpenseDto> PropertyExpenses { get; set; }
    }
}
