module FizzBuzz

let private getOutput i rules : string = 
  Seq.map (fun rule -> rule i) rules
  |> String.concat ""
  |> sprintf "%d %s" i

let run limit rules = [for i = 1 to limit do getOutput i rules]