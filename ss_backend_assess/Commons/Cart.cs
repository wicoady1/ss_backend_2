//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	This Class is used as Session Login Cart / Order Variables
 * 	Rev			:
 */
//#########################

using System;

namespace ss_backend_assess.Commons
{
	public static class Cart
	{
		public static string[] strItemCode;
		public static string[] strItemDesc;
		public static string[] strItemQty;

		public static void RefreshSession()
		{
			strItemCode = new string[100];
			strItemDesc = new string[100];
			strItemQty = new string[100];
		}

	}
}

