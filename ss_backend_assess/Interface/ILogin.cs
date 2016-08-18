//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	Login - Interface
 * 	Rev			:
 */
//#########################

using System;

namespace ss_backend_assess.Interface
{
	public interface ILogin
	{
		string ID {
			get;
			set;
		}
		string Password {
			get;
			set;
		}
	}
}

