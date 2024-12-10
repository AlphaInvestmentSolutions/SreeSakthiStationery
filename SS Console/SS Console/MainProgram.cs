using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V128.Debugger;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_Console
{
    internal class MainProgram
    {

        public static void Main(string[] args)
        {
            
            PrintXeroxModel Pxd = new PrintXeroxModel();
            Console.Clear();
            Console.WriteLine("1.Update Print and Xerox\n2.Counter\n3.Exit");
            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("1.\u001b[4mU\u001b[0mpdate All\n2.By \u001b[4mF\u001b[0munction\n3.By \u001b[4mP\u001b[0mapersize\n4.By Paper\u001b[4mS\u001b[0mackaving\n5.S\u001b[4mc\u001b[0mackanner Data\n6.\u001b[4mB\u001b[0mack");
                    switch (Console.ReadLine().ToUpper())
                    {
                        case "U":
                            Console.WriteLine("U pressed");
                            Pxd.PrintXeroxNavigation();
                            Pxd.PrintXeroxByFunction(Pxd.PrintXeroxNavigation());
                            Pxd.PrintXeroxByPapersize(Pxd.PrintXeroxNavigation());
                            Pxd.PrintXeroxByPaperSaving(Pxd.PrintXeroxNavigation());
                            Pxd.ScanningData(Pxd.PrintXeroxNavigation());
                            
                            break;
                        case "F":
                            Console.WriteLine("F pressed");
                            Pxd.PrintXeroxNavigation();
                            Pxd.PrintXeroxByFunction(Pxd.PrintXeroxNavigation());
                            break;
                        case "P":
                            Console.WriteLine("P pressed");
                            Pxd.PrintXeroxNavigation();
                            Pxd.PrintXeroxByPapersize(Pxd.PrintXeroxNavigation());
                            break;
                        case "S":
                            Console.WriteLine("S is pressed");
                            Pxd.PrintXeroxNavigation();
                            Pxd.PrintXeroxByPaperSaving(Pxd.PrintXeroxNavigation());
                            break;
                        case "C":
                            Pxd.PrintXeroxNavigation();
                            Pxd.ScanningData(Pxd.PrintXeroxNavigation());
                            break;
                        case "B":
                            Main(args);
                            break;
                        default:
                            Console.WriteLine("enter any valid numbers shown above");
                            break;

                    }
                    //PrintXeroxModel Pxd = new PrintXeroxModel();
                    //Pxd.PrintXeroxNavigation();
                    //Pxd.PrintXeroxByFunction();
                    //Pxd.PrintXeroxByPapersize();
                    //Pxd.PrintXeroxByPaperSaving();
                    //Pxd.ScanningData();
                    //Console.Clear();
                    break;
                case 2: //Counter();
                    break;
                case 3:
                    System.Environment.Exit(0);
                    break;
            }
           Main(args);
            




        }
    }
}
