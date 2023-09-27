using System;
using System.IO;
using Serilog.Events;

namespace Serilog.Formatting.Display
{
    public sealed class SimpleTextFormatter : Serilog.Formatting.ITextFormatter
    {
        private const string CarriageReturn = "\r";
        
        public void Format(LogEvent logEvent, TextWriter output)
        {
            var message = logEvent.RenderMessage();
            Write(message, output);

            if (logEvent.Exception == null) return;

            var e = logEvent.Exception;
            Write(e?.Message);
            Write(e?.StackTrace, output);
        }

        private void Write(string input, TextWriter output)
        {
            if(string.IsNullOrWhiteSpace(input)) return;
            var replaced = input.Replace(Environment.NewLine, CarriageReturn);
            output.WriteLine(replaced);
        }
    }
}
