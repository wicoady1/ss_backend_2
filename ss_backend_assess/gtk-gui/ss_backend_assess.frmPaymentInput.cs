
// This file has been generated by the GUI designer. Do not modify.
namespace ss_backend_assess
{
	public partial class frmPaymentInput
	{
		private global::Gtk.VBox vbox9;
		
		private global::Gtk.Label label11;
		
		private global::Gtk.HBox hbox12;
		
		private global::Gtk.Label label12;
		
		private global::Gtk.Entry txtName;
		
		private global::Gtk.HBox hbox13;
		
		private global::Gtk.Label label13;
		
		private global::Gtk.Entry txtPhone;
		
		private global::Gtk.HBox hbox14;
		
		private global::Gtk.Label label14;
		
		private global::Gtk.Entry txtEmail;
		
		private global::Gtk.HBox hbox15;
		
		private global::Gtk.Label label15;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TextView txtAddress;
		
		private global::Gtk.Fixed fixed13;
		
		private global::Gtk.Button btnProceed;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ss_backend_assess.frmPaymentInput
			this.Name = "ss_backend_assess.frmPaymentInput";
			this.Title = global::Mono.Unix.Catalog.GetString ("frmPaymentInput");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ss_backend_assess.frmPaymentInput.Gtk.Container+ContainerChild
			this.vbox9 = new global::Gtk.VBox ();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Please Input Your Data");
			this.vbox9.Add (this.label11);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.label11]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox12 = new global::Gtk.HBox ();
			this.hbox12.Name = "hbox12";
			this.hbox12.Spacing = 6;
			// Container child hbox12.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Name");
			this.hbox12.Add (this.label12);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.label12]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox9.Add (this.hbox12);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox12]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.txtName = new global::Gtk.Entry ();
			this.txtName.CanFocus = true;
			this.txtName.Name = "txtName";
			this.txtName.IsEditable = true;
			this.txtName.InvisibleChar = '•';
			this.vbox9.Add (this.txtName);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.txtName]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox13 = new global::Gtk.HBox ();
			this.hbox13.Name = "hbox13";
			this.hbox13.Spacing = 6;
			// Container child hbox13.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Phone No.");
			this.hbox13.Add (this.label13);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.label13]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox9.Add (this.hbox13);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox13]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.txtPhone = new global::Gtk.Entry ();
			this.txtPhone.CanFocus = true;
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.IsEditable = true;
			this.txtPhone.InvisibleChar = '•';
			this.vbox9.Add (this.txtPhone);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.txtPhone]));
			w7.Position = 4;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox14 = new global::Gtk.HBox ();
			this.hbox14.Name = "hbox14";
			this.hbox14.Spacing = 6;
			// Container child hbox14.Gtk.Box+BoxChild
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("Email");
			this.hbox14.Add (this.label14);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox14 [this.label14]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox9.Add (this.hbox14);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox14]));
			w9.Position = 5;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.txtEmail = new global::Gtk.Entry ();
			this.txtEmail.CanFocus = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.IsEditable = true;
			this.txtEmail.InvisibleChar = '•';
			this.vbox9.Add (this.txtEmail);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.txtEmail]));
			w10.Position = 6;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox15 = new global::Gtk.HBox ();
			this.hbox15.Name = "hbox15";
			this.hbox15.Spacing = 6;
			// Container child hbox15.Gtk.Box+BoxChild
			this.label15 = new global::Gtk.Label ();
			this.label15.Name = "label15";
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("Address");
			this.hbox15.Add (this.label15);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.label15]));
			w11.Position = 0;
			w11.Expand = false;
			this.vbox9.Add (this.hbox15);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox15]));
			w12.Position = 7;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.txtAddress = new global::Gtk.TextView ();
			this.txtAddress.CanFocus = true;
			this.txtAddress.Name = "txtAddress";
			this.GtkScrolledWindow.Add (this.txtAddress);
			this.vbox9.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.GtkScrolledWindow]));
			w14.Position = 8;
			// Container child vbox9.Gtk.Box+BoxChild
			this.fixed13 = new global::Gtk.Fixed ();
			this.fixed13.Name = "fixed13";
			this.fixed13.HasWindow = false;
			this.vbox9.Add (this.fixed13);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.fixed13]));
			w15.Position = 9;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.btnProceed = new global::Gtk.Button ();
			this.btnProceed.CanFocus = true;
			this.btnProceed.Name = "btnProceed";
			this.btnProceed.UseUnderline = true;
			this.btnProceed.Label = global::Mono.Unix.Catalog.GetString ("Continue");
			this.vbox9.Add (this.btnProceed);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.btnProceed]));
			w16.Position = 10;
			w16.Expand = false;
			w16.Fill = false;
			this.Add (this.vbox9);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 330;
			this.Show ();
			this.btnProceed.Clicked += new global::System.EventHandler (this.OnBtnProceedClicked);
		}
	}
}
