
// This file has been generated by the GUI designer. Do not modify.
namespace ss_backend_assess
{
	public partial class frmUserShipCheck
	{
		private global::Gtk.VBox vbox9;
		
		private global::Gtk.Label label13;
		
		private global::Gtk.Entry txtShipID;
		
		private global::Gtk.Button btnCheck;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TextView txtInquiryResult;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ss_backend_assess.frmUserShipCheck
			this.Name = "ss_backend_assess.frmUserShipCheck";
			this.Title = global::Mono.Unix.Catalog.GetString ("Shipment Check");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ss_backend_assess.frmUserShipCheck.Gtk.Container+ContainerChild
			this.vbox9 = new global::Gtk.VBox ();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Please Insert Shipment ID here");
			this.vbox9.Add (this.label13);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.label13]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.txtShipID = new global::Gtk.Entry ();
			this.txtShipID.CanFocus = true;
			this.txtShipID.Name = "txtShipID";
			this.txtShipID.IsEditable = true;
			this.txtShipID.InvisibleChar = '•';
			this.vbox9.Add (this.txtShipID);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.txtShipID]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.btnCheck = new global::Gtk.Button ();
			this.btnCheck.CanFocus = true;
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.UseUnderline = true;
			this.btnCheck.Label = global::Mono.Unix.Catalog.GetString ("Check!");
			this.vbox9.Add (this.btnCheck);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.btnCheck]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.txtInquiryResult = new global::Gtk.TextView ();
			this.txtInquiryResult.CanFocus = true;
			this.txtInquiryResult.Name = "txtInquiryResult";
			this.GtkScrolledWindow.Add (this.txtInquiryResult);
			this.vbox9.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.GtkScrolledWindow]));
			w5.Position = 3;
			this.Add (this.vbox9);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
			this.btnCheck.Clicked += new global::System.EventHandler (this.OnBtnCheckClicked);
		}
	}
}
