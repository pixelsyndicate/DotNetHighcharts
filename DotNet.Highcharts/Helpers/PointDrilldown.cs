﻿using System.Drawing;

namespace DotNet.Highcharts.Helpers
{
    public class PointDrilldown
    {
        public string Name { get; set; }
        public string[] Categories { get; set; }
        public Data Data { get; set; }
        public Color Color { get; set; }
    }
}