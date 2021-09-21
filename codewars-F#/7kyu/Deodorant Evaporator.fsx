//https://www.codewars.com/kata/5506b230a11c0aeab3000c1f/train/fsharp

let evaporator (content: double) (evapPerDay: double) (threshold: double) =
  let threshold = (threshold * content / 100.0) 
  let rec loop ct day =
    match ct with
    | _ when ct <= threshold -> day
    | _ -> loop (ct - (evapPerDay * ct / 100.0)) (day + 1)
    
  loop content 0
  
  
evaporator 10.0 10.0 5.0 = 29