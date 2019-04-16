using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization;
using Amazon.Lambda.LexEvents;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializerAttribute(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace BookHotel
{
    public class Function
    {

       
        public LexResponse FunctionHandler(LexEvent lexEvent, ILambdaContext context)
        {
            IIntentProcessor process;

            switch (lexEvent.CurrentIntent.Name)
            {
                case "BookHotel":
                    process = new BookHotelIntentProcessor();
                    break;
                default:
                    throw new Exception($"Intent with name {lexEvent.CurrentIntent.Name} not supported");
            }


            return process.Process(lexEvent, context);
        }

    }
}
