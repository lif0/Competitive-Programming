//https://www.codewars.com/kata/5a045fee46d843effa000070/train/fsharp

let sieveOfEratosthenes n =
    let input = Array.init<int> (n-1) (fun x -> 2+x)
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
    
let rec findDegree n div acc =
    if n = 0 then acc
    else
        let result = n/div
        findDegree result div (acc+result)
    
let decomp n =
    sieveOfEratosthenes n
    |> Array.fold(fun state input ->
        match findDegree n input 0 with
        | degree when degree = 1 && state="" -> sprintf "%i" input
        | degree when degree = 1 -> sprintf "%s * %i" state input
        | degree when state="" -> sprintf "%i^%i" input degree
        | degree -> sprintf "%s * %i^%i" state input degree
     ) ""
    
    
//Tests
decomp 17 = "2^15 * 3^6 * 5^3 * 7^2 * 11 * 13 * 17"              &&
decomp 5  = "2^3 * 3 * 5"                                        &&
decomp 22 = "2^19 * 3^9 * 5^4 * 7^3 * 11^2 * 13 * 17 * 19"       &&
decomp 14 = "2^11 * 3^5 * 5^2 * 7^2 * 11 * 13"                   &&
decomp 25 = "2^22 * 3^10 * 5^6 * 7^3 * 11^2 * 13 * 17 * 19 * 23"  