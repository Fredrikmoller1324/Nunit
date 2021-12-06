using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public interface ILogMessagesRepository
    {
        public void SuccessLogMessage();
        public void UnsuccessfullLogMessage();
        public void AttemptToProcess();
    }
}
