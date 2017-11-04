using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hadaf
{
    class Mathematics
    {
        public static double Distance(Position p1,Position p2)
        {
            double diff_y = p2.Y - p1.Y
           ,diff_x = p2.X - p1.X,
           pow_x=Math.Pow(diff_x,2),
           pow_y=Math.Pow(diff_y,2);
            return Math.Sqrt(pow_x +pow_y);
        }
        public static double Degree(Position p)
        {
            double deg = Math.Atan2(p.Theta.Y, p.Theta.X);
            return (deg*180)/Math.PI;
        }

        public static bool isNegative(double inp)
        {
            return (Math.Sign(inp) == -1) ? true : false;
        }
        public static double DegreeToOpp(Position p1, Position p2)
        {
            double diff_y = p2.Y - p1.Y
            , diff_x = p2.X - p1.X
            , t_XY = Math.Atan2(diff_y, diff_x)
            ,Result=(t_XY*180)/Math.PI;
            return Result;

        }
       
        public static bool IsEqual(double d1, double d2,double t)
        {
            if (d1 > (d2 - t) && d1 < (d2 + t))
            {
                return true;
            }
            return false;
        }
        public static double PIToDegree(double pi)
        {
            return (pi * 180) / Math.PI;
        }
        public static double getSlope(double x1, double y1, double x2, double y2)
        {
            double diff_y = (y2 - y1);
            double diff_x = (x2 - x1);
            double diff = diff_y / diff_x;
            double deg = PIToDegree(Math.Atan(diff));
            int portion = getPortion(x1, y1, x2, y2);
            int sum = 180 * (int)Math.Floor((double)(portion / 2));
            deg += sum;
            return deg;
        }
        public static double getSlope(Position p1, Position p2)
        {
            return getSlope(p1.X, p1.Y, p2.X, p2.Y);
        }
        public static int getPortion(double x1, double y1, double x2, double y2)
        {
            double diff_y = y2 - y1;
            double diff_x = x2 - x1;

            if (diff_y > 0)
                if (diff_x > 0)
                    return 1;
                else
                    return 2;
            else
                if (diff_x < 0)
                    return 3;
                else
                    return 4;
        }
        public static int getPortion(Position p1, Position p2) 
        {
            return getPortion(p1.X, p1.Y, p2.X, p2.Y);
        }
    }
}
