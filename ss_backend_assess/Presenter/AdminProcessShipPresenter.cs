using System;
using System.Data;

namespace ss_backend_assess.Presenter
{
	public class AdminProcessShipPresenter
	{
		private ss_backend_assess.Interface.IAdminProcessShip _iAdminShip;
		private ss_backend_assess.Model.AdminProcessShipModel _cAdminShipModel;

		private string strOrderID;

		public AdminProcessShipPresenter (ss_backend_assess.Interface.IAdminProcessShip iAdmin, connString conStr)
		{
			this._iAdminShip = iAdmin;
			this._cAdminShipModel = new Model.AdminProcessShipModel (conStr);
		}

		//--- Load Order Detail
		public void LoadOrderDetail(string strOrderID){
			DataTable dtResult = new DataTable ();
			string strOrderDetail = "";

			dtResult = _cAdminShipModel.RetrieveOrderDetail (strOrderID);

			for (int i = 0; i < dtResult.Rows.Count; i++) {
				strOrderDetail += dtResult.Rows [i] ["ProductQty"].ToString () +
					"x (" + dtResult.Rows [i] ["ProductID"].ToString () + ") " +
					dtResult.Rows [i] ["Name"].ToString () + "\n";
			}

			_iAdminShip.OrderDetail = strOrderDetail;
		}


		//--- Update Shipment Status
		public void UpdateShipmentStatus (string strOrderID){
			_cAdminShipModel.UpdateShipStatus (strOrderID, this._iAdminShip.ShipID);
		}
	}
}

