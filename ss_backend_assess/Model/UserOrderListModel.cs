//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160819
 * 	Program		:	Model - frmUserOrderList
 * 	Rev			:
 */
//#########################


using System;
using System.Data;
using Mono.Data.Sqlite;

namespace ss_backend_assess.Model
{
	public class UserOrderListModel
	{
		private ss_backend_assess.connString _conn;

		public UserOrderListModel (connString conn)
		{
			this._conn = new connString ();
			this._conn = conn;
		}

		//--- Retrieve Order Master (Order Data + Status)
		public DataTable RetrieveOrderMaster(){
			string strQuery = 
				"select OrderID, CustName, case " +
				"when Ship = 'Y' then 'Shipped' " +
				"when AppStatus = 'Y' then 'Order Approved' " +
				"when AppStatus = 'N' then 'Order Rejected' " +
				"when PayProof = 'Y' then 'Order Paid' " +
				"else 'Order Pending' " +
				"	end as Status,  " +
				"case " +
				"when ShipNo = 'X' then '' " +
				"else ShipNo " +
				"	end as ShipNo " +
				"	from tblOrderMaster";


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

