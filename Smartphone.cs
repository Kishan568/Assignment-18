﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppassignment18
{


    public class Smartphone : IConnectable, IRechargeable, IDisplayable
    {
        public string Model { get; set; }
        public bool IsConnected { get; private set; }
        public int BatteryLevel { get; private set; }

        public Smartphone(string model)
        {
            Model = model;
            IsConnected = false;
            BatteryLevel = 0;
        }

        public bool Connect()
        {
            IsConnected = true;
            Console.WriteLine($"Smartphone {Model} is connected.");
            return true;
        }

        public void Charge(int minutes)
        {
            BatteryLevel += minutes;
            Console.WriteLine($"Smartphone {Model} is charged for {minutes} minutes. Battery level: {BatteryLevel}%");
        }

        public string Display()
        {
            return $"Smartphone {Model} display information: ...";
        }
    }
}