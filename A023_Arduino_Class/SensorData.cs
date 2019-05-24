﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arduino_Class1
{
  class SensorData
  {
    public string Date { get; set; }
    public string Time { get; set; }
    public int Value { get; set; }

    // 생성자메서드
    public SensorData(string d, string t, int v)
    {
      Date = d;
      Time = t;
      Value = v;
    }
  }
}
