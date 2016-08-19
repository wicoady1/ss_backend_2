//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160819
 * 	Program		:	Presenter - frmAdminOrderList
 * 	Rev			:
 */
//#########################

using System;
using System.Data;

namespace ss_backend_assess.Presenter
{
	public class AdminMainPresenter
	{
		private ss_backend_assess.Interface.IAdminMain _iAdminMain;
		private ss_backend_assess.Model.AdminMainModel _cAdminMainModel;

		public AdminMainPresenter (ss_backend_assess.Interface.IAdminMain iAdmin, connString conStr)
		{
			this._iAdminMain = iAdmin;
			this._cAdminMainModel = new Model.AdminMainModel (conStr);
		}

		//--- Load Pending Order to TreeView
		public void LoadPendingOrder(){
			DataTable dtResult = new DataTable ();

			dtResult = _cAdminMainModel.RetrievePendingOrder ();
			_iAdminMain.OrderList = dtResult;
		}

		//--- Set Selected Order ID to Session for next Confirmation Window
		public void SetSelectedOrderID(string strOrderID){
			ss_backend_assess.Commons.AdminSession.strOrderID = strOrderID;
		}
	}
}

