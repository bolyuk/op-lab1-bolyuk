using System;
namespace oplab1bolyuk
{
    public partial class SDialog : Gtk.Window
    {
        public SDialog() : base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        public void openMain()
        {
            new MainWindow().Show();
        }
    }
}
