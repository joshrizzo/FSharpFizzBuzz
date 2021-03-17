module FizzBuzz

let private getOutput i rules : string = 
  let matches = Seq.map (fun rule -> rule i) rules
  let output = String.concat "" matches
  $"{(string i)} {output}"

let run limit rules = [for i = 1 to limit do getOutput i rules]