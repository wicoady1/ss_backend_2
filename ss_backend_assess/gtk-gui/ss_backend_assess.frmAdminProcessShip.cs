
// This file has been generated by the GUI designer. Do not modify.
namespace ss_backend_assess
{
	public partial class frmAdminProcessShip
	{
		private global::Gtk.VBox vbox7;
		
		private global::Gtk.Label lblOrderID;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TextView txtListBarang;
		
		private global::Gtk.VBox vbox8;
		
		private global::Gtk.CheckButton chkShipped;
		
		private global::Gtk.Label label9;
		
		private global::Gtk.Entry txtShippingID;
		
		private global::Gtk.Button btnUpdateShip;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ss_backend_assess.frmAdminProcessShip
			this.Name = "ss_backend_assess.frmAdminProcessShip";
			this.Title = global::Mono.Unix.Catalog.GetString ("frmAdminProcessShip");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ss_backend_assess.frmAdminProcessShip.Gtk.Container+ContainerChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.lblOrderID = new global::Gtk.Label ();
			this.lblOrderID.Name = "lblOrderID";
			this.lblOrderID.LabelProp = global::Mono.Unix.Catalog.GetString ("Ship Order ID: -");
			this.vbox7.Add (this.lblOrderID);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.lblOrderID]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.txtListBarang = new global::Gtk.TextView ();
			this.txtListBarang.CanFocus = true;
			this.txtListBarang.Name = "txtListBarang";
			this.GtkScrolledWindow.Add (this.txtListBarang);
			this.vbox7.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.GtkScrolledWindow]));
			w3.Position = 1;
			// Container child vbox7.Gtk.Box+BoxChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.chkShipped = new global::Gtk.CheckButton ();
			this.chkShipped.CanFocus = true;
			this.chkShipped.Name = "chkShipped";
			this.chkShipped.Label = global::Mono.Unix.Catalog.GetString ("Shipped?");
			this.chkShipped.DrawIndicator = true;
			this.chkShipped.UseUnderline = true;
			this.vbox8.Add (this.chkShipped);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.chkShipped]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 0F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Ship ID:");
			this.vbox8.Add (this.label9);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.label9]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.txtShippingID = new global::Gtk.Entry ();
			this.txtShippingID.CanFocus = true;
			this.txtShippingID.Name = "txtShippingID";
			this.txtShippingID.IsEditable = true;
			this.txtShippingID.InvisibleChar = '•';
			this.vbox8.Add (this.txtShippingID);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.txtShippingID]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.btnUpdateShip = new global::Gtk.Button ();
			this.btnUpdateShip.CanFocus = true;
			this.btnUpdateShip.Name = "btnUpdateShip";
			this.btnUpdateShip.UseUnderline = true;
			this.btnUpdateShip.Label = global::Mono.Unix.Catalog.GetString ("Update to Shipped!");
			this.vbox8.Add (this.btnUpdateShip);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.btnUpdateShip]));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox7.Add (this.vbox8);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.vbox8]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			this.Add (this.vbox7);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
			this.btnUpdateShip.Clicked += new global::System.EventHandler (this.OnBtnUpdateShipClicked);
		}
	}
}
