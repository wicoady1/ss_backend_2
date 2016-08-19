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

