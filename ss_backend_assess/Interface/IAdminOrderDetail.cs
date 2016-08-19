using System;

namespace ss_backend_assess.Interface
{
	public interface IAdminOrderDetail
	{
		string OrderTitle { set; }
		string OrderDetail { get; set; }
		string CustName {get;set;}
		string CustPhone { get; set; }
		string CustEmail {get; set;}
		string CustAdd {get; set;}
		Gdk.Pixbuf ImageFile {set;}
	}
}

