﻿// For more information see https://aka.ms/fsharp-console-apps
// Learn more about F# at http://learn.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main _argv =
    let message = from "F#" // Call the function
    printfn "Hello world %s" message
    0 // return an integer exit code