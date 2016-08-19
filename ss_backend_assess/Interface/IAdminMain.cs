//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160819
 * 	Program		:	Interface - frmAdminMain
 * 	Rev			:
 */
//#########################

using System;
using System.Data;

namespace ss_backend_assess.Interface
{
	public interface IAdminMain
	{
		string SelectedOrderNo {
			get;
		}
		DataTable OrderList {
			set;
		}
	}
}

