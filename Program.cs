using System;

namespace C_sharp_8_switch_branching
{
    class Program
    {
        public static void MoodSensor()
        {
            var rand = new Random();
            int choice = rand.Next() % 2;
            choice = 0;
            switch (choice)
            {
                case 0:
                    Console.WriteLine("    ###########\n" +
                                      "  ##           ##\n" +
                                      " #    ##   ##    #\n" +
                                      "#     ##   ##     #\n" +
                                      "#  #           #  #\n" +
                                      " #   #       #   #\n" +
                                      "  #    ## ##    #\n" +
                                      "   ##         ##\n" +
                                      "     #########\n");
                    break;
            }
        }
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("0. Exit\n1. Mood Sensor\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 0: flag = false; break;
                    case 1:
                        MoodSensor();
                        break;
                }
            }
        }
    }
}
