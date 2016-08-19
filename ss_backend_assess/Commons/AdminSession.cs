//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160819
 * 	Program		:	This Class is used as Session Login Admin Variables
 * 	Rev			:
 */
//#########################

using System;

namespace ss_backend_assess.Commons
{
	public static class AdminSession
	{
		public static string strOrderID;

		public static void RefreshSession()
		{
			strOrderID = "";
		}
	}
}

