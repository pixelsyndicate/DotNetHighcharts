using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
    /// <summary>
    /// The values on a heat map are plotted against a color axis. 
    /// </summary>
    public class ColorAxis
    {
        /// <summary>
        /// The minimum value of the axis in terms of map point values. If null, the min value is automatically calculated.
        /// </summary>
        public Number? Min { get; set; }

        //public string MinColor { get; set; }

        //public string MaxColor { get; set; }
        /// <summary>
        /// The color to represent the minimum of the color axis. Defaults to #EFEFFF.
        /// </summary>
        public Color? MinColor { get; set; }
        /// <summary>
        /// The color to represent the maximum of the color axis. Defaults to #102D4C.
        /// </summary>
        public Color? MaxColor { get; set; }
    }
}
