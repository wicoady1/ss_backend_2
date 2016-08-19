using System;

namespace ss_backend_assess
{
	public partial class frmUserShipCheck : Gtk.Window, ss_backend_assess.Interface.IUserShipCheck
	{
		private connString _connStr;
		private ss_backend_assess.Presenter.UserShipCheckPresenter _cPresenter;


		public frmUserShipCheck () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		
			this._connStr = new connString ();
			this._cPresenter = new ss_backend_assess.Presenter.UserShipCheckPresenter (this, _connStr);

		}

		protected void OnBtnCheckClicked (object sender, EventArgs e)
		{
			_cPresenter.CheckShipStatus ();
			//throw new NotImplementedException ();
		}

		#region Interface Assigment
		public string ShipmentID { 
			get{
				return txtShipID.Text;
			}
		}
		public string ShipmentStatus {
			set{
				txtInquiryResult.Buffer.Text = value;
			}
		}


		#endregion
	}
}

