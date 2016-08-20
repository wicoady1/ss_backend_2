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
		public static int[] strItemQty;
		public static string strCoupon;
		public static string strOrderID;
		public static string strGrandTotal;

		//-- Reset session variables
		public static void RefreshSession()
		{
			strItemCode = new string[100];
			strItemDesc = new string[100];
			strItemQty = new int[100];
			strCoupon = "";
			strOrderID = "";
			strGrandTotal = "";
		}

		//-- Clear Cart from Session Variables
		public static void ClearCart()
		{
			strItemCode = new string[100];
			strItemDesc = new string[100];
			strItemQty = new int[100];
		}
	}
}

