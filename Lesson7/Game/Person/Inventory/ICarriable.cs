using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    public interface ICarriable
    {
        public int Weight { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
    }
}
