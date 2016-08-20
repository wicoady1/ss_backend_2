//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160818
 * 	Program		:	Presenter - frmConfirmOrder
 * 	Rev			:
 */
//#########################

using System;
using System.Data;
using System.Xml;
using Gtk;

namespace ss_backend_assess.Presenter
{
	public class ConfirmOrderPresenter
	{
		private ss_backend_assess.Interface.IConfirmOrder _iConOrder;
		private ss_backend_assess.Model.ConfirmOrderModel _cConOrderModel;

		private string strTotalOrder = "";
		private int intPrice = 0;
		private int intTotalPrice = 0;
		private int intGrandTotal = 0;

		public ConfirmOrderPresenter (ss_backend_assess.Interface.IConfirmOrder iLog, connString conStr)
		{
			this._iConOrder = iLog;
			this._cConOrderModel = new Model.ConfirmOrderModel (conStr);
		}

		//---Calculate order (+coupon if any)
		public void CalculateOrder(){
			strTotalOrder = "";
			intPrice = 0;
			intTotalPrice = 0;
			intGrandTotal = 0;

			// iterate Cart's item
			for (int i = 0; i < ss_backend_assess.Commons.Cart.strItemCode.Length; i++) {
				intPrice = 0;
				intTotalPrice = 0;

				if (ss_backend_assess.Commons.Cart.strItemCode [i] == null) {
					
					break;
				} else {
					intPrice = _cConOrderModel.CheckItemPrice (ss_backend_assess.Commons.Cart.strItemCode [i]);
					intTotalPrice = intPrice * ss_backend_assess.Commons.Cart.strItemQty [i];

					strTotalOrder += ss_backend_assess.Commons.Cart.strItemDesc [i];
					strTotalOrder += "    x " + ss_backend_assess.Commons.Cart.strItemQty [i];
					strTotalOrder += " @ " + intPrice.ToString() + " IDR";
					strTotalOrder += "  = " + intTotalPrice + " IDR";
					strTotalOrder += "\n";

					intGrandTotal += intTotalPrice;
				}


			}

			//--- calculate grand total
			strTotalOrder += "---------------------------------------------------------\n";
			strTotalOrder += "GRAND TOTAL --------------- " + intGrandTotal + " IDR";

			_iConOrder.OrderList = strTotalOrder;
		}
			
		//--- check if the Items are still available on warehouse
		public bool ItemValid(){
			int intStorageQty = 0;
			string strWarningMsg = "";

			// iterate Cart's item
			for (int i = 0; i < ss_backend_assess.Commons.Cart.strItemCode.Length; i++) {
				
				if (ss_backend_assess.Commons.Cart.strItemCode [i] == null) {

					break;
				} else {
					
					intStorageQty = _cConOrderModel.CheckItemStock (ss_backend_assess.Commons.Cart.strItemCode [i]);

					if (ss_backend_assess.Commons.Cart.strItemQty [i] > intStorageQty) {
						strWarningMsg = "You can't proceed the order because " +
								ss_backend_assess.Commons.Cart.strItemDesc [i] +
								" has insufficient stocks in Warehouse.\n Please Order Different Product...";

						MessageDialog md = new MessageDialog(null,DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, strWarningMsg);
						md.Run();
						md.Destroy();

						return false;
					}
				}
			}
			return true;
		}

		//--- Process and Submit Order by cutting the stock of coupon and products
		public void SubmitOrder(){
			//--- Save Grand Total to Session
			ss_backend_assess.Commons.Cart.strGrandTotal = intGrandTotal.ToString ();

			//--- Cut Item Stock
			for (int i = 0; i < ss_backend_assess.Commons.Cart.strItemCode.Length; i++) {
				if (ss_backend_assess.Commons.Cart.strItemCode [i] == null) {
					break;
				} else {

					_cConOrderModel.CutItemStock (ss_backend_assess.Commons.Cart.strItemCode [i],
						ss_backend_assess.Commons.Cart.strItemQty [i]);
				}
			}

			//--- Cut Coupon Stock
			if (_iConOrder.DisableCouponField == false) {
				_cConOrderModel.CutCouponStock (_iConOrder.CouponCode);
			}
		}

