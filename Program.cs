using System;
using System.Collections.Generic;
using System.Linq;

namespace Tutorial5
{
    /**
     * Author: Kaifkhan Vakil
     * Date: 20th January 2021
     * Description: This program is demonstrating the use of overloaded operators and their conversion. We are making a list of type Box class
     * which will be containing 10 different box objects and all of them have different dimensions. And then i made a function namely sort volume
     * which will be ordering my volume in the proper manner as i want them to and then output them using Foreach function.
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Making a list of type box to store different objects from box class.
            List<Box> listOfBoxes = new List<Box>();

            //Defining different box objects with different parameter values.
            Box box1 = new Box(12.34, 34.45, 14.63);
            Box box2 = new Box(56.76, 157.56, 89.78);
            Box box3 = new Box(19.56, 145.67, 12.78);
            Box box4 = new Box(45.78, 123.345, 57.84);
            Box box5 = new Box(16.25, 65.15, 658.12);
            Box box6 = new Box(23.14, 48.15, 46.16);
            Box box7 = new Box(164.5, 36.4, 165.46);
            Box box8 = new Box(166.465, 6.5, 65.9);
            Box box9 = new Box(0.59, 35.48, 89.45);
            Box box10 = new Box(64.46, 364.46, 97.49);


            // Adding the objects in the list 
            listOfBoxes.Add(box1);
            listOfBoxes.Add(box2);
            listOfBoxes.Add(box3);
            listOfBoxes.Add(box4);
            listOfBoxes.Add(box5);
            listOfBoxes.Add(box6);
            listOfBoxes.Add(box7);
            listOfBoxes.Add(box8);
            listOfBoxes.Add(box9);
            listOfBoxes.Add(box10);
            
            
            //This is the sort volume function which will be sorting our box list using a linq query for box volume
            static List<Box> SortVolume(List<Box> listOfBoxes)
            {
                List<Box> boxSorted = new List<Box>(listOfBoxes.OrderBy(s => s.boxVolume()));

                return boxSorted;

            }


            // We are making another list in which we will be adding sorted list of list of boxes and then outputting them using for each function.
            List<Box> boxList = SortVolume(listOfBoxes);
            Console.WriteLine("Volume of all the boxes in sorted manner so using sort volume function: \n");
            boxList.ForEach(Console.WriteLine);


        }
    }
}
