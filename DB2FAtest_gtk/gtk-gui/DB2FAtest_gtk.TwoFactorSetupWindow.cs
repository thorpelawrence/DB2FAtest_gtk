
// This file has been generated by the GUI designer. Do not modify.
namespace DB2FAtest_gtk
{
	public partial class TwoFactorSetupWindow
	{
		private global::Gtk.VBox vbox4;

		private global::Gtk.Image qrImage;

		private global::Gtk.Label manualKeyLabel;

		private global::Gtk.Label enterLabel;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Entry verifyEntry;

		private global::Gtk.Button verifyButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget DB2FAtest_gtk.TwoFactorSetupWindow
			this.Name = "DB2FAtest_gtk.TwoFactorSetupWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("TwoFactorSetupWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child DB2FAtest_gtk.TwoFactorSetupWindow.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.qrImage = new global::Gtk.Image();
			this.qrImage.Name = "qrImage";
			this.vbox4.Add(this.qrImage);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.qrImage]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.manualKeyLabel = new global::Gtk.Label();
			this.manualKeyLabel.Name = "manualKeyLabel";
			this.vbox4.Add(this.manualKeyLabel);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.manualKeyLabel]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.enterLabel = new global::Gtk.Label();
			this.enterLabel.Name = "enterLabel";
			this.enterLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Enter code generated by Google Authenticator");
			this.vbox4.Add(this.enterLabel);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.enterLabel]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.verifyEntry = new global::Gtk.Entry();
			this.verifyEntry.CanFocus = true;
			this.verifyEntry.Name = "verifyEntry";
			this.verifyEntry.IsEditable = true;
			this.verifyEntry.InvisibleChar = '●';
			this.hbox3.Add(this.verifyEntry);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.verifyEntry]));
			w4.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.verifyButton = new global::Gtk.Button();
			this.verifyButton.CanFocus = true;
			this.verifyButton.Name = "verifyButton";
			this.verifyButton.UseUnderline = true;
			this.verifyButton.Label = global::Mono.Unix.Catalog.GetString("Verify");
			this.hbox3.Add(this.verifyButton);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.verifyButton]));
			w5.Position = 1;
			this.vbox4.Add(this.hbox3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox3]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			this.Add(this.vbox4);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.verifyButton.Clicked += new global::System.EventHandler(this.OnVerifyButtonClicked);
		}
	}
}
