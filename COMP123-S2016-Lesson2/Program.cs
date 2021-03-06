﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * 
 * Author: Christopher Ritchil 
 * Date: May 17, 2016
 * Date Modified: May 17, 2016
 * Description: Advance Method Demo for Lesson 2
 * 
 * Version: 0.0.4 - Added readUntilEnd - not completed
 * 
 */



namespace COMP123_S2016_Lesson2
{
    /**
    * Main driver class for Lesson 2
    * 
    * @class Program
    */
    public class Program
    {
        /**
         * 
         * Main method for our drive class 
         * 
         * @constructor Main
         * @param {string[]} args
         * 
         */
        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;
            int result = 0; 

            result = addXandY(x, y); 
            Console.WriteLine(result);
            Console.WriteLine();

            addYtoX(ref x, ref y);

            Console.WriteLine(x);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(readUntilEnd());

        }

        /**
         * Simple method to add two values
         * 
         * @method addXandY
         * @param {int} fNum
         * @param {int} sNum
         * 
         */
        public static int addXandY(int fNum, int sNum)
        {
            int result = 0;
            result = fNum + sNum; 
            return result; 
        }

        /**
         * Simple method to demonstrate pass by ref keyword
         * 
         * @method addYtoX
         * @param {ref int} X
         * @param {ref int} Y
         */
        public static int addYtoX(ref int X, ref int Y)
        {
            X += Y;

            return X; 
        }

        public static string[] readUntilEnd()
        {
            string[] inputs = new string[50];
            int inputCounter = 0;


            do
            {
                Console.WriteLine("Enter a value - ('end' to stop)"); 
                inputs[inputCounter] = Console.ReadLine();
                if(inputs[inputCounter]=="end")
                {
                    inputCounter = -1; 
                }else
                {
                    inputCounter++; 
                }
            } while (inputCounter != -1); 

            return inputs; 
        }
    }
}
