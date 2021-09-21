//https://www.codewars.com/kata/513e08acc600c94f01000001/train/fsharp

let inline (^) f c = f <| c
let toHex (x:int) = x.ToString("X4").Remove(0,2)

let inline fixColor c = if c > 255 then 255 elif c < 0 then 0 else c
        
let rgb r g b = sprintf "%s%s%s" (toHex ^ fixColor r) (toHex ^ fixColor g) (toHex ^ fixColor b)
    