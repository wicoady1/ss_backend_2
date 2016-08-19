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

		//--- Open File Dialog for Upload IMG
		/*
		public void OpenFileDialog(){

			//FileChooserDialog fcDial = new FileChooserDialog("Choose Image as Payment Proof",
			//	this,
			//	FileChooserAction.Open)

			FileChooserDialog fcDial = new FileChooserDialog ("Choose Image as Payment Proof",
				this,
				FileChooserAction.Open,
				"Cancel", ResponseType.Cancel,
				"Open", ResponseType.Accept);
			System.IO.FileStream file;
			Gdk.Pixbuf pixbuf;


			if (fcDial.Run () == (int)ResponseType.Accept) {
				file = System.IO.File.OpenRead (fcDial.Filename);
				pixbuf = new Gdk.Pixbuf (file); 

				_iPayReq.PayProof = pixbuf;
			}
		}
		*/

		//--- Copy File
		public void CopyImageFile(System.IO.FileStream file){
			string strPayProofPath = "ImgUpload/" + ss_backend_assess.Commons.Cart.strOrderID;
			System.IO.FileStream fileTo = System.IO.File.Create (strPayProofPath);

			file.Seek (0, System.IO.SeekOrigin.Begin);
			file.CopyTo (fileTo);

			file.Close ();
			//System.IO.File.Copy(strFilePath, strPayProofPath);

			this.UpdatePaymentStatus (strPayProofPath);
		}

		//--- Update Database for new Image + Pay Proof Flag
		public void UpdatePaymentStatus(string strImageFile){
			_cPayReqModel.PaymentProofUpdate (strImageFile, ss_backend_assess.Commons.Cart.strOrderID);

			MessageBox.ShowMsg ("Order has been submitted as Order ID: " + ss_backend_assess.Commons.Cart.strOrderID);
		}
	}
}

