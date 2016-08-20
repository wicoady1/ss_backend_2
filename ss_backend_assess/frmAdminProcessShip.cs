//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160819
 * 	Program		:	frmAdminProcessShip - Process Order Shipment and mark it as shipped
 * 	Rev			:
 */
//#########################

using System;

namespace ss_backend_assess
{
	public partial class frmAdminProcessShip : Gtk.Window, ss_backend_assess.Interface.IAdminProcessShip
	{
		private connString _connStr;
		private ss_backend_assess.Presenter.AdminProcessShipPresenter _cPresenter;

		public frmAdminProcessShip () :
			base (Gtk.WindowType.Toplevel)
		{
			this._connStr = new connString ();
			this._cPresenter = new ss_backend_assess.Presenter.AdminProcessShipPresenter (this, _connStr);

			this.Build ();

			//-- Load current Order Detail
			this._cPresenter.LoadOrderDetail (ss_backend_assess.Commons.AdminSession.strOrderID);
		}

		//--- When user click Ship button for current order
		protected void OnBtnUpdateShipClicked (object sender, EventArgs e)
		{
			if (this._cPresenter.UpdateShipmentStatus (ss_backend_assess.Commons.AdminSession.strOrderID)) {
				new frmAdminOrderList ();
				this.Destroy ();
			}
		}

		#region Interface Assigment
		public string ShipOrderTitle { 
			set{
				lblOrderID.Text = "Order ID : " + value;
			}
		}
		public string OrderDetail{
			set{
				txtListBarang.Buffer.Text = value;
			}
		}
		public string ShipStatus {
			get{
				if (chkShipped.Active) {
					return "Y";
				} else {
					return "N";
				}
			}
		}
		public string ShipID {
			get
			{ 
				return txtShippingID.Text;
			}
			set
			{ 
				txtShippingID.Text = value;
			}
		}


		#endregion
	}
}

