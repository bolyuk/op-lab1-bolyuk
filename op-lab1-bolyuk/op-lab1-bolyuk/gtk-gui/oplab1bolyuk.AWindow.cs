
// This file has been generated by the GUI designer. Do not modify.
namespace oplab1bolyuk
{
	public partial class AWindow
	{
		private global::Gtk.VBox vbox7;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Button button15;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget oplab1bolyuk.AWindow
			this.Name = "oplab1bolyuk.AWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("AWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child oplab1bolyuk.AWindow.Gtk.Container+ContainerChild
			this.vbox7 = new global::Gtk.VBox();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Болюк Д.В КП-12        2022 рік");
			this.vbox7.Add(this.label6);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.label6]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("https://github.com/bolyuk/op-lab1-bolyuk");
			this.label7.Selectable = true;
			this.vbox7.Add(this.label7);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.label7]));
			w2.Position = 1;
			// Container child vbox7.Gtk.Box+BoxChild
			this.button15 = new global::Gtk.Button();
			this.button15.CanFocus = true;
			this.button15.Name = "button15";
			this.button15.UseUnderline = true;
			this.button15.Label = global::Mono.Unix.Catalog.GetString("Меню");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-undo", global::Gtk.IconSize.Menu);
			this.button15.Image = w3;
			this.vbox7.Add(this.button15);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.button15]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.Add(this.vbox7);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}
