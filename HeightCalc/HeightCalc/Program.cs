using System;

namespace HeightCalc
{
    class Program
    {
        

        static void Main(string[] args)
        {

            double cmHeight = 0;
            double feet = 0;
            double inch = 0;

            string feet_text = "";
            string inch_text = "";

            Console.WriteLine("--- Height Calculator --- v0.03 ---");
            Console.WriteLine("Input the amount of feet tall you are");
            feet_text = Console.ReadLine();
            feetStuff();

            Console.Clear();
            doFakeLoad();

            Console.Clear();
            Console.WriteLine("--- Height Calculator --- v0.03 ---");
            Console.WriteLine("Input the amount of inches tall you are");
            inch_text = Console.ReadLine();
            atleastZeroInches();

            mathShit();

            Console.Clear();
            doFakeLoad();

            Console.Clear();
            Console.WriteLine("--- Height Calculator --- v0.03 ---");
            Console.WriteLine("You are " + cmHeight + "centimeters tall!");


            //height bullshit
            void feetStuff()
            {
                if (feet_text == "0")
                {
                    feet = 0;
                    Console.Clear();
                    Console.WriteLine("oompa loompa doompa doop");
                    System.Threading.Thread.Sleep(300);
                    Console.Clear();
                }
                else if (feet_text == "1")
                {
                    feet = 1;
                }
                else if (feet_text == "2")
                {
                    feet = 2;
                }
                else if (feet_text == "3")
                {
                    feet = 3;
                }
                else if (feet_text == "4")
                {
                    feet = 4;
                }
                else if (feet_text == "5")
                {
                    feet = 5;
                }
                else if (feet_text == "6")
                {
                    feet = 6;
                }
                else if (feet_text == "7")
                {
                    feet = 7;
                }
                else if (feet_text == "8")
                {
                    feet = 8;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("nah bro, u r tweaking");
                    System.Threading.Thread.Sleep(300);
                    Console.Clear();
                }
            }

            void atleastZeroInches()
            {
                if (inch_text == "0")
                {
                    inch = 0;
                }
                else if (inch_text == "1")
                {
                    inch = 1;
                }
                else if (inch_text == "2")
                {
                    inch = 2;
                }
                else if (inch_text == "3")
                {
                    inch = 3;
                }
                else if (inch_text == "4")
                {
                    inch = 4;
                }
                else if (inch_text == "5")
                {
                    inch = 5;
                }
                else if (inch_text == "6")
                {
                    inch = 6;
                }
                else if (inch_text == "7")
                {
                    inch = 7;
                }
                else if (inch_text == "8")
                {
                    inch = 8;
                }
                else if (inch_text == "9")
                {
                    inch = 9;
                }
                else if (inch_text == "10")
                {
                    inch = 10;
                }
                else if (inch_text == "11")
                {
                    inch = 11;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("nah bro, u r tweaking");
                    System.Threading.Thread.Sleep(300);
                    Console.Clear();
                }
            }

            //math shit
            void mathShit()
            {
                feet *= 30.48;
                inch *= 2.54;

                cmHeight = feet += inch;
            }

        }

        static void doFakeLoad()
        {
            int loads = 0;
            string fakeLoad = "";

            while (loads <= 10)
            {
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                fakeLoad = "Loading ";
                Console.WriteLine(fakeLoad);

                System.Threading.Thread.Sleep(100);
                Console.Clear();
                fakeLoad = "Loading . ";
                Console.WriteLine(fakeLoad);

                System.Threading.Thread.Sleep(100);
                Console.Clear();
                fakeLoad = "Loading . . ";
                Console.WriteLine(fakeLoad);

                System.Threading.Thread.Sleep(100);
                Console.Clear();
                fakeLoad = "Loading . . .";
                Console.WriteLine(fakeLoad);
                System.Threading.Thread.Sleep(100);

                loads++;
            }

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            fakeLoad = "Loading Finished!";
            Console.WriteLine(fakeLoad);
            System.Threading.Thread.Sleep(500);

        }

        
    }
}
