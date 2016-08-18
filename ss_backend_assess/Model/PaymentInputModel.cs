using System;
using System.Data;
using Mono.Data.Sqlite;
using System.Xml;

namespace ss_backend_assess.Model
{
	public class PaymentInputModel
	{
		private ss_backend_assess.connString _conn;

		public PaymentInputModel (connString conn)
		{
			this._conn = new connString ();
			this._conn = conn;
		}

		//--- Get Latest Order ID
		public int LatestOrderID (){
			string strQuery = "select max(OrderID) from tblOrderMaster";
			DataSet dsResult = new DataSet ();

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);
			//_conn.sqlReader = _conn.sqlComm.ExecuteReader ();

			_conn.sqlDataAdapter = new Mono.Data.Sqlite.SqliteDataAdapter (strQuery, _conn.sqlConn);
			dsResult.Reset ();
			_conn.sqlDataAdapter.Fill (dsResult);
			_conn.sqlConn.Close ();

			if (dsResult.Tables [0].Rows [0] [0] == null) {
				return 0;
			} else {
				try{
					return Convert.ToInt32 (dsResult.Tables [0].Rows [0] [0].ToString ());
				}
				catch{
					return 0;
				}
			}
		}

		//--- Get Latest Detail Order ID
		public int LatestOrderDetailID (){
			string strQuery = "select max(OrderDetailID) from tblOrderDetail";
			DataSet dsResult = new DataSet ();

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);
			//_conn.sqlReader = _conn.sqlComm.ExecuteReader ();

			_conn.sqlDataAdapter = new Mono.Data.Sqlite.SqliteDataAdapter (strQuery, _conn.sqlConn);
			dsResult.Reset ();
			_conn.sqlDataAdapter.Fill (dsResult);
			_conn.sqlConn.Close ();

			if (dsResult.Tables [0].Rows [0] [0] == null) {
				return 0;
			} else {
				try{
					return Convert.ToInt32 (dsResult.Tables [0].Rows [0] [0].ToString ());
				}
				catch{
					return 0;
				}
			}
		}

		//--- Input Customer Detail
		public int InputCustomerDetail (string strName, string strPhone, string strEmail, string strAddress){
			int intLatestOrderID = this.LatestOrderID () + 1;
			string strQuery = "INSERT INTO tblOrderMaster (OrderID, CustName, CustPhone, CustEmail, CustAddress, AppStatus, Ship, ShipNo, PayProof, PayProofPath)" +
				"VALUES ("+intLatestOrderID+",'"+strName+"','"+strPhone+"','"+strEmail+"','"+strAddress+"','X','X','X','X','X')";

			//string strQuery = "update tblCoupon set Qty = Qty - 1 where Code = '?'";

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);

			//_conn.sqlComm.Parameters.Add (strCode);

			_conn.sqlComm.ExecuteNonQuery();

			_conn.sqlConn.Close ();

			//--- Continue to Input Customer Order
			//this.InputCustomerOrder(intLatestOrderID);
			return intLatestOrderID;
		}

		//--- Input Customer Order
		public void InputCustomerOrder(string strOrderID, string strProdID, int intQty){
			int intLatestOrderID = this.LatestOrderDetailID () + 1;
			string strQuery = "INSERT INTO tblOrderDetail (OrderDetailID, OrderID, ProductID, ProductQty)" +
			                  "VALUES (" + intLatestOrderID + ", '" + strOrderID + "', '" + strProdID + "', " + intQty.ToString () + ")";
			//string strQuery = "update tblCoupon set Qty = Qty - 1 where Code = '?'";

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);

			//_conn.sqlComm.Parameters.Add (strCode);

			_conn.sqlComm.ExecuteNonQuery();

			_conn.sqlConn.Close ();
		}
	}
}

