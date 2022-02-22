using System;
using System.Collections.Generic;
using Gtk;
using oplab1bolyuk;

namespace oplab1bolyuk
{
    public partial class СWindow : oplab1bolyuk.Swin
    {
        Button[] nums;

        List<String> buffer = new List<String>();
        public СWindow()
        {
            Build();
            title("Калькулятор");
            init();
        }

        private void init() 
        {
            menubut.Clicked += (sender, e) => menu();

            resultbut.Clicked += (sender, e) => calculation();
            clearbut.Clicked += (sender, e) => { bufchange('e'); };
            nums = new Button[] {butnul, but1, but2, but3, but4, but5, but6, but7, but8, but9,
                 dotbut, divisbut, multbut, minusbut, plusbut};
            for(int i=0; i<nums.Length; i++)
                nums[i].Clicked +=  (sender, e) => { 
                bufchange(Char.Parse(((Button)sender).Label));
                    info.Text = getBuffer();
                };
        }

        public void calculation() 
        {
            try {
                Double result = Convert.ToDouble(buffer[0]);
                for (int i = 1; i < buffer.Count-1; i+=2)
                        switch(buffer[i])
                        {
                            case "-":
                            result-= Convert.ToDouble(buffer[i+1]);
                            break;
                            case "+":
                            result += Convert.ToDouble(buffer[i + 1]);
                            break;
                            case "/":
                            result /= Convert.ToDouble(buffer[i + 1]);
                            break;
                            case "*":
                            result *= Convert.ToDouble(buffer[i + 1]);
                            break;
                        }
                buffer.Clear();
                label5.Text = "Успіх!";
                buffer.Add(result.ToString());
                info.Text = getBuffer();
            }
            catch(Exception e)
            {
                label5.Text = "Помилка!";
                System.Console.Write(e);
            }

        }


        public void bufchange(Char t)
        {
            if (t == 'e')
            {
                buffer = new List<String>();
                info.Text = getBuffer();
                return;
            }
            String last = "";
            if (buffer.Count != 0)
                last = buffer[buffer.Count - 1];
            else if (Char.IsDigit(t))
            {
                buffer.Add(t.ToString());
                info.Text = getBuffer();
                return;
            }
            else return;


            if ((last.EndsWith(",") || isOperand(last)) && (isOperand(t.ToString()) || t == ',')) return;
            if (t == '.' && last.Contains(",")) return;
            if ((Char.IsDigit(getLast(last)) || getLast(last) == ',') && (Char.IsDigit(t) || t == ','))
            {
                buffer.RemoveAt(buffer.Count - 1);
                buffer.Add(last + t);
            }
            else
                buffer.Add(t.ToString());
                
            info.Text = getBuffer();
        }

        public char getLast(String t)
        {
            if (t.Length == 0) return Char.Parse(t);
            return Char.Parse(t.Substring(t.Length - 1));
        }


        public bool isOperand(String t)
        { return t == "/" || t == "*" || t == "-" || t == "+"; }

        public String getBuffer()
        {
            String r = "";
            for (int i = 0; i < buffer.Count; i++)
                r += buffer[i] + " ";
            return r;
        }


    }
}