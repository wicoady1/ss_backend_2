
// This file has been generated by the GUI designer. Do not modify.
namespace ss_backend_assess
{
	public partial class frmMainUser
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Fixed fixed5;
		
		private global::Gtk.Button btnCart;
		
		private global::Gtk.Fixed fixed9;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Fixed fixed7;
		
		private global::Gtk.Fixed fixed8;
		
		private global::Gtk.Button btnOrderStatus;
		
		private global::Gtk.Button btnShipStatus;
		
		private global::Gtk.Fixed fixed10;
		
		private global::Gtk.HBox hbox6;
		
		private global::Gtk.VBox vbox4;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.VBox vbox5;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Label label7;
		
		private global::Gtk.VBox vbox6;
		
		private global::Gtk.HBox hbox7;
		
		private global::Gtk.Entry txtCosQty;
		
		private global::Gtk.Button btnCosAdd;
		
		private global::Gtk.HBox hbox8;
		
		private global::Gtk.Entry txtMasQty;
		
		private global::Gtk.Button btnMascara;
		
		private global::Gtk.HBox hbox9;
		
		private global::Gtk.Entry txtConQty;
		
		private global::Gtk.Button btnConditioner;
		
		private global::Gtk.Fixed fixed11;
		
		private global::Gtk.HBox hbox10;
		
