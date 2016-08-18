
// This file has been generated by the GUI designer. Do not modify.
namespace ss_backend_assess
{
	public partial class frmConfirmOrder
	{
		private global::Gtk.VBox vbox7;
		
		private global::Gtk.Label label9;
		
		private global::Gtk.VBox vbox8;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TextView txtOrderList;
		
		private global::Gtk.HBox hbox11;
		
		private global::Gtk.Label label10;
		
		private global::Gtk.Entry txtCoupon;
		
		private global::Gtk.Button btnSubmitCoupon;
		
		private global::Gtk.Fixed fixed12;
		
		private global::Gtk.Button btnGoPayment;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ss_backend_assess.frmConfirmOrder
			this.Name = "ss_backend_assess.frmConfirmOrder";
			this.Title = global::Mono.Unix.Catalog.GetString ("frmConfirmOrder");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ss_backend_assess.frmConfirmOrder.Gtk.Container+ContainerChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Order Confirmation");
			this.vbox7.Add (this.label9);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.label9]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.txtOrderList = new global::Gtk.TextView ();
			this.txtOrderList.CanFocus = true;
			this.txtOrderList.Name = "txtOrderList";
			this.txtOrderList.Editable = false;
			this.GtkScrolledWindow.Add (this.txtOrderList);
			this.vbox8.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.GtkScrolledWindow]));
			w3.Position = 0;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox ();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Coupon");
			this.hbox11.Add (this.label10);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.label10]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.txtCoupon = new global::Gtk.Entry ();
			this.txtCoupon.CanFocus = true;
			this.txtCoupon.Name = "txtCoupon";
			this.txtCoupon.IsEditable = true;
			this.txtCoupon.InvisibleChar = '•';
			this.hbox11.Add (this.txtCoupon);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.txtCoupon]));
			w5.Position = 1;
			// Container child hbox11.Gtk.Box+BoxChild
			this.btnSubmitCoupon = new global::Gtk.Button ();
			this.btnSubmitCoupon.CanFocus = true;
			this.btnSubmitCoupon.Name = "btnSubmitCoupon";
			this.btnSubmitCoupon.UseUnderline = true;
			this.btnSubmitCoupon.Label = global::Mono.Unix.Catalog.GetString ("Use Coupon");
			this.hbox11.Add (this.btnSubmitCoupon);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.btnSubmitCoupon]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox8.Add (this.hbox11);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hbox11]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.fixed12 = new global::Gtk.Fixed ();
			this.fixed12.Name = "fixed12";
			this.fixed12.HasWindow = false;
			this.vbox8.Add (this.fixed12);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.fixed12]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox7.Add (this.vbox8);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.vbox8]));
			w9.Position = 1;
			// Container child vbox7.Gtk.Box+BoxChild
			this.btnGoPayment = new global::Gtk.Button ();
			this.btnGoPayment.CanFocus = true;
			this.btnGoPayment.Name = "btnGoPayment";
			this.btnGoPayment.UseUnderline = true;
			this.btnGoPayment.Label = global::Mono.Unix.Catalog.GetString ("Proceed to Payment");
			this.vbox7.Add (this.btnGoPayment);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.btnGoPayment]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			this.Add (this.vbox7);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
			this.btnSubmitCoupon.Clicked += new global::System.EventHandler (this.OnBtnSubmitCouponClicked);
			this.btnGoPayment.Clicked += new global::System.EventHandler (this.OnBtnGoPaymentClicked);
		}
	}
}
