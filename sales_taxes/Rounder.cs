using System;
//using System.Math;
using sales_taxes.Models;

namespace sales_taxes 
{
    public class Rounder : IRounder 
    {
        public double RoundItem(double prc) 
        {
            //int val = 2 + (int)(prc * 100);
            //int remainder = val % 5;
            //return ((float)(val - remainder)) / 100f;

            return Math.Ceiling(prc * 2) / 2;

        }

    }
}