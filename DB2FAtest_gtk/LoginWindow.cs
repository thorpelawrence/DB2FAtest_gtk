using System;
using StackExchange.Redis;
using Google.Authenticator;
using static Sodium.PasswordHash;

namespace DB2FAtest_gtk
{
	public partial class LoginWindow : Gtk.Window
	{
public string username;

		public bool success = false;

		public LoginWindow() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}

		protected void OnLoginButtonClicked(object sender, EventArgs e)
		{
			var redis = ConnectionMultiplexer.Connect("redis-17057.c8.us-east-1-4.ec2.cloud.redislabs.com:17057");
			var db = redis.GetDatabase();
			username = usernameEntry.Text;
			if (!db.HashExists("users", username))
			{
				MessageBox.Show("Username does not exist");
				return;
			}

			long userID = (long)db.HashGet("users", username);
			if (ArgonHashStringVerify(db.HashGet("user:" + userID, "password"), passwordEntry.Text))
			{
				if (db.HashExists("user:" + userID, "twofactorauthkey"))
				{
					TwoFactorVerifyWindow tfvw = new TwoFactorVerifyWindow(db.HashGet("user:" + userID, "twofactorauthkey")) { Modal = true };
					tfvw.Show();
					tfvw.Destroyed += delegate
					{
						success = tfvw.success;
 						Destroy();
					};
				}
				else
				{
					success = true;
					Destroy();
				}
			}
			else
			{
				MessageBox.Show("Incorrect password");
			}
		}

		protected void OnRegisterButtonClicked(object sender, EventArgs e)
		{
			new RegisterWindow { Modal = true }.Show();
		}
	}
}
