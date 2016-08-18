//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	Main User - Model
 * 	Rev			:
 */
//#########################

using System;

namespace ss_backend_assess.Model
{
	public class MainUserModel
	{
		private ss_backend_assess.connString _conn;

		public MainUserModel (connString conn)
		{
			this._conn = new connString ();
			this._conn = conn;
		}

		//-- Inquiry Qty Left
		public int QtyLeft(){
			return 0;
		}
	}
}

