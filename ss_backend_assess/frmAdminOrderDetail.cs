//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160819
 * 	Program		:	frmAdminOrderDetail - Shows order detail 
 * 	Rev			:
 */
//#########################
using System;
using Gtk;

namespace ss_backend_assess
{
	public partial class frmAdminOrderDetail : Gtk.Window, ss_backend_assess.Interface.IAdminOrderDetail
	{
		private connString _connStr;
		private ss_backend_assess.Presenter.AdminOrderDetailPresenter _cPresenter;

		public frmAdminOrderDetail () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();

			this._connStr = new connString ();
			this._cPresenter = new ss_backend_assess.Presenter.AdminOrderDetailPresenter (this, _connStr);

			//-- Load Order, which need to be approve / reject by admin
			try{
				this._cPresenter.LoadOrderInfo (ss_backend_assess.Commons.AdminSession.strOrderID);
			}
			catch{
				//-- Rare bug: Even when user already selected Order ID on frmAdminOrderList, it still gets Exception Error
				new frmAdminOrderList();
				this.Destroy ();
			}
		}

		//--- Approve Button Clicked
		protected void OnBtnApproveClicked (object sender, EventArgs e)
		{
			_cPresenter.UpdateOrderApproval (ss_backend_assess.Commons.AdminSession.strOrderID, "Y");
			MessageBox.ShowMsg ("Order has Accepted! Proceeding to Shipment...");

			new frmAdminProcessShip ();

			this.Destroy ();
		}

		//--- Reject Button Clicked
		protected void OnBtnRejectClicked (object sender, EventArgs e)
		{
			_cPresenter.UpdateOrderApproval (ss_backend_assess.Commons.AdminSession.strOrderID, "N");
			MessageBox.ShowMsg ("Order has Cancelled! Returning to main menu!");

			new frmAdminOrderList ();

			this.Destroy ();
		}

		#region Interface Assignment
		public string OrderTitle { 
			set{
				lblOrderID.Text = "Order ID : " + value;
			}
		}
		public string OrderDetail { 
			get{
				return txtOrderList.Buffer.Text;		
			}
			set{
				txtOrderList.Buffer.Text = value;
			}
		}
		public string CustName {
			get{
				return txtName.Text;
			}
			set{
				txtName.Text = value;
			}
		}
		public string CustPhone {
			get{
				return txtPhone.Text;
			}
			set{
				txtPhone.Text = value;
			}
		}
		public string CustEmail {
			get
			{ 
				return txtEmail.Text;
			}
			set
			{ 
				txtEmail.Text = value;
			}
		}
		public string CustAdd {
			get
			{
				return txtAddress.Buffer.Text;
			}
			set
			{
				txtAddress.Buffer.Text = value;
			}
		}
		public Gdk.Pixbuf ImageFile {
			set 
			{
				imgPayProof.Pixbuf = value;
			}
		}


		#endregion
	}
}

