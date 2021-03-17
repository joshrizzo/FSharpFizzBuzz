module FizzBuzzTestCountHelpers

let private startsWithIndexPlusOne (items: seq<string>) (item: string) = 
  Seq.findIndex ((=) item) items + 1 |> string
  |> item.IndexOf = 0

let allStartWithIndexPlusOne items = 
  Seq.forall (startsWithIndexPlusOne items) items