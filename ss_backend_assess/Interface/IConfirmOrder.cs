using System;

namespace ss_backend_assess.Interface
{
	public interface IConfirmOrder
	{
		string OrderList {
			get;
			set;
		}

		string CouponCode {
			get;
			set;
		}

		bool DisableCouponField {
			set;
		}
	}
}

