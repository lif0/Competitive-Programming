//https://www.codewars.com/kata/609eee71109f860006c377d1/train/fsharp


type State = {
    letter:string
    offset:int
}
//При условии что coords всегда отсортирован!
let lastSurvivor (letters : string) (coords : int list) : string =
    coords 
    |> List.fold (fun state index -> state.Remove(index,1)) letters
    
