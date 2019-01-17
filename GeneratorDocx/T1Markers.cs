using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneratorDocx
{
    public class T1Markers
    {
        private string typeOfPractice;
        private string institute;
        private string specialty;
        private string department;
        private string studentFIO;
        private string step;
        private string group;
        // TODO add other markers

        public T1Markers(string[] data)
        {
            if ( data != null)
            {
                typeOfPractice = data[0];
                institute = data[1];
                specialty = data[2];
                // TODO add other markers
            }
        }
 
    }
}
