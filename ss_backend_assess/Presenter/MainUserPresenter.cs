//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	Main User - Presenter
 * 	Rev			:
 */
//#########################


using System;
using Gtk;

namespace ss_backend_assess.Presenter
{
	public class MainUserPresenter
	{
		private ss_backend_assess.Interface.IMainUser _iMain;
		private ss_backend_assess.Model.MainUserModel _cMainUserModel;

		public MainUserPresenter (ss_backend_assess.Interface.IMainUser iMain, connString conStr)
		{
			this._iMain = iMain;
			this._cMainUserModel = new Model.MainUserModel (conStr);
		}

		//---Add Item to Cart
		public void AddItemToCart(string strItemID, string strItemName, string strQty){
			int intAddIndex = -1;
			int intLastIndex = 0;
			int intQty = 0;
			bool boolParseResult = Int32.TryParse (strQty, out intQty);

			if (!boolParseResult) {
				MessageDialog md = new MessageDialog(null,DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, strItemName + " has incorrect quantity!");
				md.Run();
				md.Destroy();

				return;
			}

			for (int i = 0; i < ss_backend_assess.Commons.Cart.strItemCode.Length; i++) {
				if (ss_backend_assess.Commons.Cart.strItemCode[i] == null) {
					intLastIndex = i;
					break;
				}

				if (ss_backend_assess.Commons.Cart.strItemCode[i] == strItemID) {
					intAddIndex = i;
				}
			}

			if (intAddIndex != -1) {
				ss_backend_assess.Commons.Cart.strItemQty [intAddIndex] += intQty;
			} else {
				//intLastIndex = ss_backend_assess.Commons.Cart.strItemQty.Length;

				ss_backend_assess.Commons.Cart.strItemCode [intLastIndex] = strItemID;
				ss_backend_assess.Commons.Cart.strItemDesc [intLastIndex] = strItemName;
				ss_backend_assess.Commons.Cart.strItemQty[intLastIndex] = intQty;
			}

			MessageDialog mdSuccess = new MessageDialog(null,DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, strItemName + " x" + strQty + " has been added to Cart!");
			mdSuccess.Run();
			mdSuccess.Destroy();
		}
	}
}

