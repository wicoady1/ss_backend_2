using System;
using System.Data;

namespace ss_backend_assess.Presenter
{
	public class AdminOrderDetailPresenter
	{
		private ss_backend_assess.Interface.IAdminOrderDetail _iAdminDet;
		private ss_backend_assess.Model.AdminOrderDetail _cAdminDetModel;

		private string strOrderID;

		public AdminOrderDetailPresenter (ss_backend_assess.Interface.IAdminOrderDetail iAdmin, connString conStr)
		{
			this._iAdminDet = iAdmin;
			this._cAdminDetModel = new Model.AdminOrderDetail (conStr);
		}

		//--- Load All Order Master and Detail
		public void LoadOrderInfo(string strOrderID){
			this.strOrderID = strOrderID;

			LoadMasterOrder ();
			LoadOrderDetail ();
		}

		//--- Load Order Master
		private void LoadMasterOrder(){
			DataTable dtResult = new DataTable ();
			Gdk.Pixbuf imgData;

			dtResult = _cAdminDetModel.RetrieveOrderMaster (this.strOrderID);

			_iAdminDet.CustName = dtResult.Rows [0] ["CustName"].ToString();
			_iAdminDet.CustPhone = dtResult.Rows [0] ["CustPhone"].ToString();
			_iAdminDet.CustEmail = dtResult.Rows [0] ["CustEmail"].ToString();
			_iAdminDet.CustAdd = dtResult.Rows [0] ["CustAddress"].ToString();
			imgData = new Gdk.Pixbuf(System.IO.File.OpenRead (dtResult.Rows [0] ["PayProofPath"].ToString()));

			_iAdminDet.ImageFile = imgData;
		}

		//--- Load Order Detail
		private void LoadOrderDetail(){
			DataTable dtResult = new DataTable ();
			string strOrderDetail = "";

			dtResult = _cAdminDetModel.RetrieveOrderDetail (this.strOrderID);

			for (int i = 0; i < dtResult.Rows.Count; i++) {
				strOrderDetail += dtResult.Rows [i] ["ProductQty"].ToString () +
				"x (" + dtResult.Rows [i] ["ProductID"].ToString () + ") " +
				dtResult.Rows [i] ["Name"].ToString () + "\n";
			}

			_iAdminDet.OrderDetail = strOrderDetail;
		}

		//--- Update Approval Status
	}
}

