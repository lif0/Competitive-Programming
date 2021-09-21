//https://www.codewars.com/kata/5270d0d18625160ada0000e4

let private getPoints = function
| 1   -> 100
| 5   -> 50
| 111 -> 1000
| 666 -> 600
| 555 -> 500
| 444 -> 400
| 333 -> 300
| 222 -> 200
| _ -> 0

let private calcPoints num len = 
    let packs = len/3
    let remainderPoints = (len - (packs*3)) * (getPoints num)
    if packs >= 1 then
        let pnum = num*100+ num*10 + num
        ( packs * (getPoints pnum) ) + remainderPoints
    else remainderPoints

let score (dice: int list) =
    dice
    |> Seq.groupBy (fun x-> x)
    |> Seq.fold(fun acc (num, list) ->
        list
        |> Seq.length
        |> calcPoints num
        |> (+) acc
    ) 0 