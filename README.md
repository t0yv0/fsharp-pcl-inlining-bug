fsharp-pcl-inlining-bug
=======================

Demonstrates issues with inlining small methods from PCL to normal F# assembly.

To reproduce, please do "./run.cmd" on a Windows machine with F# tools installed. Compilation should succeed but there is a `MissingMethodException` at runtime.
