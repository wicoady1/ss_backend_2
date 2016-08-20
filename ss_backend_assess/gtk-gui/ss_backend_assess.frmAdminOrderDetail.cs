
// This file has been generated by the GUI designer. Do not modify.
namespace ss_backend_assess
{
	public partial class frmAdminOrderDetail
	{
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.Label lblOrderID;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TextView txtOrderList;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.VBox vbox4;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Entry txtName;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Entry txtPhone;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Entry txtEmail;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		
		private global::Gtk.TextView txtAddress;
		
		private global::Gtk.Label label7;
		
		private global::Gtk.Image imgPayProof;
		
		private global::Gtk.VBox vbox5;
		
		private global::Gtk.Button btnApprove;
		
		private global::Gtk.Button btnReject;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ss_backend_assess.frmAdminOrderDetail
			this.Name = "ss_backend_assess.frmAdminOrderDetail";
			this.Title = global::Mono.Unix.Catalog.GetString ("Order Approval");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ss_backend_assess.frmAdminOrderDetail.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.lblOrderID = new global::Gtk.Label ();
			this.lblOrderID.Name = "lblOrderID";
			this.lblOrderID.LabelProp = global::Mono.Unix.Catalog.GetString ("Order ID: - ");
			this.vbox3.Add (this.lblOrderID);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.lblOrderID]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.txtOrderList = new global::Gtk.TextView ();
			this.txtOrderList.CanFocus = true;
			this.txtOrderList.Name = "txtOrderList";
			this.GtkScrolledWindow.Add (this.txtOrderList);
			this.vbox3.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow]));
			w3.Position = 1;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Name");
			this.vbox4.Add (this.label3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label3]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.txtName = new global::Gtk.Entry ();
			this.txtName.CanFocus = true;
			this.txtName.Name = "txtName";
			this.txtName.IsEditable = true;
			this.txtName.InvisibleChar = '•';
			this.vbox4.Add (this.txtName);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.txtName]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Phone No");
			this.vbox4.Add (this.label4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label4]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.txtPhone = new global::Gtk.Entry ();
			this.txtPhone.CanFocus = true;
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.IsEditable = true;
			this.txtPhone.InvisibleChar = '•';
			this.vbox4.Add (this.txtPhone);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.txtPhone]));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Email");
			this.vbox4.Add (this.label5);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label5]));
			w8.Position = 4;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.txtEmail = new global::Gtk.Entry ();
			this.txtEmail.CanFocus = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.IsEditable = true;
			this.txtEmail.InvisibleChar = '•';
			this.vbox4.Add (this.txtEmail);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.txtEmail]));
			w9.Position = 5;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Address");
			this.vbox4.Add (this.label6);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label6]));
			w10.Position = 6;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.txtAddress = new global::Gtk.TextView ();
			this.txtAddress.CanFocus = true;
			this.txtAddress.Name = "txtAddress";
			this.GtkScrolledWindow1.Add (this.txtAddress);
			this.vbox4.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.GtkScrolledWindow1]));
			w12.Position = 7;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Payment Proof");
			this.vbox4.Add (this.label7);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label7]));
			w13.Position = 8;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.imgPayProof = new global::Gtk.Image ();
			this.imgPayProof.Name = "imgPayProof";
			this.vbox4.Add (this.imgPayProof);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.imgPayProof]));
			w14.Position = 9;
			w14.Expand = false;
			w14.Fill = false;
			this.hbox1.Add (this.vbox4);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox4]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.btnApprove = new global::Gtk.Button ();
			this.btnApprove.CanFocus = true;
			this.btnApprove.Name = "btnApprove";
			this.btnApprove.UseUnderline = true;
			this.btnApprove.Label = global::Mono.Unix.Catalog.GetString ("Approve (Proceed to Shipment)");
			this.vbox5.Add (this.btnApprove);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.btnApprove]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.btnReject = new global::Gtk.Button ();
			this.btnReject.CanFocus = true;
			this.btnReject.Name = "btnReject";
			this.btnReject.UseUnderline = true;
			this.btnReject.Label = global::Mono.Unix.Catalog.GetString ("Cancel (Reject Order)");
			this.vbox5.Add (this.btnReject);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.btnReject]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.hbox1.Add (this.vbox5);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox5]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			this.vbox3.Add (this.hbox1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 447;
			this.Show ();
			this.btnApprove.Clicked += new global::System.EventHandler (this.OnBtnApproveClicked);
			this.btnReject.Clicked += new global::System.EventHandler (this.OnBtnRejectClicked);
		}
	}
}
