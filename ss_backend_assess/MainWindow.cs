using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnTestClicked (object sender, EventArgs e)
	{
		lblTest.LabelProp = "test";
		btnTest.Label = "apa aja boleh";
		//throw new NotImplementedException ();
	}
}
