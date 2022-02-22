using System;
using Gtk;

namespace oplab1bolyuk
{
    public partial class DBWindow : oplab1bolyuk.Swin
    {
        public DBWindow() 
        {
            this.Build();
            title("ДатаБаза");
            menubut.Clicked += (arg1, arg2) => menu();
            searchbut.Clicked += search;
            savebut.Clicked += add;
            delbut.Clicked += del;
            if (DB.getCount() != 0)
                label1.Text = $"Завантажено {DB.getCount()} студентів";
            else
                label1.Text = "ДатаБаза порожня";

        }

        void del(object sender, EventArgs e)
        {
            try
            {
                if (!DB.contain(number.Text))
            {
                label1.Text = "Ви ввели неправильний номер заліковки!";
                return;
            }
                DB.del(number.Text);
                label1.Text = "Успіх!";
            }
            catch
            {
                label1.Text = "Помилка :\\";
            }
        }


        void search(object sender, EventArgs e)
        {
            if(number.Text == "")
            {
                label1.Text = "Для пошуку потрібно ввести Номер залікової книжки";
                return;
            }

            if(!DB.contain(number.Text))
            {
                label1.Text = "Ви ввели неправильний номер заліковки!";
                return;
            }

            String[] r = DB.search(number.Text);
            name.Text = r[1];
            info.Text = r[2];
            label1.Text = "Успіх!";
        }

        void add(object sender, EventArgs e)
        {
            try {
                if (number.Text.Contains("~") || name.Text.Contains("~") || info.Text.Contains("~"))
                {
                    label1.Text = "Не можна використовувати символ \"~\"!";
                    return;
                }
            if (number.Text == "")
            {
                label1.Text = "Номер залікової книжки не може бути порожнім!";
                return;
            }
            if (name.Text == "")
            {
                label1.Text = "ПІП не може бути порожнім!";
                return;
            }
                if (!DB.contain(number.Text))
                {
                    DB.add(number.Text, name.Text, info.Text);
                    label1.Text = "Успіх!";
                }
                else
                {
                    DB.edit(number.Text, name.Text, info.Text);
                    label1.Text = "Данний студент зареєстрований, данні оновлені!";
                }
            } catch(Exception err)
             {
                label1.Text = "Помилка :\\";
                System.Console.Write(err);
            }

        }

    }
}
