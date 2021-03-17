module FizzBuzz

let private getOutput i rules : string = 
  let matches = List.map (fun rule -> rule i)
  let output = String.concat "" matches
  $"{(string i)} {output}"

let run limit rules = [for i = 1 to limit do getOutput i rules]