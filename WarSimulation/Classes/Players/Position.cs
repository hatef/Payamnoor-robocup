using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hadaf
{
    class Position
    {
        private int health;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        private double x;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        private double y;

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        private double z;

        public double Z
        {
            get { return z; }
            set { z = value; }
        }
        private iTheta theta=new iTheta();

        public iTheta Theta
        {
            get { return theta; }
            set { theta = value; }
        }
    }
    class iTheta
    {
        private double x;

        public  double X
        {
            get { return x; }
            set { x = value; }
        }
        private  double y;

        public  double Y
        {
            get { return y; }
            set { y = value; }
        }
        private  double z;

        public  double Z
        {
            get { return z; }
            set { z = value; }
        }
       
    }
}
