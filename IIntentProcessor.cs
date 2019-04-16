using Amazon.Lambda.Core;
using Amazon.Lambda.LexEvents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookHotel
{
    /// Represents an intent processor that the Lambda function will invoke to process the event.
    public interface IIntentProcessor
    {
        /// Main method for processing the Lex event for the intent.
        LexResponse Process(LexEvent lexEvent, ILambdaContext context);
    }
}
