using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronCalculator.Utilities.validate
{
    class MapError
    {
        public static  Dictionary<string, ErrorEntity> mapError = new Dictionary<string, ErrorEntity>();

        static MapError()
        {
            ErrorEntity firstSide = new ErrorEntity("Only Positive Number", "","Can not Empty","Input at least great than 0");
            ErrorEntity secondSide = new ErrorEntity("Only Positive Number", "", "Can not Empty", "Input at least great than 0");
            ErrorEntity thirdSide = new ErrorEntity("Only Positive Number", "", "Can not Empty", "Input at least great than 0");

            mapError.Add("firstSide", firstSide);
            mapError.Add("secondSide", secondSide);
            mapError.Add("thirdSide", thirdSide);
        }
    }
}
