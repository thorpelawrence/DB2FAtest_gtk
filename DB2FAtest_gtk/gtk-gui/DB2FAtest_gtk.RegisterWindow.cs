
// This file has been generated by the GUI designer. Do not modify.
namespace DB2FAtest_gtk
{
	public partial class RegisterWindow
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.Label usernameLabel;

		private global::Gtk.Entry usernameEntry;

		private global::Gtk.Label passwordLabel;

		private global::Gtk.Entry passwordEntry;

		private global::Gtk.Label verifyLabel;

		private global::Gtk.Entry verifyEntry;

		private global::Gtk.HBox hbox2;

		private global::Gtk.CheckButton enableTwoFactorCheck;

		private global::Gtk.Button registerButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget DB2FAtest_gtk.RegisterWindow
			this.Name = "DB2FAtest_gtk.RegisterWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("RegisterWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child DB2FAtest_gtk.RegisterWindow.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.usernameLabel = new global::Gtk.Label();
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Username");
			this.vbox3.Add(this.usernameLabel);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.usernameLabel]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.usernameEntry = new global::Gtk.Entry();
			this.usernameEntry.CanFocus = true;
			this.usernameEntry.Name = "usernameEntry";
			this.usernameEntry.IsEditable = true;
			this.usernameEntry.InvisibleChar = '●';
			this.vbox3.Add(this.usernameEntry);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.usernameEntry]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.passwordLabel = new global::Gtk.Label();
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Password");
			this.vbox3.Add(this.passwordLabel);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.passwordLabel]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.passwordEntry = new global::Gtk.Entry();
			this.passwordEntry.CanFocus = true;
			this.passwordEntry.Name = "passwordEntry";
			this.passwordEntry.IsEditable = true;
			this.passwordEntry.Visibility = false;
			this.passwordEntry.InvisibleChar = '●';
			this.vbox3.Add(this.passwordEntry);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.passwordEntry]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.verifyLabel = new global::Gtk.Label();
			this.verifyLabel.Name = "verifyLabel";
			this.verifyLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Verify password");
			this.vbox3.Add(this.verifyLabel);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.verifyLabel]));
			w5.Position = 4;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.verifyEntry = new global::Gtk.Entry();
			this.verifyEntry.CanFocus = true;
			this.verifyEntry.Name = "verifyEntry";
			this.verifyEntry.IsEditable = true;
			this.verifyEntry.Visibility = false;
			this.verifyEntry.InvisibleChar = '●';
			this.vbox3.Add(this.verifyEntry);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.verifyEntry]));
			w6.Position = 5;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.enableTwoFactorCheck = new global::Gtk.CheckButton();
			this.enableTwoFactorCheck.CanFocus = true;
			this.enableTwoFactorCheck.Name = "enableTwoFactorCheck";
			this.enableTwoFactorCheck.Label = global::Mono.Unix.Catalog.GetString("Enable 2-factor authentication?");
			this.enableTwoFactorCheck.Active = true;
			this.enableTwoFactorCheck.DrawIndicator = true;
			this.enableTwoFactorCheck.UseUnderline = true;
			this.hbox2.Add(this.enableTwoFactorCheck);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.enableTwoFactorCheck]));
			w7.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.registerButton = new global::Gtk.Button();
			this.registerButton.CanFocus = true;
			this.registerButton.Name = "registerButton";
			this.registerButton.UseUnderline = true;
			this.registerButton.Label = global::Mono.Unix.Catalog.GetString("Register");
			this.hbox2.Add(this.registerButton);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.registerButton]));
			w8.Position = 1;
			this.vbox3.Add(this.hbox2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox2]));
			w9.Position = 6;
			w9.Expand = false;
			w9.Fill = false;
			this.Add(this.vbox3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.registerButton.Clicked += new global::System.EventHandler(this.OnRegisterButtonClicked);
		}
	}
}