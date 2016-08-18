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

		//--to verify login
		public int VerifyLogin(string strID, string strPassword){
			int intReturnValue = -1;
			string strQuery = "select * from tblLogin where ID = '" + strID + "' and Pass = '" + strPassword + "'";

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);
			_conn.sqlReader = _conn.sqlComm.ExecuteReader ();

			if (_conn.sqlReader.HasRows) {
				MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Login Success!");
				md.Run ();
				md.Destroy ();

				if (strID == "user") {
					intReturnValue = 0;
				}else if (strID == "admin"){
					intReturnValue = 2;
				}

				//intReturnValue = 0;
			} else {
				MessageDialog md = new MessageDialog(null,DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Login Failed!");
				md.Run();
				md.Destroy();

				intReturnValue = 1;
			}

			_conn.sqlConn.Close ();

			return intReturnValue;
		}
	}
}

