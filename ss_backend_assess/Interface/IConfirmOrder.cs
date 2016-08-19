//########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	Interface - frmConfirmOrder
 * 	Rev			:
 */
//#########################

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
			get;
		}
	}
}

