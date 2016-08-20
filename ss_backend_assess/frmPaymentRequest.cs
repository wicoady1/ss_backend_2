//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	Menu for confirming order + upload Payment Proof
 * 	Rev			:
 */
//#########################
using System;
using Gtk;

namespace ss_backend_assess
{
	public partial class frmPaymentRequest : Gtk.Window, ss_backend_assess.Interface.IPaymentRequest
	{
		private connString _connStr;
		private ss_backend_assess.Presenter.PaymentRequestPresenter _cPresenter;

		private FileChooserDialog fcDial;
		private System.IO.FileStream file;
		private Gdk.Pixbuf pixbuf;
		private string strFilePath;

		public frmPaymentRequest () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();

			this._connStr = new connString ();
			this._cPresenter = new ss_backend_assess.Presenter.PaymentRequestPresenter (this, _connStr);

			this._cPresenter.SetPaymentMessage (ss_backend_assess.Commons.Cart.strGrandTotal);
		}

		//--- Upload Payment Proof
		protected void OnBtnProofUploadClicked (object sender, EventArgs e)
		{
			this.OpenFileDialog ();
		}

		//--- Button for Finalize Order
		protected void OnBtnFinalizeClicked (object sender, EventArgs e)
		{
			//--- If user not yet upload his/her payment proof
			if (pixbuf != null) {
				_cPresenter.CopyImageFile(strFilePath);

				new frmMainUser ();
				this.Destroy ();
			} else {
				MessageBox.ShowMsg ("Please upload the Payment Proof...");
			}


		}

		#region Interface Assignment
		public Gdk.Pixbuf PayProof{
			get{
				return imgPayProof.Pixbuf;
			}
			set{
				imgPayProof.Pixbuf = value;
			}
		}

		public string PaymentMessage{
			get{
				return txtPayInfo.Buffer.Text;
			}
			set
			{
				txtPayInfo.Buffer.Text = value;
			}
		}

		#endregion

		//--- Open File Dialog for Upload IMG
		public void OpenFileDialog(){


			fcDial = new FileChooserDialog ("Choose Image as Payment Proof",
				this,
				FileChooserAction.Open,
				"Cancel", ResponseType.Cancel,
				"Open", ResponseType.Accept);
			


			if (fcDial.Run () == (int)ResponseType.Accept) {
				strFilePath = fcDial.Filename;
				file = System.IO.File.OpenRead (fcDial.Filename);
				pixbuf = new Gdk.Pixbuf (file); 

				imgPayProof.Pixbuf = pixbuf;

			}
			fcDial.Destroy ();
		}


	}
}

