﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPAM1.Wagons.Interfaces;

namespace EPAM1.Wagons
{
    public class TankWagon : IGoodsWagon
    {
        public TankWagon(int wagonCapacity, int elementsAmount)
        {
            WagonCapacity = wagonCapacity;
            ElementsAmount = elementsAmount;
        }

        public int WagonCapacity { get; }

        public int ElementsAmount { get; }

        public int ElementCount()
        {
            return ElementsAmount;
        }
    }
}
