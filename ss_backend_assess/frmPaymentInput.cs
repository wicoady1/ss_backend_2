using System;
using Gtk;

namespace ss_backend_assess
{
	public partial class frmPaymentInput : Gtk.Window, ss_backend_assess.Interface.IPaymentInput
	{
		private connString _connStr;
		private ss_backend_assess.Presenter.PaymentInputPresenter _cPresenter;

		public frmPaymentInput () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();

			this._connStr = new connString ();
			this._cPresenter = new ss_backend_assess.Presenter.PaymentInputPresenter (this, _connStr);
		}

		protected void OnBtnProceedClicked (object sender, EventArgs e)
		{
			if (_cPresenter.DataValidation ()) {
				this._cPresenter.InsertCustomerData ();

				new frmPaymentRequest ();
			} else {
				MessageDialog md = new MessageDialog(null,DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Please double check the Input");
				md.Run();
				md.Destroy();
			}
		}

		#region Interface Assignment
		public string CustName {
			get{
				return txtName.Text;
			}
			set{
				txtName.Text = value;
			}
		}
		public string PhoneNo {
			get{
				return txtPhone.Text;
			}
			set{
				txtPhone.Text = value;	
			}
		}
		public string Email {
			get{
				return txtEmail.Text;
			}
			set{
				txtEmail.Text = value;
			}
		}
		public string Address {
			get{
				return txtAddress.Buffer.Text;
			}
			set{
				txtAddress.Buffer.Text = value;
			}
		}


		#endregion
	}
}

