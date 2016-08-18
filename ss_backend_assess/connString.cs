//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160817
 * 	Program		:	Connection String Class for DB Connect
 * 	Rev			:
 */
//#########################
using System;
using System.Data;
using Mono.Data.Sqlite;
using Gtk;

namespace ss_backend_assess
{
	public class connString
	{
		private string strConnString;

		public SqliteConnection sqlConn;
		public SqliteCommand sqlComm;
		public SqliteDataReader sqlReader;

		public connString ()
		{
			ConnectionOpen ();
			ConnectionClose ();
		}

		//-- connection string test open
		public void ConnectionOpen()
		{
			strConnString = "Data Source=ss_backend_db.db;Version=3;UseUTF16Encoding=True;";

			try
			{
				sqlConn = new SqliteConnection(strConnString);
				sqlConn.Open();

				//MessageDialog md = new MessageDialog(null,DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Success");
				//md.Run();
				//md.Destroy();
			}
			catch (SqliteException ex)
			{
				MessageDialog md = new MessageDialog(null,DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Failed to Connect DB");
				md.Run();
				md.Destroy();
			}
		}

		//-- connection string test close
		public void ConnectionClose()
		{
			try
			{
				sqlConn.Close();
			}
			catch (SqliteException ex)
			{
				MessageDialog md = new MessageDialog(null,DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Close Fail");
				md.Run();
				md.Destroy();
			}
		}
	}
}

