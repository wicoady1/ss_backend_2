﻿//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	Main User - Forms
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

			ss_backend_assess.Commons.Cart.RefreshSession ();
		}

		protected void OnBtnCosAddClicked (object sender, EventArgs e)
		{
			this._cPresenter.AddItemToCart ("prd001", "Cosmetic", txtCosQty.Text);
			//throw new NotImplementedException ();
		}

		protected void OnBtnMascaraClicked (object sender, EventArgs e)
		{
			this._cPresenter.AddItemToCart ("prd002", "Mascara", txtMasQty.Text);
			//throw new NotImplementedException ();
		}

		protected void OnBtnConditionerClicked (object sender, EventArgs e)
		{
			this._cPresenter.AddItemToCart ("prd003", "Conditioner", txtConQty.Text);
			//throw new NotImplementedException ();
		}

		protected void OnBtnCheckOutClicked (object sender, EventArgs e)
		{
			new ss_backend_assess.frmConfirmOrder ();

			this.Destroy ();
		}

		protected void OnBtnOrderStatusClicked (object sender, EventArgs e)
		{
			new ss_backend_assess.frmUserOrderList ();
			//throw new NotImplementedException ();
		}

		protected void OnBtnShipStatusClicked (object sender, EventArgs e)
		{
			new ss_backend_assess.frmUserShipCheck ();
			//throw new NotImplementedException ();
		}

		protected void OnBtnLogOutClicked (object sender, EventArgs e)
		{
			ss_backend_assess.Commons.Cart.RefreshSession ();
			ss_backend_assess.Commons.LoginInfo.RefreshSession ();
			new MainWindow ();

			this.Destroy ();
			//throw new NotImplementedException ();
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

