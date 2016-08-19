//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	Login - Model
 * 	Rev			:
 */
//#########################

using System;
using Mono.Data.Sqlite;
using Gtk;
using System.Data;

namespace ss_backend_assess.Model
{
	public class LoginModel
	{
		private ss_backend_assess.connString _conn;
		
		public LoginModel (connString conn)
		{
			this._conn = new connString ();
			this._conn = conn;
		}


		//--- to verify login
		public string VerifyLogin(string strID, string strPassword){
			string strQuery = 
				"select case  when UserType = 'A' then 1 when UserType = 'U' then 2 end as UserType " +
				"from tblLogin where ID = '" + strID + "' and Pass = '" + strPassword + "'";
			int intResult = 0;

			DataSet dsResult = new DataSet ();

			try{
				_conn.sqlConn.Open ();
				_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);


				_conn.sqlDataAdapter = new Mono.Data.Sqlite.SqliteDataAdapter (strQuery, _conn.sqlConn);
				dsResult.Reset ();
				_conn.sqlDataAdapter.Fill (dsResult);
				_conn.sqlConn.Close ();

				intResult = Convert.ToInt32( dsResult.Tables [0].Rows[0]["UserType"].ToString());

				if (intResult == 1)
					return "A";
				if (intResult == 2)
					return "U";
			}
			catch{
				return "";
			}
			return "";
		}
	}
}

