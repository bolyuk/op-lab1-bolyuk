
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox1;

	private global::Gtk.Button menu2but;

	private global::Gtk.Button menu3but;

	private global::Gtk.Button menu4but;

	private global::Gtk.Button menu5but;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.menu2but = new global::Gtk.Button();
		this.menu2but.CanFocus = true;
		this.menu2but.Name = "menu2but";
		this.menu2but.UseUnderline = true;
		this.menu2but.Label = global::Mono.Unix.Catalog.GetString("ДатаБаза");
		global::Gtk.Image w1 = new global::Gtk.Image();
		w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-properties", global::Gtk.IconSize.Menu);
		this.menu2but.Image = w1;
		this.hbox1.Add(this.menu2but);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.menu2but]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.menu3but = new global::Gtk.Button();
		this.menu3but.CanFocus = true;
		this.menu3but.Name = "menu3but";
		this.menu3but.UseUnderline = true;
		this.menu3but.Label = global::Mono.Unix.Catalog.GetString("Хрестики Нулики");
		global::Gtk.Image w3 = new global::Gtk.Image();
		w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-media-play", global::Gtk.IconSize.Menu);
		this.menu3but.Image = w3;
		this.hbox1.Add(this.menu3but);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.menu3but]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.menu4but = new global::Gtk.Button();
		this.menu4but.CanFocus = true;
		this.menu4but.Name = "menu4but";
		this.menu4but.UseUnderline = true;
		this.menu4but.Label = global::Mono.Unix.Catalog.GetString("Калькулятор");
		global::Gtk.Image w5 = new global::Gtk.Image();
		w5.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-harddisk", global::Gtk.IconSize.Menu);
		this.menu4but.Image = w5;
		this.hbox1.Add(this.menu4but);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.menu4but]));
		w6.Position = 2;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.menu5but = new global::Gtk.Button();
		this.menu5but.CanFocus = true;
		this.menu5but.Name = "menu5but";
		this.menu5but.UseUnderline = true;
		this.menu5but.Label = global::Mono.Unix.Catalog.GetString("Інфо");
		global::Gtk.Image w7 = new global::Gtk.Image();
		w7.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-bold", global::Gtk.IconSize.Menu);
		this.menu5but.Image = w7;
		this.hbox1.Add(this.menu5but);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.menu5but]));
		w8.Position = 3;
		w8.Expand = false;
		w8.Fill = false;
		this.Add(this.hbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 441;
		this.DefaultHeight = 39;
		this.Show();
	}
}
