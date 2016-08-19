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

