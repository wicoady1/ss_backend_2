using System;
using Gtk;
using ss_backend_assess;

public partial class MainWindow: Gtk.Window, ss_backend_assess.Interface.ILogin
{
	private connString _connStr;
	private ss_backend_assess.Presenter.LoginPresenter _cPresenter;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();

		this._connStr = new connString ();
		this._cPresenter = new ss_backend_assess.Presenter.LoginPresenter (this, _connStr);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnLoginClicked (object sender, EventArgs e)
	{
		int intErr = 1;
		intErr = this._cPresenter.LoginVerifier ();
		//throw new NotImplementedException ();
	}

	#region Interface Assignment
	public string ID{
		set{
			txtID.Text = value;
		}
		get{
			return txtID.Text;
		}
	}
	public string Password{
		set{
			txtPass.Text = value;
		}
		get{
			return txtPass.Text;
		}
	}


	#endregion
}
