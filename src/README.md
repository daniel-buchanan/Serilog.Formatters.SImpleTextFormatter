# Serilog.Formatting.SimpleTextFormatter

This package is intended to provide a simple text formatter that achieves the following goals:
1. Format messages correctly
2. Output messages on a single line  
   This ensures compatability with AWS CloudWatch
3. Be as lightweight as possible

As such this package consists of a single class: `SimpleTextFormatter`.
It has been put into the `Serilog.Formatting.Display` namespace for consistency with other extensions.

To use this formatter when specifying your sink do the following:  
```csharp
  .WriteTo.Console(formatter: new SimpleTextFormatter())
```

The code is located here: https://github.com/daniel-buchanan/Serilog.Formatting.SimpleTextFormatter