		private global::Gtk.Button btnCheckOut;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ss_backend_assess.frmMainUser
			this.Name = "ss_backend_assess.frmMainUser";
			this.Title = global::Mono.Unix.Catalog.GetString ("frmMainUser");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ss_backend_assess.frmMainUser.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.fixed5 = new global::Gtk.Fixed ();
			this.fixed5.Name = "fixed5";
			this.fixed5.HasWindow = false;
			this.hbox1.Add (this.fixed5);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.fixed5]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnCart = new global::Gtk.Button ();
			this.btnCart.CanFocus = true;
			this.btnCart.Name = "btnCart";
			this.btnCart.UseUnderline = true;
			this.btnCart.Label = global::Mono.Unix.Catalog.GetString ("Cart (0)");
			this.hbox1.Add (this.btnCart);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnCart]));
			w2.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.fixed9 = new global::Gtk.Fixed ();
			this.fixed9.Name = "fixed9";
			this.fixed9.HasWindow = false;
			this.hbox1.Add (this.fixed9);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.fixed9]));
			w3.Position = 2;
			this.vbox3.Add (this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fixed7 = new global::Gtk.Fixed ();
			this.fixed7.Name = "fixed7";
			this.fixed7.HasWindow = false;
			this.hbox2.Add (this.fixed7);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.fixed7]));
			w5.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fixed8 = new global::Gtk.Fixed ();
			this.fixed8.Name = "fixed8";
			this.fixed8.HasWindow = false;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.btnOrderStatus = new global::Gtk.Button ();
			this.btnOrderStatus.CanFocus = true;
			this.btnOrderStatus.Name = "btnOrderStatus";
			this.btnOrderStatus.UseUnderline = true;
			this.btnOrderStatus.Label = global::Mono.Unix.Catalog.GetString ("Order Status");
			this.fixed8.Add (this.btnOrderStatus);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.btnOrderStatus]));
			w6.X = -2;
			w6.Y = 7;
			this.hbox2.Add (this.fixed8);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.fixed8]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.btnShipStatus = new global::Gtk.Button ();
			this.btnShipStatus.CanFocus = true;
			this.btnShipStatus.Name = "btnShipStatus";
			this.btnShipStatus.UseUnderline = true;
			this.btnShipStatus.Label = global::Mono.Unix.Catalog.GetString ("Ship Status Check");
			this.hbox2.Add (this.btnShipStatus);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.btnShipStatus]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fixed10 = new global::Gtk.Fixed ();
			this.fixed10.Name = "fixed10";
			this.fixed10.HasWindow = false;
			this.hbox2.Add (this.fixed10);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.fixed10]));
			w9.Position = 3;
			this.vbox3.Add (this.hbox2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox2]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox2.Add (this.vbox3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox3]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Cosmetics");
			this.vbox4.Add (this.label2);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label2]));
			w12.Position = 0;
			w12.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Mascara");
			this.vbox4.Add (this.label3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label3]));
			w13.Position = 1;
			w13.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Conditioner");
			this.vbox4.Add (this.label4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label4]));
			w14.Position = 2;
			w14.Fill = false;
			this.hbox6.Add (this.vbox4);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.vbox4]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString (" - 10,000.00 IDR");
			this.vbox5.Add (this.label5);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label5]));
			w16.Position = 0;
			w16.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("- 20,000.00 IDR");
			this.vbox5.Add (this.label6);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label6]));
			w17.Position = 1;
			w17.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("- 30,000.00 IDR");
			this.vbox5.Add (this.label7);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label7]));
			w18.Position = 2;
			w18.Fill = false;
			this.hbox6.Add (this.vbox5);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.vbox5]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.txtCosQty = new global::Gtk.Entry ();
			this.txtCosQty.CanFocus = true;
			this.txtCosQty.Name = "txtCosQty";
			this.txtCosQty.IsEditable = true;
			this.txtCosQty.InvisibleChar = '•';
			this.hbox7.Add (this.txtCosQty);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.txtCosQty]));
			w20.Position = 0;
			// Container child hbox7.Gtk.Box+BoxChild
			this.btnCosAdd = new global::Gtk.Button ();
			this.btnCosAdd.CanFocus = true;
			this.btnCosAdd.Name = "btnCosAdd";
			this.btnCosAdd.UseUnderline = true;
			this.btnCosAdd.Label = global::Mono.Unix.Catalog.GetString ("Add to Cart");
			this.hbox7.Add (this.btnCosAdd);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.btnCosAdd]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			this.vbox6.Add (this.hbox7);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox7]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.txtMasQty = new global::Gtk.Entry ();
			this.txtMasQty.CanFocus = true;
			this.txtMasQty.Name = "txtMasQty";
			this.txtMasQty.IsEditable = true;
			this.txtMasQty.InvisibleChar = '•';
			this.hbox8.Add (this.txtMasQty);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.txtMasQty]));
			w23.Position = 0;
			// Container child hbox8.Gtk.Box+BoxChild
			this.btnMascara = new global::Gtk.Button ();
			this.btnMascara.CanFocus = true;
			this.btnMascara.Name = "btnMascara";
			this.btnMascara.UseUnderline = true;
			this.btnMascara.Label = global::Mono.Unix.Catalog.GetString ("Add to Cart");
			this.hbox8.Add (this.btnMascara);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.btnMascara]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			this.vbox6.Add (this.hbox8);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox8]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox ();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.txtConQty = new global::Gtk.Entry ();
			this.txtConQty.CanFocus = true;
			this.txtConQty.Name = "txtConQty";
			this.txtConQty.IsEditable = true;
			this.txtConQty.InvisibleChar = '•';
			this.hbox9.Add (this.txtConQty);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.txtConQty]));
			w26.Position = 0;
			// Container child hbox9.Gtk.Box+BoxChild
			this.btnConditioner = new global::Gtk.Button ();
			this.btnConditioner.CanFocus = true;
			this.btnConditioner.Name = "btnConditioner";
			this.btnConditioner.UseUnderline = true;
			this.btnConditioner.Label = global::Mono.Unix.Catalog.GetString ("Add to Cart");
			this.hbox9.Add (this.btnConditioner);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.btnConditioner]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			this.vbox6.Add (this.hbox9);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox9]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			this.hbox6.Add (this.vbox6);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.vbox6]));
			w29.Position = 2;
			this.vbox2.Add (this.hbox6);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox6]));
			w30.Position = 2;
			w30.Expand = false;
			w30.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.fixed11 = new global::Gtk.Fixed ();
			this.fixed11.Name = "fixed11";
			this.fixed11.HasWindow = false;
			this.vbox2.Add (this.fixed11);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.fixed11]));
			w31.Position = 3;
			w31.Expand = false;
			w31.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox ();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.btnCheckOut = new global::Gtk.Button ();
			this.btnCheckOut.CanFocus = true;
			this.btnCheckOut.Name = "btnCheckOut";
			this.btnCheckOut.UseUnderline = true;
			this.btnCheckOut.Label = global::Mono.Unix.Catalog.GetString ("Check Out");
			this.hbox10.Add (this.btnCheckOut);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.btnCheckOut]));
			w32.Position = 2;
			this.vbox2.Add (this.hbox10);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox10]));
			w33.Position = 4;
			w33.Expand = false;
			w33.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 649;
			this.DefaultHeight = 464;
			this.Show ();
			this.btnOrderStatus.Clicked += new global::System.EventHandler (this.OnBtnOrderStatusClicked);
			this.btnShipStatus.Clicked += new global::System.EventHandler (this.OnBtnShipStatusClicked);
			this.btnCosAdd.Clicked += new global::System.EventHandler (this.OnBtnCosAddClicked);
			this.btnMascara.Clicked += new global::System.EventHandler (this.OnBtnMascaraClicked);
			this.btnConditioner.Clicked += new global::System.EventHandler (this.OnBtnConditionerClicked);
			this.btnCheckOut.Clicked += new global::System.EventHandler (this.OnBtnCheckOutClicked);
		}
	}
}
