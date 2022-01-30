﻿using System;
using System.IO;

namespace Jean_Luc_Picard_s_journal_
{
    class Jean_luc_Picard_s_journal

    {
        public static void Main(string[] args)
        {
            string input, journal = "";

            Console.WriteLine("Welcome to Jean-Luc Picard’s journal");
            Console.WriteLine("Type: 'start' to start writing in a journal");
            Console.WriteLine("Type: 'stop'  to stop  writing in a journal");
            Console.WriteLine("Type: 'exit'  to exit  the program.");



            while (true)

            {


                while (true)
                {
                    Console.Write("> ");
                    input = Console.ReadLine();
                    if (input == "start")
                    {
                        break;
                    }
                    else if (input == "exit")
                    {
                        return;
                    }
                }


                while (true)
                {
                    Console.Write("> ");
                    input = Console.ReadLine();
                    if (input == "stop")
                    {
                        break;


                    }
                    journal += input + "\n";
                }

                using (StreamWriter sw = new StreamWriter("./" + DateTime.UtcNow.Date.ToString("dd_MM_yyyy") + ".txt"))
                {
                    try
                    {

                        sw.WriteLine("Captain's log");
                        sw.WriteLine("Startdate " + DateTime.UtcNow.Date.ToString("dd-MM-yyyy"));
                        sw.Write(journal);
                        sw.Write("Jean-Luc Picard");


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Failed to write to my space journal. It said {0}", e.Message);
                    }
                }
            }
        }
    }
}

