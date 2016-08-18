using System;
using Mono.Data.Sqlite;

namespace ss_backend_assess.Model
{
	public class PaymentRequestModel
	{
		private ss_backend_assess.connString _conn;

		public PaymentRequestModel (connString conn)
		{
			this._conn = new connString ();
			this._conn = conn;
		}

		//--- update Payment Proof flag + Path
		public void PaymentProofUpdate (string strPath, string strOrderID){
			
			string strQuery = "UPDATE tblOrderMaster " +
				"set PayProof = 'Y'," +
				"PayProofPath = '" + strPath + "'" + 
				"where OrderID = " + strOrderID;
			//string strQuery = "update tblCoupon set Qty = Qty - 1 where Code = '?'";

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);

			//_conn.sqlComm.Parameters.Add (strCode);

			_conn.sqlComm.ExecuteNonQuery();

			_conn.sqlConn.Close ();
		}
	}
}

