//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160819
 * 	Program		:	Static Class for Message Dialog --> Message Box
 * 	Rev			:
 */
//#########################

using System;
using Gtk;

namespace ss_backend_assess
{
	public static class MessageBox
	{
		
		public static void ShowMsg(string strMessage){
			MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, strMessage);
			md.Run ();
			md.Destroy ();
		}
	}
}

