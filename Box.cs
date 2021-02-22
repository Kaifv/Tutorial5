using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Tutorial5
{
    class Box
    {
        /**
         * A public variable used for storing the length of box
         */
        private double length;

        /**
         * A public variable used for storing the width of the box
         */
        private double width;

        /**
         * A public variable used for storing the height of the box
         */

        private double height;


        /**
         * A public constructor which will be called whenever the object is instantiated which just returns the value of all the variables
         */
        public Box(double length, double width, double height)
        {
            this.height = height;
            this.length = length;
            this.width = width;
        }

        /**
         * A getter for getting the length of the variable
         */
        public double getLength()
        {
            return this.length;
        }

        /**
         *  A getter for getting the width of the box 
         */
        public double getWidth()
        {
            return this.width;
        }

        /**
         * A getter for getting the height of the box
         */
        public double getHeight()
        {
            return this.height;
        }

        /**
         * A setter for setting up the length of the box
         */
        public void setLength(double value)
        { 
            this.length = value;
        }

        /**
         * A setter for setting up the width of the box
         */
        public void setWidth(double value)
        { 
            this.width = value;
        }


        /**
         * A setter for setting up the height of the box
         */
        public void setHeight (double value)
        {
            this.height = value;
        }

        /**
         * Box volume function will be used to get the volume of the box using the public variables from the constructor.
         */
        public double boxVolume()
        {
            double volume = length * width * height;
            return Math.Round(volume, 2);
        }


        /**
         * Overloaded operator for greater than equal to which will be returning true if one boc volume is i greater than or equal to other. 
         */
        public static bool operator >=(Box box1, Box box2)
        {
            if(box1.boxVolume() >= box2.boxVolume())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /**
         * Overloaded operator for less than equal to which will be returning true if one box volume is greater than or equal to other.
         */
        public static bool operator <=(Box box1, Box box2)
        {
            if (box1.boxVolume() >= box2.boxVolume())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /**
         * Overloaded operator for equal to which will be returning true if volume of one box is equal to other
         */
        public static bool operator ==(Box box1, Box box2)
        {
            if(box1.boxVolume() == box2.boxVolume())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /**
         * Overloaded operator for equal to which will be returning true if volume of one box is not equal to other
         */
        public static bool operator !=(Box box1, Box box2)
        {
            if (box1.boxVolume() != box2.boxVolume())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /**
         * A public to string method for outputting in proper manner.
         */
        public override string ToString()
        {
            return "Box with the volume of " + boxVolume() + "\n";
        }
    }
}
