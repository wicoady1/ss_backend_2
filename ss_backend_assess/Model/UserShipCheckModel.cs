//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160819
 * 	Program		:	Model - frmUserShipCheck
 * 	Rev			:
 */
//#########################

using System;
using System.Data;
using Mono.Data.Sqlite;

namespace ss_backend_assess.Model
{
	public class UserShipCheckModel
	{
		private ss_backend_assess.connString _conn;

		public UserShipCheckModel (connString conn)
		{
			this._conn = new connString ();
			this._conn = conn;
		}

		//--- Retrieve Shipment Info by Shipping ID
		public DataTable RetrieveOrderMaster(string strShipmentID){
			string strQuery = 
				"select OrderID, CustName, CustAddress, CustPhone from tblOrderMaster where ShipNo = '"+strShipmentID+"'";


			DataSet dsResult = new DataSet ();

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);

			_conn.sqlDataAdapter = new Mono.Data.Sqlite.SqliteDataAdapter (strQuery, _conn.sqlConn);
			dsResult.Reset ();
			_conn.sqlDataAdapter.Fill (dsResult);
			_conn.sqlConn.Close ();

			return dsResult.Tables [0];
		}
	}
}

