using System;
using Gtk;

namespace oplab1bolyuk
{
    public partial class Swin : Gtk.Window
    {
        public Swin() :
                base(Gtk.WindowType.Toplevel)
        {
            Resizable = false;
        }

        override
        protected void OnDestroyed()
        {
            //Application.Quit();
        }
        protected void title(String title)
        {
            Title = title;
            WindowPosition = WindowPosition.CenterAlways;
        }

        protected void menu()
        {
            wind(new MainWindow());
            this.Destroy();
        }

protected void wind(Gtk.Window wind)
        {
            wind.Show();
            this.Destroy();
        }
    }
}
