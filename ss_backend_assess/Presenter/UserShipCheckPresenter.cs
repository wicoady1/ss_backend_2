//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160819
 * 	Program		:	Presenter - frmUserShipCheck
 * 	Rev			:
 */
//#########################

using System;
using System.Data;

namespace ss_backend_assess.Presenter
{
	public class UserShipCheckPresenter
	{
		private ss_backend_assess.Interface.IUserShipCheck _iUserCheck;
		private ss_backend_assess.Model.UserShipCheckModel _cUserCheckModel;

		public UserShipCheckPresenter (ss_backend_assess.Interface.IUserShipCheck iUserCheck, connString conStr)
		{
			this._iUserCheck = iUserCheck;
			this._cUserCheckModel = new Model.UserShipCheckModel (conStr);
		}

		//--- Check Shipment Status + Display Status
		public void CheckShipStatus (){
			DataTable dtResult = new DataTable ();
			string strMessage = "";

			dtResult = _cUserCheckModel.RetrieveOrderMaster (_iUserCheck.ShipmentID);

			//--- Check if Shipping ID is correct?
			if (dtResult.Rows.Count == 0) {
				_iUserCheck.ShipmentStatus = "There is no Shipment Number exists!\nPlease try again or check input.";
			}
			else{
				strMessage += "Shipment ID: " + _iUserCheck.ShipmentID + "\n";
				strMessage += "Name:\n " + dtResult.Rows[0]["CustName"].ToString() + "\n";
				strMessage += "Address:\n " + dtResult.Rows[0]["CustAddress"].ToString() + "\n";
				strMessage += "Phone No:\n " + dtResult.Rows[0]["CustPhone"].ToString() + "\n";

				_iUserCheck.ShipmentStatus = strMessage;
			}
		}
	}
}

