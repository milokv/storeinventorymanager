using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace retailmanagement
{
    internal class InputChecker
    {
        /// <summary>
        /// input checker for verifying correct datatype is used.
        /// takes two arguments, input and type (int).
        ///___________________
        /// types: 1 = string, 2 = int, 3 = bool
        /// _____________________________________________________________________________________
        /// if input does not match type, will return either false (if type 1 or 2) "error" (if type 3)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        
        //just nu inte fungerande, försöker hitta bättre lösning.
        public dynamic inputChecker(string input, int type)
        {
            if (type == 1) { return input; }
            else { return false; }
        }
        public dynamic inputChecker(int input, int type)
        {
            if (type == 2) { return input; }
            else { return false; }
        }
        public dynamic inputChecker(bool input, int type)
        {
            if (type == 3) { return input; }
            else { return "error"; }
        }
    }
}
