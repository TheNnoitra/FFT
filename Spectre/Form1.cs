using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Spectre
{

    /// <summary>
    /// Сама программа
    /// </summary>
    /// 

    public partial class Form1 : Form
    {
        string input;//переменные
        int kol = 0;
         

        public string[,] file = new string[500000, 3];//объявили массив. максимум 500 000 строк 
        public Form1()
        {
            InitializeComponent();
           
            using (StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\1.txt", Encoding.Default))//открываем файл по адресу записанному в " "
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");//выбирается кодировка. твои числа разделены . а не , по-этому пришлось выбрать такую кодировку
                int i = 0;

                while ((input = sr.ReadLine()) != null)//цикл который считывает построчно весь файл, попутно считая строки
                {

                    string[] m = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    for (uint k = 0, j = 0; k < m.Length; k++)
                    {

                        if (m[k].Trim() != " ")
                        {
                            file[i, j] = m[k];
                            j++;
                        }
                    }
                    i++;
                    kol = i;
                } //прочитали файл, сосчитали строки и записали инфу в массив file[i,j], где i - значения, j - номер столбца, откуда считали (0 - Х, 1 - Y, 2 - Z)

            }
            
             

        }
        const int N = 250;
        double[] Inner = new double[N];
        Complex[] Furie = new Complex[N];

        private void BTNOpen_Click(object sender, EventArgs e)// тут выполняются операци при нажатии на кнопку - Открыть
        {

           LBL9.Text = Convert.ToString(kol);//выводится кол-во строк в нашу программу
                      
            Chart4.ChartAreas[0].AxisX.Maximum = kol;//ренджируется график для Оси X/Y/Z
                 
                     
                    

        }

        private void Chart1_Click(object sender, EventArgs e)//это случайно образовалось, не удаляй!
        {


        }




        /// <summary>
        /// Быстрое преобразование Фурье
        /// </summary>
        public class Complex
        {
            public double Re;// Реальная часть
            public double Im; // Мнимая
            public double Amplitude; // Амплитуда для АЧХ
            public double Faza; // Фаза для ФЧХ
            public double Frecuensy; // Частота гармоники
            
        }


        private void OsX_Click(object sender, EventArgs e) //действия при нажатии на кнопку - Ось X (для кнопок Ось Y, Ось Z выполняются точно такие же действия)
        {
            

            int N = Inner.Length; //объявляем переменные

            double Arg;

            
            for (int k = 0; k < N; k++)//цикл вычисления БПФ
            {
                
                Furie[k] = new Complex();//объявляем массив
                for (int n = 0; n < N; n++)//цикл расчета/записи массива
                {
                   
                    Arg = 2 * Math.PI * k * n / N;                   
                    Furie[k].Re += Convert.ToDouble(file[n, 0]) * Math.Cos(Arg);
                    Furie[k].Im -= Convert.ToDouble(file[n, 0]) * Math.Sin(Arg);
                    

                }

                Furie[k].Amplitude = (Math.Sqrt(Math.Pow(Furie[k].Re, 2) + Math.Pow(Furie[k].Im, 2))) ;//нахождение амплитуды
                Furie[k].Faza = Math.Atan2(Furie[k].Im, Furie[k].Re) / Math.PI * 180;//нахождение фазы
                Furie[k].Frecuensy = ((N - 1) * (k));// нахождение частоты

            }//тт мы типа произвели БПФ, осталось вывести полученные данные

            Chart4.Series[0].LegendText = "Ось X"; //задаем имя для первого графика
            for (uint i = 1; i < kol; i++)//отрисовываем первый график, для Оси
            {
                Chart4.Series[0].Points.AddXY(i, Convert.ToDouble(file[i, 0]));//выбираем где и как рисовать, говорит ему какие точки соединить линией

            }

            for (int i = 0; i < N; i++)//тут отрисовываем 2й и 3й графики
            {

                ChartAFT.Series[0].Points.AddXY(Furie[i].Frecuensy, Furie[i].Amplitude);//строим Амплитудный спектр
                ChartFFT.Series[0].Points.AddXY(Furie[i].Frecuensy, Furie[i].Faza);// строим Фазный спектр
            }

        }

        private void OsY_Click(object sender, EventArgs e)//выполняются действия при нажатии на кнопку ОсьY
        {


            int N = Inner.Length;

            double Arg;


            for (int k = 0; k < N; k++)
            {

                Furie[k] = new Complex();
                for (int n = 0; n < N; n++)
                {
                    Arg = 2 * Math.PI * k * n / N;
                    Furie[k].Re += Convert.ToDouble(file[n, 1]) * Math.Cos(Arg);
                    Furie[k].Im -= Convert.ToDouble(file[n, 1]) * Math.Sin(Arg);


                }

                Furie[k].Amplitude = (Math.Sqrt(Math.Pow(Furie[k].Re, 2) + Math.Pow(Furie[k].Im, 2)));
                Furie[k].Faza = Math.Atan2(Furie[k].Im, Furie[k].Re) / Math.PI * 180;
                Furie[k].Frecuensy = ((N - 1) * (k));

            }

            Chart4.Series[0].LegendText = "Ось Y";
            for (uint i = 1; i < kol; i++)
            {
                Chart4.Series[0].Points.AddXY(i, Convert.ToDouble(file[i, 1]));

            }

            for (int i = 0; i < N; i++)
            {

                ChartAFT.Series[0].Points.AddXY(Furie[i].Frecuensy, Furie[i].Amplitude);
                ChartFFT.Series[0].Points.AddXY(Furie[i].Frecuensy, Furie[i].Faza);
            }
        }

        private void OsZ_Click(object sender, EventArgs e)//выполняются действия при нажатии на кнопку ОсьZ
        {


            int N = Inner.Length;

            double Arg;


            for (int k = 0; k < N; k++)
            {

                Furie[k] = new Complex();
                for (int n = 0; n < N; n++)
                {
                    Arg = 2 * Math.PI * k * n / N;
                    Furie[k].Re += Convert.ToDouble(file[n, 2]) * Math.Cos(Arg);
                    Furie[k].Im -= Convert.ToDouble(file[n, 2]) * Math.Sin(Arg);


                }

                Furie[k].Amplitude = (Math.Sqrt(Math.Pow(Furie[k].Re, 2) + Math.Pow(Furie[k].Im, 2)));
                Furie[k].Faza = Math.Atan2(Furie[k].Im, Furie[k].Re) / Math.PI * 180;
                Furie[k].Frecuensy = ((N - 1) * (k));

            }

            Chart4.Series[0].LegendText = "Ось Z";
            for (uint i = 1; i < kol; i++)
            {
                Chart4.Series[0].Points.AddXY(i, Convert.ToDouble(file[i, 2]));

            }

            for (int i = 0; i < N; i++)
            {

                ChartAFT.Series[0].Points.AddXY(Furie[i].Frecuensy, Furie[i].Amplitude);
                ChartFFT.Series[0].Points.AddXY(Furie[i].Frecuensy, Furie[i].Faza);
            }
        }

        private void Clear_Click(object sender, EventArgs e)//выполняются действия при нажатии на кнопку Сброс.
        {
                Chart4.Series[0].Points.Clear();//очищается первый график
                ChartAFT.Series[0].Points.Clear();//очищается график Амплитудного спектра
                ChartFFT.Series[0].Points.Clear();//очищается график Фазного спектра
            
            
        }
    }




    ///все что выделено зеленым цветом, тебе не нужно)


    /*
   //////
   ///Считывает строки и числа через пробел выносит в отдельные лейблы
   //////
   string[,] file = new string[10000, 3];
   using (StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\1.txt", Encoding.Default))
   {
       System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
       int i = 0;
       string input;
       while ((input = sr.ReadLine()) != null)
       {
           string[] m = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
           for (int k = 0, j = 0; k < m.Length; k++)
           {
               if (m[k].Trim() != " ")
               {
                   file[i, j] = m[k];
                   j++;
               }
           }
           i++;
       }
   }
   for (int i = 0; i < 2; i++)
   {
       LB1.Text = file[0, 0];
       LBL2.Text = file[0, 1];
       LBL3.Text = file[0, 2];
       LBL4.Text = file[1, 0];
       LBL5.Text = file[1, 1];
       LBL6.Text = file[1, 2];


       Double one = Convert.ToDouble(file[0, 0]);
       Double two = Convert.ToDouble(file[1, 0]);
       Double three = one + two;
       LBL7.Text = Convert.ToString(three) ;

   }
   */

    /*
    //////
    ///Только считывает строку целиком и выводит в лейбл 1
    //////
     using (StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\1.txt", Encoding.Default))
    {
        string s = "";
        while ((s = sr.ReadLine()) != null)
        {

            LB1.Text = s;
        }
    }
    */
}


    


