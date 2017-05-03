using System;
using System.IO;
using System.Net;
using Google.Authenticator;
namespace DB2FAtest_gtk
{
	public partial class TwoFactorSetupWindow : Gtk.Window
	{
		public bool success = false;
		TwoFactorAuthenticator tfa;
		string key;

		public TwoFactorSetupWindow(string username, string key) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
			this.key = key;
			tfa = new TwoFactorAuthenticator();
			var setupInfo = tfa.GenerateSetupCode("DB2FAtest gtk", username + "@redistestgtk", key, 300, 300);
			qrImage.Pixbuf = new Gdk.Pixbuf(new MemoryStream(new WebClient().DownloadData(setupInfo.QrCodeSetupImageUrl)));
		}

		protected void OnVerifyButtonClicked(object sender, EventArgs e)
		{
			if (tfa.ValidateTwoFactorPIN(key, verifyEntry.Text.Replace(" ", "")))
			{
				success = true;
				Destroy();
			}
			else MessageBox.Show("Invalid code entered");
		}
	}
}
