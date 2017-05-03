using System;
using System.Collections.Generic;
using StackExchange.Redis;
using static Sodium.PasswordHash;
namespace DB2FAtest_gtk
{
	public partial class RegisterWindow : Gtk.Window
	{
public RegisterWindow() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}

		protected void OnRegisterButtonClicked(object sender, EventArgs e)
		{
			var redis = ConnectionMultiplexer.Connect("redis-17057.c8.us-east-1-4.ec2.cloud.redislabs.com:17057");
			var db = redis.GetDatabase();
			if (string.IsNullOrWhiteSpace(usernameEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text))
			{
				MessageBox.Show("Must enter username and password");
				return;
			}
			if (passwordEntry.Text != verifyEntry.Text)
			{
				MessageBox.Show("Passwords must match");
				return;
			}
			string username = usernameEntry.Text;
			string password = ArgonHashString(passwordEntry.Text);

			if (db.HashExists("users", username))
			{
				MessageBox.Show("Username already exists");
				return;
			}

			long userID = db.StringIncrement("next_user_id");
			List<HashEntry> userEntry = new List<HashEntry>();
			userEntry.Add(new HashEntry("username", username));
			userEntry.Add(new HashEntry("password", password));
			if (enableTwoFactorCheck.Active)
			{
				var key = Convert.ToBase64String(ArgonGenerateSalt());
				TwoFactorSetupWindow tfsw = new TwoFactorSetupWindow(username, key) { Modal = true };
				tfsw.Show();
				tfsw.Destroyed += delegate
				{
					if (tfsw.success)
					{
						userEntry.Add(new HashEntry("twofactorauthkey", key));
						db.HashSet("users", username, userID);
						db.HashSet("user:" + userID, userEntry.ToArray());
						Destroy();
					}
					else return;
				};
			}
			else
			{
				db.HashSet("users", username, userID);
				db.HashSet("user:" + userID, userEntry.ToArray());
				Destroy();
			}
		}
	}
}
