
// This file has been generated by the GUI designer. Do not modify.
namespace DB2FAtest_gtk
{
	public partial class LoginWindow
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label usernameLabel;

		private global::Gtk.Entry usernameEntry;

		private global::Gtk.Label passwordLabel;

		private global::Gtk.Entry passwordEntry;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button loginButton;

		private global::Gtk.Button registerButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget DB2FAtest_gtk.LoginWindow
			this.Name = "DB2FAtest_gtk.LoginWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("LoginWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child DB2FAtest_gtk.LoginWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.usernameLabel = new global::Gtk.Label();
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Username");
			this.vbox1.Add(this.usernameLabel);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.usernameLabel]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.usernameEntry = new global::Gtk.Entry();
			this.usernameEntry.CanFocus = true;
			this.usernameEntry.Name = "usernameEntry";
			this.usernameEntry.IsEditable = true;
			this.usernameEntry.InvisibleChar = '●';
			this.vbox1.Add(this.usernameEntry);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.usernameEntry]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.passwordLabel = new global::Gtk.Label();
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Password");
			this.vbox1.Add(this.passwordLabel);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.passwordLabel]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.passwordEntry = new global::Gtk.Entry();
			this.passwordEntry.CanFocus = true;
			this.passwordEntry.Name = "passwordEntry";
			this.passwordEntry.IsEditable = true;
			this.passwordEntry.Visibility = false;
			this.passwordEntry.InvisibleChar = '●';
			this.vbox1.Add(this.passwordEntry);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.passwordEntry]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.loginButton = new global::Gtk.Button();
			this.loginButton.CanFocus = true;
			this.loginButton.Name = "loginButton";
			this.loginButton.UseUnderline = true;
			this.loginButton.Label = global::Mono.Unix.Catalog.GetString("Login");
			this.hbox1.Add(this.loginButton);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.loginButton]));
			w5.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.registerButton = new global::Gtk.Button();
			this.registerButton.CanFocus = true;
			this.registerButton.Name = "registerButton";
			this.registerButton.UseUnderline = true;
			this.registerButton.Label = global::Mono.Unix.Catalog.GetString("Register");
			this.hbox1.Add(this.registerButton);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.registerButton]));
			w6.Position = 1;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w7.Position = 4;
			w7.Expand = false;
			w7.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.loginButton.Clicked += new global::System.EventHandler(this.OnLoginButtonClicked);
			this.registerButton.Clicked += new global::System.EventHandler(this.OnRegisterButtonClicked);
		}
	}
}
