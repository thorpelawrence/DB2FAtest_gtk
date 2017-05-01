using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
		DB2FAtest_gtk.LoginWindow lw = new DB2FAtest_gtk.LoginWindow { Modal = true };
		lw.Destroyed += delegate
		{
			if (!lw.success)
				Application.Quit();
		Title += " : " + lw.username;
		};
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}
}
