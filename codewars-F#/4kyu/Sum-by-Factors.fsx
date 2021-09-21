//https://www.codewars.com/kata/54d496788776e49e6b00052f/train/fsharp

let rec prime_factors (n:int) =
  let res = System.Collections.Generic.List<int>()
  let mutable n = System.Math.Abs(n)
  while n%2=0 do res.Add(2); n <- n/2;
  let mutable j = 3
  while j*j<=n do
    if n%j=0 then res.Add(j); n<-n/j;
    else j <- j+2
  if n<> 1 then res.Add(n)
  res |> Set.ofSeq     

let sumOfDivided(lst: int list): string =
    printfn "%A" lst
    Seq.fold(fun acc n -> 
        prime_factors n
        |> Seq.fold(fun (acc2: Map<int, int>) key -> 
            if not <| acc2.ContainsKey(key) then Map.add key n acc2
            else 
                let oldV = acc2.Item key
                Map.add key (oldV+n) acc2
        ) acc
    ) Map.empty<int, int> lst
    |> Seq.map (fun (kvp) -> sprintf "(%i %i)" kvp.Key kvp.Value)
    |> String.concat ""



[-29804; -4209; -28265; -72769; -31744] |> sumOfDivided |> printfn "%A"