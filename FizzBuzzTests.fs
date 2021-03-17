module FizzBuzzTests

let runShouldShowAllEntries listSize outputs =
  Seq.length outputs = listSize
  |> AssertHelpers.assertString "Output size should match the requested size."

let runShouldStartWithNumbers (outputs: seq<string>) =
  FizzBuzzTestCountHelpers.allStartWithIndexPlusOne outputs
  |> AssertHelpers.assertString "Outputs should start with their index."

let multiplesOfThreeShouldPrintFizz outputs =
  FizzBuzzTestHelpers.standardRuleTest 3 "Fizz" outputs

let multiplesOfFiveShouldPrintBuzz outputs =
  FizzBuzzTestHelpers.standardRuleTest 5 "Buzz" outputs