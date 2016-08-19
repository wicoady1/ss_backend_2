//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	Model - frmPaymentRequest
 * 	Rev			:
 */
//#########################


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

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);


			_conn.sqlComm.ExecuteNonQuery();

			_conn.sqlConn.Close ();
		}
	}
}

