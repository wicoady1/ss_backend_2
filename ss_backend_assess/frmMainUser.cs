//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	Main menu for User
 * 	Rev			:
 */
//#########################

using System;

namespace ss_backend_assess
{
	public partial class frmMainUser : Gtk.Window, ss_backend_assess.Interface.IMainUser
	{
		private connString _connStr;
		private ss_backend_assess.Presenter.MainUserPresenter _cPresenter;

		public frmMainUser () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();

			this._connStr = new connString ();
			this._cPresenter = new ss_backend_assess.Presenter.MainUserPresenter (this, _connStr);
		}

		//-- Add Cosmetic to Cart, according to inputted amount
		protected void OnBtnCosAddClicked (object sender, EventArgs e)
		{
			this._cPresenter.AddItemToCart ("prd001", "Cosmetic", txtCosQty.Text);
		}

		//-- Add Mascara to Cart, according to inputted amount
		protected void OnBtnMascaraClicked (object sender, EventArgs e)
		{
			this._cPresenter.AddItemToCart ("prd002", "Mascara", txtMasQty.Text);
		}

		//-- Add Conditioner to Cart, according to inputted amount
		protected void OnBtnConditionerClicked (object sender, EventArgs e)
		{
			this._cPresenter.AddItemToCart ("prd003", "Conditioner", txtConQty.Text);
		}

		//-- Check out to process order (open Confirm Order window)
		protected void OnBtnCheckOutClicked (object sender, EventArgs e)
		{
			new ss_backend_assess.frmConfirmOrder ();

			this.Destroy ();
		}

		//-- Check Ordered Order Status List (open Order Status List window)
		protected void OnBtnOrderStatusClicked (object sender, EventArgs e)
		{
			new ss_backend_assess.frmUserOrderList ();
		}

		//-- Check Shipping Status List (open Shipping Check window)
		protected void OnBtnShipStatusClicked (object sender, EventArgs e)
		{
			new ss_backend_assess.frmUserShipCheck ();
		}

		//-- Check Shipping Status List (open Shipping Check window)
		protected void OnBtnLogOutClicked (object sender, EventArgs e)
		{
			ss_backend_assess.Commons.Cart.RefreshSession ();
			ss_backend_assess.Commons.LoginInfo.RefreshSession ();
			new MainWindow ();

			this.Destroy ();
		}

		//-- Clear Cart
		protected void OnBtnCartClicked (object sender, EventArgs e)
		{
			ss_backend_assess.Commons.Cart.ClearCart ();
			MessageBox.ShowMsg ("Cart has been cleared");
		}

		#region Interface
		public int CosmeticQty{
			get{
				return Int32.Parse (txtCosQty.Text);
			}
			set{
				txtConQty.Text = value.ToString ();
			}
		}
		public int MascaraQty{
			get{
				return Int32.Parse (txtMasQty.Text);
			}
			set{
				txtMasQty.Text = value.ToString ();
			}
		}
		public int ConditionerQty{
			get{
				return Int32.Parse (txtConQty.Text);
			}
			set{
				txtConQty.Text = value.ToString ();
			}
		}
		#endregion
	}
}

