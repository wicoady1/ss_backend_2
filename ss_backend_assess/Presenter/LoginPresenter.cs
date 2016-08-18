//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	Login - Presenter
 * 	Rev			:
 */
//#########################
using System;

namespace ss_backend_assess.Presenter
{
	public class LoginPresenter
	{
		private ss_backend_assess.Interface.ILogin _ilogin;
		private ss_backend_assess.Model.LoginModel _cLoginModel;

		public LoginPresenter (ss_backend_assess.Interface.ILogin iLog, connString conStr)
		{
			this._ilogin = iLog;
			this._cLoginModel = new Model.LoginModel (conStr);
		}

		//--login check
		public int LoginVerifier(){
			int intErrCode = -1;

			intErrCode = _cLoginModel.VerifyLogin (_ilogin.ID, _ilogin.Password);

			return intErrCode;
		}
	}
}

