using System;

namespace ClientMinus.Models.MinusStore
{
    /// <summary>
    /// Dayly download-stat for minuses to range them in time.
    /// </summary>
    public class MinusStats
    {
        public DateTime Date { get; set; }

        public int Rate { get; set; }

        public object Minus { get; set; }

    }
}