using System;
using Gtk;

namespace oplab1bolyuk
{
    public partial class GWindow : oplab1bolyuk.Swin
    {
        private ComboBox[,] matrix;
        private int[,] value;
        private bool turn = true;
        private bool finished = false;
        int _count = 0;

        public GWindow()
        {
            Build();
            title("Хрестики нулики");
            init();
            button2.Clicked += returns;
        }

        void logic(object sender, EventArgs e)
        {
            if (!finished)
            { 
            for (int i = 0; i < 5; i++)
                    for (int y = 0; y < 5; y++)
                    {
                        if (matrix[i, y].ActiveText != "-" && value[i, y] == 0)
                        {
                            if (check(matrix[i, y].ActiveText, turn))
                            {
                                turn = !turn;
                                value[i, y] = toInt(matrix[i, y].ActiveText);
                                label1.Text = "Файний хід! Наступним ходить " + toString(turn);
                                _count++;
                            }
                            else
                            {
                                label1.Text = "Не правильний хід! Зараз ходить " + toString(turn);
                                matrix[i, y].Active = 0;
                                return;
                            }
                        }
                        else if (toInt(matrix[i, y].ActiveText) != value[i, y] && toInt(matrix[i, y].ActiveText) != 0)
                        {
                            label1.Text = "Не можна змінювати минулі ходи!";
                            matrix[i, y].Active = value[i, y];
                            return;
                        }
                    }
                checkFinish("X");
                checkFinish("O");
                if(finished)
                    label1.Text = "Раунд завершено, переміг " + toString(!turn);
            }
            else
            {
                label1.Text = "Раунд завершено, переміг "+toString(!turn);
            }
            if (_count == 25 && !finished)
            {
                label1.Text = "Нічия, ходи скінчилися...";
                return;
            }
        }

        public void checkFinish(String buf)
        {
            String pattern = "";
            for (int i = 0; i < 4; i++) pattern += toInt(buf);
            String[] list = new string[25];
            for(int i=0; i<5; i++)
                for(int j=0; j<5;j++)
                {
                    list[i] += value[i, j];
                }
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    list[i+5] += value[j, i];
                }
            int c = 9;
            for(int i=0;i<2;i++)
            {
                for(int j=0; j<2;j++)
                {
                    for(int k=0; k+j < 5 && k+i<5;k++)
                        list[c]+= value[k+j, k+i];
                    c++;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 4; j > 2; j--)
                {
                    for (int k = 0; j-k >-1 && k+i<5; k++)
                        list[c] += value[k+i, j-k];
                    c++;
                }
            }

            for (int i=0; i<list.Length; i++)
                if(list[i] != null && list[i].Contains(pattern))
                {
                    finished = true;
                    return;
                }



        }

        public bool check(String text, bool turn)
         {
            if (text == "X" && turn) return true;
            if (text == "O" && !turn) return true;
            return false;
         }

        public int toInt(String t)
        {
            if (t == "X") return 1;
            if (t == "O") return 2;
            if (t == "-") return 0;
            return -1;
        }

        public String toString(Boolean b)
        {
            if (b) return "X"; else return "O";
        }




        void returns(object sender, EventArgs e)
        {
            menu();
        }

        private void init()
        {
            matrix = new ComboBox[,]{
            {c1_1, c1_2, c1_3, c1_4, c1_5},
            {c2_1, c2_2, c2_3, c2_4, c2_5},
            {c3_1, c3_2, c3_3, c3_4, c3_5},
            {c4_1, c4_2, c4_3, c4_4, c4_5},
            {c5_1, c5_2, c5_3, c5_4, c5_5}
           };
            value = new int[5, 5];
            for (int i = 0; i < 5; i++)
                for (int y = 0; y < 5; y++)
                {
                    matrix[i, y].AppendText("-");
                    matrix[i, y].AppendText("X");
                    matrix[i, y].AppendText("O");
                    matrix[i, y].Active = 0;
                    value[i, y] = 0;
                    matrix[i, y].Changed += logic;
                }
        }
    }
}
