//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	Presenter - frmPaymentRequestPresenter
 * 	Rev			:
 */
//#########################

using System;
using Gtk;

namespace ss_backend_assess.Presenter
{
	public class PaymentRequestPresenter
	{
		private ss_backend_assess.Interface.IPaymentRequest _iPayReq;
		private ss_backend_assess.Model.PaymentRequestModel _cPayReqModel;

		private string strImgPath;

		public PaymentRequestPresenter (ss_backend_assess.Interface.IPaymentRequest iPayReq, connString conStr)
		{
			this._iPayReq = iPayReq;
			this._cPayReqModel = new Model.PaymentRequestModel (conStr);

		}

		//--- Copy File
		public void CopyImageFile(System.IO.FileStream file){
			string strPayProofPath = "ImgUpload/" + ss_backend_assess.Commons.Cart.strOrderID;
			System.IO.FileStream fileTo = System.IO.File.Create (strPayProofPath);

			file.Seek (0, System.IO.SeekOrigin.Begin);
			file.CopyTo (fileTo);

			file.Close ();

			this.UpdatePaymentStatus (strPayProofPath);
		}

		//--- Update Database for new Image + Pay Proof Flag
		public void UpdatePaymentStatus(string strImageFile){
			_cPayReqModel.PaymentProofUpdate (strImageFile, ss_backend_assess.Commons.Cart.strOrderID);

			MessageBox.ShowMsg ("Order has been submitted as Order ID: " + ss_backend_assess.Commons.Cart.strOrderID);
		}
	}
}

