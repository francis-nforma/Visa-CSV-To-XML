using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertCSVToXML
{
    interface IResult
    {
        bool isSuccessful { get; }
        void addFailure(string field, string failuremessage);
        void addWarning(string field, string warningmessage);
        int FailureCount { get; }
        string getFailureMessage(int index);
        string getField(int index);
        void addResultMessage(string logMessage);
        string ResultMessage { get; }
        void displayMessage();
    }
}
