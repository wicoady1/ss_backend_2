//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	Presenter - frmPaymentInputPresenter
 * 	Rev			:
 */
//#########################

using System;

namespace ss_backend_assess.Presenter
{
	public class PaymentInputPresenter
	{
		private ss_backend_assess.Interface.IPaymentInput _iPayIn;
		private ss_backend_assess.Model.PaymentInputModel _cPayInputModel;

		private int intOrderID;

		public PaymentInputPresenter (ss_backend_assess.Interface.IPaymentInput iPayIn, connString conStr)
		{
			this._iPayIn = iPayIn;
			this._cPayInputModel = new Model.PaymentInputModel (conStr);

			this.intOrderID = 0;
		}

		//--- Input Validation
		//--- nanti dulu, kelarin dulu semua modul
		public bool DataValidation(){
			if (_iPayIn.CustName == null || _iPayIn.CustName == "") {
				return false;
			}
			if (_iPayIn.Address == null || _iPayIn.Address == "") {
				return false;
			}
			if (_iPayIn.Email == null || _iPayIn.Email == "") {
				return false;
			}
			if (_iPayIn.PhoneNo == null || _iPayIn.PhoneNo == "") {
				return false;
			}
			return true;
		}

		//--- Insert Customer Data
		public void InsertCustomerData(){

			//-- insert Master Data
			intOrderID = this._cPayInputModel.InputCustomerDetail (_iPayIn.CustName,
				_iPayIn.PhoneNo,
				_iPayIn.Email,
				_iPayIn.Address);

			ss_backend_assess.Commons.Cart.strOrderID = intOrderID.ToString ();

			//-- insert Order Detail Data
			for (int i = 0; i < ss_backend_assess.Commons.Cart.strItemCode.Length; i++) {
				if (ss_backend_assess.Commons.Cart.strItemCode [i] == null) {
					
					break;
				} else {
					this._cPayInputModel.InputCustomerOrder (intOrderID.ToString(),
						ss_backend_assess.Commons.Cart.strItemCode [i],
						ss_backend_assess.Commons.Cart.strItemQty [i]);
				}


			}

		}
	}
}

