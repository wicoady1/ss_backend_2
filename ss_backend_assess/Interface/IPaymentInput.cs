using System;

namespace ss_backend_assess.Interface
{
	public interface IPaymentInput
	{
		string CustName {
			get;
			set;
		}
		string PhoneNo {
			get;
			set;
		}
		string Email {
			get;
			set;
		}
		string Address {
			get;
			set;
		}
	}
}

