using System;

namespace ss_backend_assess.Interface
{
	public interface IUserShipCheck
	{
		string ShipmentID { get; }
		string ShipmentStatus {set;}
	}
}

