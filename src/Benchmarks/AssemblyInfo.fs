namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Benchmarks")>]
[<assembly: AssemblyProductAttribute("Benchmarks")>]
[<assembly: AssemblyDescriptionAttribute("A collection of my benchmarks")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
