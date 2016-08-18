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

