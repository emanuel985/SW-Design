using ReportGenerator.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportgenerator.classes
{
    internal class SetoutputFormat()
    {
        public void SetOutputFormat(ReportOutputFormatType format)
        {
            _currentOutputFormat = format;
        }
    }
}
