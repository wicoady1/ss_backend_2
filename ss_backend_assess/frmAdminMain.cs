//#########################
/*
 * 	Name		:	Kennard Wicoady
 * 	Date		:	20160819
 * 	Program		:	NOT USED -- Class reserved for compiling (changed to frmAdminOrderList)
 * 	Rev			:
 */
//#########################

using System;
using System.Data;
using Gtk;

namespace ss_backend_assess
{
	public partial class frmAdminMain : Gtk.Window//, ss_backend_assess.Interface.IAdminMain
	{
		public frmAdminMain () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();

			AddTree ();
		}

		ListStore SetupModel( TreeView tv){
			var m = new ListStore (typeof(string), typeof(string));

			var nameCol = new TreeViewColumn ("Name", new CellRendererText (), "text", 0);
			tv.AppendColumn (nameCol);

			var colorCol = new TreeViewColumn ("Color", new CellRendererText (), "text", 1);
			tv.AppendColumn (colorCol);

			tv.Model = m;
			return m;
		}

		void PopulateData( ListStore model){
			model.AppendValues ("test 1", "test 2");
			model.AppendValues ("test 3", "test 4");
			model.AppendValues ("test 5", "test 6");
		}

		void AddTree(){
			Gtk.TreeView tree = new Gtk.TreeView ();

			// Add our tree to the window
			this.Add (tree);

			// Create a column for the artist name
			Gtk.TreeViewColumn artistColumn = new Gtk.TreeViewColumn ();
			artistColumn.Title = "Artist";

			// Create a column for the song title
			Gtk.TreeViewColumn songColumn = new Gtk.TreeViewColumn ();
			songColumn.Title = "Song Title";

			// Add the columns to the TreeView
			tree.AppendColumn (artistColumn);
			tree.AppendColumn (songColumn);

			// Create a model that will hold two strings - Artist Name and Song Title
			Gtk.ListStore musicListStore = new Gtk.ListStore (typeof (string), typeof (string));


			// Assign the model to the TreeView
			tree.Model = musicListStore;

			// Show the window and everything on it
			this.ShowAll ();
		}

		/*
		private void InitialNodeOrder(){
			
			nodeOrderList.AppendColumn ("Artist", new Gtk.CellRendererText (), "text", 0);
			nodeOrderList.AppendColumn ("Song Title", new Gtk.CellRendererText (), "text", 1);

			nodeOrderList.ShowAll ();

			Gtk.NodeStore store = new Gtk.NodeStore (typeof(MyTreeNode));
			store.AddNode(new MyTreeNode ("Test1","test2"));
			store.AddNode(new MyTreeNode ("Test3","test5"));
			store.AddNode(new MyTreeNode ("Test4","test5"));

			nodeOrderList = new Gtk.NodeView (store);


			/*
			Gtk.NodeStore store;
			Gtk.NodeStore Store {
				get{
					if (store == null){
						store = new Gtk.NodeStore (typeof(ss_backend_assess.TreeNode));
						store.AddNode(new TreeNode ("Test1","test2"));
						store.AddNode(new TreeNode ("Test3","test5"));
						store.AddNode(new TreeNode ("Test4","test5"));
					}

					return store;
				}
			}

		}
		*/

		#region Interface Assignment

		protected void OnBtnOrderCheckClicked (object sender, EventArgs e)
		{
			Gtk.TreeView tree = new Gtk.TreeView ();
			tvOrder.Model = SetupModel (tree);

			this.ShowAll ();

			//PopulateData (tvOrder.Model);

			/*
			var nameCol = new TreeViewColumn ("Name", new CellRendererText (), "text", 0);
			tree.AppendColumn (nameCol);

			var colorCol = new TreeViewColumn ("Color", new CellRendererText (), "text", 1);
			tree.AppendColumn (colorCol);

			this.tvOrder = tree;
			*/
			//this.tvOrder.ShowAll ();
			//throw new NotImplementedException ();
		}
		/*
		public string SelectedOrderNo {
			get;
			set;
		}
		public DataTable OrderList {
			get{
			
			}
			set{
				


			}
		}
		*/
		#endregion
	}
}

