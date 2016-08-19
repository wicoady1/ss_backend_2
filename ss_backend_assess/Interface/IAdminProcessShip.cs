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

