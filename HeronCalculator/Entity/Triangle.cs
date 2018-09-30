using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronCalculator.Entity
{
    class Triangle
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public double firstSide { get => _firstSide; set => _firstSide = value; }
        public double secondSide { get => _secondSide; set => _secondSide = value; }
        public double thirdSide { get => _thirdSide; set => _thirdSide = value; }
    }
}
