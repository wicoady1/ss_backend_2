//########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	Interface - frmPaymentRequest
 * 	Rev			:
 */
//#########################

using System;

namespace ss_backend_assess.Interface
{
	public interface IPaymentRequest
	{
		Gdk.Pixbuf PayProof {
			get;
			set;
		}
	}
}

