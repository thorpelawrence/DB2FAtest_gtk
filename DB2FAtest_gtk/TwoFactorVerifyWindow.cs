using System;
using Google.Authenticator;
namespace DB2FAtest_gtk
{
	public partial class TwoFactorVerifyWindow : Gtk.Window
	{
		public bool success;
		string key;

		public TwoFactorVerifyWindow(string key) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
			this.key = key;
		}

		protected void OnVerifyButtonClicked(object sender, EventArgs e)
		{
			TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
			if (tfa.ValidateTwoFactorPIN(key, codeEntry.Text))
			{
				success = true;
				Destroy();
			}
		}
	}
}
