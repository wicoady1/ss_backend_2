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
			string strUserType = "";

			strUserType = _cLoginModel.VerifyLogin (_ilogin.ID, _ilogin.Password);

			//-- if Login is Admin Privilege
			if (strUserType == "A")
			{
				MessageBox.ShowMsg ("Login Success as Admin");
				return 2;
			}
			//-- if Login is User Level Privilege
			else if (strUserType == "U")
			{
				MessageBox.ShowMsg ("Login Success as User");
				return 0;
			}
			//-- if Login is failed
			else
			{
				MessageBox.ShowMsg ("Login Failed");
				return 1;
			}

		}
	}
}

