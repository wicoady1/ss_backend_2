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

		//--- Set Payment Message (with Grand Total)
		public void SetPaymentMessage(string strGrandTotal){
			string strMessage = "";

			strMessage += "Total Payment Amount: " + strGrandTotal +" IDR\n"+
			"Please do Bank Transfer on:\n" +
			"14151231512315123\n" +
			"a.n. Test Test Test\n";

			_iPayReq.PaymentMessage = strMessage;
		}

		//--- Copy File
		public void CopyImageFile(string strFileSource){
			string strPayProofPath = "ImgUpload/" + ss_backend_assess.Commons.Cart.strOrderID;

			System.IO.File.Copy (strFileSource, strPayProofPath);

			this.UpdatePaymentStatus (strPayProofPath);
		}


		//--- Update Database for new Image + Pay Proof Flag
		public void UpdatePaymentStatus(string strImageFile){
			_cPayReqModel.PaymentProofUpdate (strImageFile, ss_backend_assess.Commons.Cart.strOrderID);

			MessageBox.ShowMsg ("Order has been submitted as Order ID: " + ss_backend_assess.Commons.Cart.strOrderID);

			//-- Refresh User Session
			ss_backend_assess.Commons.Cart.RefreshSession();
		}
	}
}

