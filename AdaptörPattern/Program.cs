﻿using AdaptörPattern.Lab1.Abstratct;
using AdaptörPattern.Lab1.Concrete;
using System;

namespace AdaptörPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uyarlayici  uyarlayici = new Uyarlayici();
            Console.WriteLine(uyarlayici.SpecialRequest(5, 3));
            ITarget target = new Adaptor();
            Console.WriteLine(target.Request(5));

        }
    }
}
