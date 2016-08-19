//########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160819
 * 	Program		:	Interface - frmAdminProcessShip
 * 	Rev			:
 */
//#########################

using System;

namespace ss_backend_assess.Interface
{
	public interface IAdminProcessShip
	{
		string OrderDetail {set;}
		string ShipStatus {get; }
		string ShipID {get; set;}
	}
}

