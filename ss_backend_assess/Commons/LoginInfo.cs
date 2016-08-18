//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	This Class is used as Session Login Data Variables
 * 	Rev			:
 */
//#########################

using System;

namespace ss_backend_assess.Commons
{
	public static class LoginInfo
	{
		public static string LoginID;

		public static void RefreshSession ()
		{
			LoginID = "";
		}
	}
}

