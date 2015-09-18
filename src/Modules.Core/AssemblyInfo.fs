namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Modules.Core")>]
[<assembly: AssemblyProductAttribute("Modules.Core")>]
[<assembly: AssemblyDescriptionAttribute("Modules with interchangeable "source mode" and "binary mode"")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
