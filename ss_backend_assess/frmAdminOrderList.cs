using System;
using System.Data;
using Gtk;

namespace ss_backend_assess
{
	public class frmAdminOrderList: ss_backend_assess.Interface.IAdminMain
	{
		private connString _connStr;
		private ss_backend_assess.Presenter.AdminMainPresenter _cPresenter;

		private Gtk.Window window;
		private Gtk.VBox mainVBox;
		private Gtk.Label dummyLabel;
		private Gtk.TreeView orderList;
		private Gtk.Button btnProcess;
		private Gtk.Button btnLogout;

		private string strSelectedOrderID;

		public frmAdminOrderList ()
		{
			this._connStr = new connString ();
			this._cPresenter = new ss_backend_assess.Presenter.AdminMainPresenter (this, _connStr);

			BuildInterface ();

			strSelectedOrderID = "-1";
		}

		public void BuildInterface(){
			//--- CREATE MAIN WINDOW
			window = new Gtk.Window ("Admin: Order Verifier");
			window.SetSizeRequest (500,200);

			//--- Add Vertical Bar 3
			mainVBox = new Gtk.VBox();

			//--- ADD LABEL: Admin Menu
			dummyLabel = new Gtk.Label("Admin Menu");

			//--- ADD TREE VIEW: Order List
			orderList = new Gtk.TreeView ();
			this._cPresenter.LoadPendingOrder ();
			//this.InitializeTree ();

			//--- ADD TREE VIEW: Selection Changed Event
			orderList.CursorChanged += new EventHandler(OnOrderListSelectionChange);

			//--- ADD Button: Process Order
			btnProcess = new Gtk.Button ("Process Order");

			//--- ADD Button Clicked Action
			btnProcess.Clicked += new EventHandler(OnBtnProcessClicked);

			//--- ADD Button: Logout
			btnLogout = new Gtk.Button ("LogOut!");

			//--- ADD Button Clicked Action
			btnLogout.Clicked += new EventHandler(OnBtnLogoutClicked);

			//--- Put Together in VBox
			mainVBox.PackStart (dummyLabel, false, false, 5);
			mainVBox.PackStart (orderList, true, true, 5);
			mainVBox.PackStart (btnProcess, false, false, 5);
			mainVBox.PackStart (btnLogout, false, false, 5);

			window.Add (mainVBox);

			// Show the window and everything on it
			window.ShowAll ();
		}


		private void OnBtnProcessClicked (object sender, EventArgs e)
		{
			if (ss_backend_assess.Commons.AdminSession.strOrderID == "" || ss_backend_assess.Commons.AdminSession.strOrderID == null) {
				MessageBox.ShowMsg ("Please Choose an Order to Process...");
			} else {
				new frmAdminOrderDetail ();
				window.Destroy ();
			}
		}

		private void OnBtnLogoutClicked (object sender, EventArgs e)
		{
			ss_backend_assess.Commons.AdminSession.RefreshSession ();

			new MainWindow ();

			window.Destroy ();
		}


		private void OnOrderListSelectionChange (object sender, EventArgs e)
		{
			Gtk.TreeSelection selection = (sender as Gtk.TreeView).Selection;
			Gtk.TreeModel model;
			Gtk.TreeIter iter;
			string strMessage = "";

			//--- iter will find and point to selected row
			if (selection.GetSelected (out model, out iter)) {
				_cPresenter.SetSelectedOrderID (model.GetValue (iter, 0).ToString ());

				strMessage = "Selected Order ID = " + model.GetValue (iter, 0).ToString ();

				MessageDialog md = new MessageDialog(null,DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, strMessage);
				md.Run();
				md.Destroy();
			}
		}

		#region Interface Assignment
		public string SelectedOrderNo {
			get{
				return strSelectedOrderID;
			}
		}
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

				// Create a column for the Customer Address
				Gtk.TreeViewColumn custAdd = new Gtk.TreeViewColumn ();
				custAdd.Title = "Customer Address";

				// Add the columns to the TreeView
				orderList.AppendColumn (orderNo);
				orderList.AppendColumn (custName);
				orderList.AppendColumn (custAdd);

				// Create a model that will hold 3 strings - OrderID, CustName, CustAddress
				Gtk.ListStore orderListStore = new Gtk.ListStore (typeof (string), typeof (string), typeof (string));

				// Add some data to the store
				for (int i = 0; i < value.Rows.Count; i++) {
					orderListStore.AppendValues (value.Rows [i] ["OrderID"].ToString (),
						value.Rows [i] ["CustName"].ToString (),
						value.Rows [i] ["CustAddress"].ToString ());
				}


				// Create the text cell that will display the value for each column
				Gtk.CellRendererText orderNoCell = new Gtk.CellRendererText ();
				orderNo.PackStart (orderNoCell, true);

				Gtk.CellRendererText custNameCell = new Gtk.CellRendererText ();
				custName.PackStart (custNameCell, true);

				Gtk.CellRendererText custAddCell = new Gtk.CellRendererText ();
				custAdd.PackStart (custAddCell, true);

				// Tell the Cell Renderers which items in the model to display
				orderNo.AddAttribute (orderNoCell, "text", 0);
				custName.AddAttribute (custNameCell, "text", 1);
				custAdd.AddAttribute (custAddCell, "text", 2);

				// Assign the model to the TreeView
				orderList.Model = orderListStore;
			}
		}
		#endregion
	}
}

