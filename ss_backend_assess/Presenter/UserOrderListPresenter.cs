//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160819
 * 	Program		:	Presenter - frmUserOrderList
 * 	Rev			:
 */
//#########################

using System;
using System.Data;
using Gtk;

namespace ss_backend_assess.Presenter
{
	public class UserOrderListPresenter
	{
		private ss_backend_assess.Interface.IUserOrderList _iUserOrder;
		private ss_backend_assess.Model.UserOrderListModel _cUserOrderModel;

		public UserOrderListPresenter (ss_backend_assess.Interface.IUserOrderList iUserOrder, connString conStr)
		{
			this._iUserOrder = iUserOrder;
			this._cUserOrderModel = new Model.UserOrderListModel (conStr);
		}

		//--- LOAD all Order created by user with Order Status
		public void LoadMasterOrder(){
			DataTable dtResult = new DataTable ();

			dtResult = _cUserOrderModel.RetrieveOrderMaster ();

			_iUserOrder.OrderList = dtResult;
		}
	}
}

