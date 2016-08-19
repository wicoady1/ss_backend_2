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

			this._cPresenter.LoadOrderInfo (ss_backend_assess.Commons.AdminSession.strOrderID);
		}

		protected void OnBtnApproveClicked (object sender, EventArgs e)
		{
			_cPresenter.UpdateOrderApproval (ss_backend_assess.Commons.AdminSession.strOrderID, "Y");
			MessageDialog md = new MessageDialog(null,DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Order has Accepted! Proceeding to Shipment...");
			md.Run();
			md.Destroy();

			new frmAdminProcessShip ();

			this.Destroy ();
		}

		protected void OnBtnRejectClicked (object sender, EventArgs e)
		{
			_cPresenter.UpdateOrderApproval (ss_backend_assess.Commons.AdminSession.strOrderID, "N");

			MessageDialog md = new MessageDialog(null,DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Order has Cancelled! Returning to main menu!");
			md.Run();
			md.Destroy();

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

