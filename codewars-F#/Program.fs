open System
open Problems

[<EntryPoint>]
let main argv =
    Greed_is_Good.score [1;1;1;3;1] |> printfn "%A"
    printfn "Hello World from F#!"
    0 // return an integer exit code
    

    
