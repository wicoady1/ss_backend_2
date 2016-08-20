//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160819
 * 	Program		:	Presenter - frmAdminProcessShip
 * 	Rev			:
 */
//#########################

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

			_iAdminShip.ShipOrderTitle = strOrderID;
			dtResult = _cAdminShipModel.RetrieveOrderDetail (strOrderID);

			for (int i = 0; i < dtResult.Rows.Count; i++) {
				strOrderDetail += dtResult.Rows [i] ["ProductQty"].ToString () +
					"x (" + dtResult.Rows [i] ["ProductID"].ToString () + ") " +
					dtResult.Rows [i] ["Name"].ToString () + "\n";
			}

			_iAdminShip.OrderDetail = strOrderDetail;
		}


		//--- Update Shipment Status (with Shipping ID)
		public bool UpdateShipmentStatus (string strOrderID){

			//-- check if the order is already shipped or not?
			if (_iAdminShip.ShipStatus == "Y") {
				_cAdminShipModel.UpdateShipStatus (strOrderID, this._iAdminShip.ShipID);
				MessageBox.ShowMsg ("Order ID: " + strOrderID + " has shipped succesfully!");

				return true;
			} else if (_iAdminShip.ShipStatus == "N") {
				MessageBox.ShowMsg ("Please check \"Shipped?\" before proceed");
			} else if (_iAdminShip.ShipID = "") {
				MessageBox.ShowMsg ("Please input the Shipment ID!");
			}
			return false;
		}
	}
}

