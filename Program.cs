using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace HomeWork17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Matrix> list = new List<Matrix>();
            while (true)
            {
                Task.Run(() =>
                {
                    for (int i = 0; i < new Random().Next(100, 1000); i++)
                    {
                        list.Add(new Matrix()
                        {
                            Left = new Random().Next(100),
                            simbol = Word(),
                            Top = new Random().Next(2, 8)
                        });
                    }
                }).Wait();
                
                
            }
        }

           

        static string Word()
        {
            
            string[] simBol = new string[] { "QW","ER","TY","UI","OP","AS","DF","GH",
                                            "JK","LZ","XC","VB","NM", "JK","LZ","XC",
                                            "VB","NM","QW","ER","TY","UI","OP","AS",
                                            "DF","GH","JK","LZ","XC","VB","NM", "JK"};
                                             
            
                                       
            string word = "";
            for (int i = 0; i < simBol.Length; i++)
            {
                if (new Random().Next(0, 4) == 1)
                {

                    word += simBol[i];
                }
            }
            return word;
        }


    }

    class Matrix
    {
        public string simbol { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
    }
    
}


