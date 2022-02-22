using System;
using oplab1bolyuk;

public partial class MainWindow : oplab1bolyuk.Swin
{
    public MainWindow()
    {
        Build();
        menu2but.Clicked += (sender, e) => wind(new DBWindow());
        menu3but.Clicked += (sender, e) => wind(new GWindow());
        menu4but.Clicked += (sender, e) => wind(new СWindow());
        menu5but.Clicked += (sender, e) => wind(new AWindow());
        title("Головне меню");
    }

}
