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
			//_conn.sqlReader = _conn.sqlComm.ExecuteReader ();

			_conn.sqlDataAdapter = new Mono.Data.Sqlite.SqliteDataAdapter (strQuery, _conn.sqlConn);
			dsResult.Reset ();
			_conn.sqlDataAdapter.Fill (dsResult);
			_conn.sqlConn.Close ();

			return dsResult.Tables [0];
		}

		//--- Update to Shipped + Shipment ID
		public void UpdateShipStatus (string strOrderID, string strShipmentID){
			string strQuery = "update tblOrderMaster set Ship = 'Y', ShipNo = '" + strShipmentID + "' where OrderID = '" + strOrderID + "'";
			//string strQuery = "update tblProductData set Stock = Stock - @intQty where ProductID = '@strCode'";

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);

			//_conn.sqlComm.CommandText = "update tblProductData set Stock = Stock - @intQty where ProductID = '@strCode'";
			//_conn.sqlComm.Parameters.AddWithValue ("@intQty", intQty);
			//_conn.sqlComm.Parameters.AddWithValue ("@strCode", strCode);
			//_conn.sqlComm.Parameters.Add (intQty.ToString());
			//_conn.sqlComm.Parameters.Add (strCode);

			_conn.sqlComm.ExecuteNonQuery ();

			_conn.sqlConn.Close ();

		}
	}
}

