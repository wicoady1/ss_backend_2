using System;

namespace ss_backend_assess
{
	public partial class frmConfirmOrder : Gtk.Window, ss_backend_assess.Interface.IConfirmOrder
	{
		private connString _connStr;
		private ss_backend_assess.Presenter.ConfirmOrderPresenter _cPresenter;


		public frmConfirmOrder () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();

			this._connStr = new connString ();
			this._cPresenter = new ss_backend_assess.Presenter.ConfirmOrderPresenter (this, _connStr);

			this._cPresenter.CalculateOrder ();
		}

		protected void OnBtnSubmitCouponClicked (object sender, EventArgs e)
		{
			this._cPresenter.UseCoupon ();
			//throw new NotImplementedException ();
		}

		protected void OnBtnGoPaymentClicked (object sender, EventArgs e)
		{
			if (!this._cPresenter.ItemValid ()) {
				//this.Destroy ();
			} else {
				_cPresenter.SubmitOrder ();

				new frmPaymentInput ();
			}
		}

		#region Interface Assignment
		public string OrderList {
			get{
				return txtOrderList.Buffer.Text;
			}
			set{
				txtOrderList.Buffer.Text = value;
			}
		}

		public string CouponCode {
			get{
				return txtCoupon.Text;
			}
			set{
				txtCoupon.Text = value;	
			}
		}

		public bool DisableCouponField{
			set{
				txtCoupon.IsEditable = value;
				btnSubmitCoupon.Visible = value;
			}
			get{
				return btnSubmitCoupon.Visible;
			}
		}

		#endregion
	}
}