		//--- use Coupon
		public void UseCoupon(){
			int intNewGrandTotal = 0;
			double intDiscount = 0;
			bool boolValidCoupon = CouponValidity();
			DataTable dtResult = new DataTable ();


			dtResult = (DataTable) _cConOrderModel.CheckCouponCode (_iConOrder.CouponCode);

			//-- If coupon is valid
			if (boolValidCoupon) {
				//-- recalculate GRAND TOTAL + ADD DESC OF COUPON

				//-- If Coupon is Percent cut
				if (dtResult.Rows [0] ["DiscType"].ToString () == "P")
				{
					intDiscount = Convert.ToInt32 (dtResult.Rows [0] ["PercentCut"].ToString ());
					intNewGrandTotal = intGrandTotal - (Convert.ToInt32(intDiscount) * intGrandTotal / 100);

					strTotalOrder += "\n---------------------------------------------------------\n";
					strTotalOrder += "  VOUCHER DISCOUNT  " + intDiscount + "%\n";
					strTotalOrder += "---------------------------------------------------------\n";
					strTotalOrder += "GRAND TOTAL --------------- " + intNewGrandTotal + " IDR";
				}
				//-- If Coupon is Nominal cut
				else if (dtResult.Rows [0] ["DiscType"].ToString () == "N")
				{
					intDiscount = Convert.ToInt32 (dtResult.Rows [0] ["NominalCut"].ToString ()) ;
					intNewGrandTotal = intGrandTotal - Convert.ToInt32(intDiscount);

					if (intNewGrandTotal < 0)
						intNewGrandTotal = 0;

					strTotalOrder += "\n---------------------------------------------------------\n";
					strTotalOrder += "  VOUCHER DISCOUNT  " + intDiscount + " IDR\n";
					strTotalOrder += "---------------------------------------------------------\n";
					strTotalOrder += "GRAND TOTAL --------------- " + intNewGrandTotal + " IDR";
				}

				intGrandTotal = intNewGrandTotal;
				_iConOrder.DisableCouponField = false;
				_iConOrder.OrderList = strTotalOrder;
			}


		}

		//---Verify the coupon is okay to used or not?
		public bool CouponValidity(){
			DataTable dtResult = new DataTable ();
			string strValidString = "";
			int intCouponQty = 0;

			dtResult = (DataTable) _cConOrderModel.CheckCouponCode (_iConOrder.CouponCode);

			//-- if coupon is not exists
			if (dtResult.Rows.Count == 0) {
				MessageBox.ShowMsg ("Invalid Coupon. Please Try Again!");
				return false;
			}

			strValidString = dtResult.Rows [0] ["ExpiryDate"].ToString ();

			//--date is valid?
			DateTime dtValidity = new DateTime(Convert.ToInt32(strValidString.Substring(0,4)),
				Convert.ToInt32(strValidString.Substring(4,2)),
				Convert.ToInt32(strValidString.Substring(6,2)));

			//--qty is valid?
			intCouponQty = Convert.ToInt32(dtResult.Rows [0] ["Qty"].ToString ());

			//--if valid + qty > 0
			if (DateTime.Now <= dtValidity && intCouponQty > 0) {
				MessageDialog md = new MessageDialog(null,DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Coupon Valid until " + dtValidity);
				md.Run();
				md.Destroy();
			} 
			//--if valid but qty <= 0
			else if (intCouponQty <= 0) {
				MessageDialog md = new MessageDialog(null,DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Coupon is not Valid Anymore");
				md.Run();
				md.Destroy();

				return false;
			}
			//-- neither is valid (expired + empty)
			else {
				MessageDialog md = new MessageDialog(null,DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Coupon has Expired!");
				md.Run();
				md.Destroy();

				return false;
			}

			return true;
		}

	}
}

