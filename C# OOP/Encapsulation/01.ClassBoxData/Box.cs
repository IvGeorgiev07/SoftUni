using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassBoxData
{
    internal class Box
    {
		private double length;
        private double width;
        private double height;

        public Box(double length,double width,double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

		public double Length
        {
			get => length;
			set
			{
				if(value <=0)
				{
					throw new ArgumentException("Length cannot be zero or negative.");
				}
				this.length= value;
			}
		}

        public double Width
        {
            get => width;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get => height;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
           double surfaceArea = 2*length* width + 2* length* height + 2* width * height;
            return surfaceArea;
        }

        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2* length* height + 2* width* height;
            return lateralSurfaceArea;
        }

        public double Volume()
        {
            double volume = length* width* height;
            return volume;
        }
    }
}
