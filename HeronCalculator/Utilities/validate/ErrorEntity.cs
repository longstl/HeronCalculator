using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronCalculator.Utilities.validate
{
    class ErrorEntity
    {
        private string errCharacter;
        private string errLenght;
        private string errEmpty;
        private string errPositiveNum;

        public ErrorEntity(string errCharacter, string errLenght, string errEmpty, string errPositiveNum)
        {
            this.errCharacter = errCharacter;
            this.errLenght = errLenght;
            this.errEmpty = errEmpty;
            this.errPositiveNum = errPositiveNum;
        }

        public string ErrCharacter { get => errCharacter; set => errCharacter = value; }
        public string ErrLenght { get => errLenght; set => errLenght = value; }
        public string ErrEmpty { get => errEmpty; set => errEmpty = value; }
        public string ErrPositiveNum { get => errPositiveNum; set => errPositiveNum = value; }
    }
}
