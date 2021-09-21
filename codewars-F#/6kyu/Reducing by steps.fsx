//https://www.codewars.com/kata/56efab15740d301ab40002ee/train/fsharp

let sum = (+)
let mini = min
let maxi = max
let rec gcd a b = if b = 0 then a else gcd b (a%b)
let lcm a b = a * b / gcd a b
let inline lcmu x y = lcm (abs(x)) (abs(y))
let inline gcdi x y = gcd (abs(x)) (abs(y))

let operArray (fct:int->int->int) (arr:int list) init =
    let rec loop (acc:int list) i  =
        if arr.Length = i then acc
        elif acc.Length > 0 then loop ([fct acc.[i-1] arr.[i]] |> List.append acc) (i+1)
        else loop ([fct init arr.[i]] |> List.append acc) (i+1)
        
    loop List.empty<int> 0        

//Tests
operArray sum [18; 69; -90; -78; 65; 40] 0 = [18; 87; -3; -81; -16; 24]

operArray sum [2; 4; 6; 8; 10; 20] 0 = [2; 6; 12; 20; 30; 50]