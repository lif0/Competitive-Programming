//https://www.codewars.com/kata/5700c9acc1555755be00027e/train/fsharp

open System

let rotateLetter (input:string) (offset:int) =
    input
        .Insert(input.Length, input.Substring(0, offset))
        .Remove(0, offset)

let containAllRots strng a =
  if strng = "" 
    then true
    else 
      let allRotations = List.init strng.Length (fun i -> rotateLetter strng (i+1))
      List.except a allRotations |> List.isEmpty
      
containAllRots "bsjq" ["bsjq"; "qbsj"; "sjqb"; "twZNsslC"; "jqbs"] = true
containAllRots "Ajylvpy" ["Ajylvpy"; "ylvpyAj"; "jylvpyA"; "lvpyAjy"; "pyAjylv"; "vpyAjyl"; "ipywee"] = false
