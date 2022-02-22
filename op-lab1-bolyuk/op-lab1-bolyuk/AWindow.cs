using System;
namespace oplab1bolyuk
{
    public partial class AWindow : oplab1bolyuk.Swin
    {
        public AWindow() 
        {
            this.Build();
            title("Про мене");
            button15.Clicked += (sender, e) => menu();
        }
    }
}
