//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	Main User - Interface
 * 	Rev			:
 */
//#########################

using System;

namespace ss_backend_assess.Interface
{
	public interface IMainUser
	{
		int CosmeticQty{
			get;
			set;
		}
		int MascaraQty{
			get;
			set;
		}
		int ConditionerQty{
			get;
			set;
		}
	}
}

