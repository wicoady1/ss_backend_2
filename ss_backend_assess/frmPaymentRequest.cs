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
		}

		protected void OnBtnProofUploadClicked (object sender, EventArgs e)
		{
			this.OpenFileDialog ();

			//throw new NotImplementedException ();
		}

		protected void OnBtnFinalizeClicked (object sender, EventArgs e)
		{
			_cPresenter.CopyImageFile (file);

			new frmMainUser ();
			this.Destroy ();

			//throw new NotImplementedException ();
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


		#endregion

		//--- Open File Dialog for Upload IMG
		public void OpenFileDialog(){


			fcDial = new FileChooserDialog ("Choose Image as Payment Proof",
				this,
				FileChooserAction.Open,
				"Cancel", ResponseType.Cancel,
				"Open", ResponseType.Accept);
			


			if (fcDial.Run () == (int)ResponseType.Accept) {
				file = System.IO.File.OpenRead (fcDial.Filename);
				pixbuf = new Gdk.Pixbuf (file); 

				imgPayProof.Pixbuf = pixbuf;

			}
			fcDial.Destroy ();
		}


	}
}

