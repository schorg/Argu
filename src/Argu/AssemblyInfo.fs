﻿namespace System
open System.Reflection

[<assembly: AssemblyVersionAttribute("1.1.3")>]
[<assembly: AssemblyFileVersionAttribute("1.1.3")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.1.3"
