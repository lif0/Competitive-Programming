//https://www.codewars.com/kata/57a1d5ef7cb1f3db590002af/train/fsharp

let fib n =
  let rec loop a b i=   
      match n with
      | 0 -> 0
      | 1 -> 1
      | _ when i = n -> b
      | _ -> 
          let c = a
          let a = b
          let b = c + a
          loop a b (i+1)
          
  loop 0 1 1
  
fib 1 = 1 &&
fib 2 = 1 &&
fib 3 = 2 &&
fib 4 = 3 &&
fib 5 = 5