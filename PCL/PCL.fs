namespace PCL

open System
open System.Runtime.CompilerServices

module Lib =

    // This is the current workaround:
    // [<MethodImplAttribute(MethodImplOptions.NoInlining)>]
    let year (dt: DateTime) =
        dt.Year
