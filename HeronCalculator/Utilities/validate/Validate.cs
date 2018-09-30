using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HeronCalculator.Utilities.validate
{
    class Validate
    {
        public string ValidateFirstSide(string txt)
        {
            Regex regex = new Regex(@"^-?[0-9][0-9,\.]+$");
            if (string.IsNullOrWhiteSpace(txt))
            {
                return MapError.mapError["firstSide"].ErrEmpty;
            }

            if (regex.IsMatch(txt))
            {
                if (Double.Parse(txt) < 0)
                {
                    return MapError.mapError["firstSide"].ErrPositiveNum;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return MapError.mapError["firstSide"].ErrCharacter;
            }
        }

        public string ValidateSecondSide(string txt)
        {
            Regex regex = new Regex(@"^-?[0-9][0-9,\.]+$");
            if (string.IsNullOrWhiteSpace(txt))
            {
                return MapError.mapError["secondSide"].ErrEmpty;
            }

            if (regex.IsMatch(txt))
            {
                if (Double.Parse(txt) < 0)
                {
                    return MapError.mapError["secondSide"].ErrPositiveNum;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return MapError.mapError["secondSide"].ErrCharacter;
            }
        }

        public string ValidateThirdSide(string txt)
        {
            Regex regex = new Regex(@"^-?[0-9][0-9,\.]+$");
            if (string.IsNullOrWhiteSpace(txt))
            {
                return MapError.mapError["thirdSide"].ErrEmpty;
            }

            if (regex.IsMatch(txt))
            {
                if (Double.Parse(txt) < 0)
                {
                    return MapError.mapError["thirdSide"].ErrPositiveNum;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return MapError.mapError["thirdSide"].ErrCharacter;
            }
        }
    }
}
