using System;
using System.Data;

namespace ss_backend_assess
{
	public class frmUserOrderList: ss_backend_assess.Interface.IUserOrderList
	{
		private connString _connStr;
		private ss_backend_assess.Presenter.UserOrderListPresenter _cPresenter;


		private Gtk.Window window;
		private Gtk.VBox mainVBox;
		private Gtk.Label dummyLabel;
		private Gtk.TreeView orderList;
		private Gtk.Button btnClose;

		public frmUserOrderList ()
		{
			this._connStr = new connString ();
			this._cPresenter = new ss_backend_assess.Presenter.UserOrderListPresenter (this, _connStr);

			BuildInterface ();


		}

		public void BuildInterface(){
			//--- CREATE MAIN WINDOW
			window = new Gtk.Window ("User Order List");
			window.SetSizeRequest (500,200);

			//--- Add Vertical Bar 3
			mainVBox = new Gtk.VBox();

			//--- ADD LABEL: Admin Menu
			dummyLabel = new Gtk.Label("Submitted Order List");

			//--- ADD TREE VIEW: Order List
			orderList = new Gtk.TreeView ();
			this._cPresenter.LoadMasterOrder ();

			//--- ADD SCROLL WINDOW BAR for Tree View
			Gtk.ScrolledWindow scrollWin = new Gtk.ScrolledWindow();
			scrollWin.Add (orderList);

			//--- ADD Button: Process Order
			btnClose = new Gtk.Button ("Close");

			//--- ADD Button Clicked Action
			//btnClose.Clicked += new EventHandler(OnBtnProcessClicked);

			//--- Put Together in VBox
			mainVBox.PackStart (dummyLabel, false, false, 5);
			mainVBox.PackStart (scrollWin, true, true, 5);
			mainVBox.PackStart (btnClose, false, false, 5);

			window.Add (mainVBox);

			// Show the window and everything on it
			window.ShowAll ();
		}

		#region Interface Assignment
		public DataTable OrderList {
			set{
				//OrderID, CustName, CustAddress
				orderList = new Gtk.TreeView();

				// Create a column for the Order ID
				Gtk.TreeViewColumn orderNo = new Gtk.TreeViewColumn ();
				orderNo.Title = "Order No";

				// Create a column for the Customer Name
				Gtk.TreeViewColumn custName = new Gtk.TreeViewColumn ();
				custName.Title = "Customer Name";

				// Create a column for the Order Status
				Gtk.TreeViewColumn custStat = new Gtk.TreeViewColumn ();
				custStat.Title = "Order Status";

				// Create a column for the Ship ID
				Gtk.TreeViewColumn shipID = new Gtk.TreeViewColumn ();
				shipID.Title = "Shipment ID";

				// Add the columns to the TreeView
				orderList.AppendColumn (orderNo);
				orderList.AppendColumn (custName);
				orderList.AppendColumn (custStat);
				orderList.AppendColumn (shipID);

				// Create a model that will hold 4 strings - OrderID, CustName, CustAddress, Shipment ID
				Gtk.ListStore orderListStore = new Gtk.ListStore (typeof (string), typeof (string), typeof (string), typeof (string));

				// Add some data to the store
				for (int i = 0; i < value.Rows.Count; i++) {
					orderListStore.AppendValues (value.Rows [i] ["OrderID"].ToString (),
						value.Rows [i] ["CustName"].ToString (),
						value.Rows [i] ["Status"].ToString (),
						value.Rows [i] ["ShipNo"].ToString ());
				}


				// Create the text cell that will display the value for each column
				Gtk.CellRendererText orderNoCell = new Gtk.CellRendererText ();
				orderNo.PackStart (orderNoCell, true);

				Gtk.CellRendererText custNameCell = new Gtk.CellRendererText ();
				custName.PackStart (custNameCell, true);

				Gtk.CellRendererText custStatCell = new Gtk.CellRendererText ();
				custStat.PackStart (custStatCell, true);

				Gtk.CellRendererText custShipIDCell = new Gtk.CellRendererText ();
				shipID.PackStart (custShipIDCell, true);

				// Tell the Cell Renderers which items in the model to display
				orderNo.AddAttribute (orderNoCell, "text", 0);
				custName.AddAttribute (custNameCell, "text", 1);
				custStat.AddAttribute (custStatCell, "text", 2);
				shipID.AddAttribute (custShipIDCell, "text", 3);

				// Assign the model to the TreeView
				orderList.Model = orderListStore;
			}
		}
		#endregion
	}
}

