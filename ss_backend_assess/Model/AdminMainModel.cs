//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160819
 * 	Program		:	Model - frmAdminMain
 * 	Rev			:
 */
//#########################

using System;
using System.Data;
using Mono.Data.Sqlite;

namespace ss_backend_assess.Model
{
	public class AdminMainModel
	{
		private ss_backend_assess.connString _conn;

		public AdminMainModel (connString conn)
		{
			this._conn = new connString ();
			this._conn = conn;
		}

		//--- Retrieve All Pending Order to Admin
		public DataTable RetrievePendingOrder(){
			string strQuery = "select OrderID, CustName, CustAddress from tblOrderMaster where PayProof = 'Y' and AppStatus = 'X'";
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

