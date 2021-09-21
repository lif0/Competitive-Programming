//https://www.codewars.com/kata/5726f813c8dcebf5ed000a6b/train/fsharp
   
//let sieveOfEratosthenes (input:int[]) =
//    let rec findNextIndex index (input:int[]) =
//        if index > input.Length-1 then input.Length
//        elif input.[index] <> -1 then input.[index]
//        else findNextIndex (index + 1) input
//    
//    let rec loop (input:int[]) lastIndex =
//        if lastIndex >= input.Length then input |> Array.filter(fun x -> x <> -1)
//        else
//            let p = input.[lastIndex]
//            let startIndex = (pown p 2) - 2(*offset 0,1*)
//            for i in startIndex..p..input.Length-2 do
//                if input.[i] % p = 0 then input.[i] <- -1
//                
//            
//            loop input (input |> findNextIndex (lastIndex+1))
//            
//    loop input 0

//NOT RESOLVED!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
let sieveOfEratosthenes (input:int[]) =
    let rec findNextIndex index (input:int[]) =
        if index > input.Length-1 then input.Length
        elif input.[index] <> -1 then index
        else findNextIndex (index + 1) input
    
    let rec loop (input:int[]) lastIndex =
        if lastIndex >= input.Length then input |> Array.filter(fun x -> x <> -1)
        else
            let p = input.[lastIndex]
            let startIndex = (pown p 2) - 2(*offset 0,1*)
            for i in startIndex..p..input.Length-1 do
                if input.[i] % p = 0 then input.[i] <- -1
            loop input (input |> findNextIndex (lastIndex+1))
            
    loop input 0
  
let countKprimes (k:int) (start:int) (nd:int) =
    let start = if start = 0 then 2 else start
    //let input = Array.init<int> (nd-start) (fun x -> start+x)
    let input = Array.init<int> (nd-1) (fun x -> 2+x)
    let res = sieveOfEratosthenes input
    
    let res = res |> Array.filter(fun x -> x > start)
    
    res
    

//let puzzle s =
//    // your code


Array.init<int> 29 (fun x -> 2+x) |> sieveOfEratosthenes = [|2;3;5;7;11;13;17;19;23;29|]