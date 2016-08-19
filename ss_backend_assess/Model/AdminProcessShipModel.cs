//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160819
 * 	Program		:	Model - frmAdminProcessShip
 * 	Rev			:
 */
//#########################


using System;
using System.Data;
using Mono.Data.Sqlite;

namespace ss_backend_assess.Model
{
	public class AdminProcessShipModel
	{
		private ss_backend_assess.connString _conn;

		public AdminProcessShipModel (connString conn)
		{
			this._conn = new connString ();
			this._conn = conn;
		}

		//--- Retrieve Order Detail
		public DataTable RetrieveOrderDetail(string strOrderID){
			string strQuery = "select a.ProductID, b.Name, a.ProductQty " +
				"from tblOrderDetail a " +
				"join tblProductData b on a.ProductID = b.ProductID " +
				"where a.OrderID = '" + strOrderID + "'";
			DataSet dsResult = new DataSet ();

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);

			_conn.sqlDataAdapter = new Mono.Data.Sqlite.SqliteDataAdapter (strQuery, _conn.sqlConn);
			dsResult.Reset ();
			_conn.sqlDataAdapter.Fill (dsResult);
			_conn.sqlConn.Close ();

			return dsResult.Tables [0];
		}

		//--- Update to Shipped + Shipment ID
		public void UpdateShipStatus (string strOrderID, string strShipmentID){
			string strQuery = "update tblOrderMaster set Ship = 'Y', ShipNo = '" + strShipmentID + "' where OrderID = '" + strOrderID + "'";

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);


			_conn.sqlComm.ExecuteNonQuery ();

			_conn.sqlConn.Close ();

		}
	}
}

