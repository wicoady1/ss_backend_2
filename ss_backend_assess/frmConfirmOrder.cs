//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	frmConfirmOrder - Shows all user's order. User can input Coupon Code here
 * 	Rev			:
 */
//#########################

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

			//-- Show + calculate all order's price 
			this._cPresenter.CalculateOrder ();
		}

		//-- If user decided and click Use Coupon button
		protected void OnBtnSubmitCouponClicked (object sender, EventArgs e)
		{
			this._cPresenter.UseCoupon ();
		}

		//-- Proceed to frmPaymentInput (user will input his/her data for order)
		protected void OnBtnGoPaymentClicked (object sender, EventArgs e)
		{
			//-- Check if the item is still available in warehouse or not?
			if (!this._cPresenter.ItemValid ()) {
				new frmMainUser ();
				this.Destroy ();
			} else {
				_cPresenter.SubmitOrder ();

				new frmPaymentInput ();
				this.Destroy ();
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

