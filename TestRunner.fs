module TestRunner

let runAll = 
  printfn "Tests:"

  let listSize = 100
  let defaultRun = FizzBuzz.run listSize FizzBuzzDefaultRules.rules

  let errors = Seq.filter (isNull >> not) [
    FizzBuzzTests.runShouldShowAllEntries listSize defaultRun
    FizzBuzzTests.runShouldStartWithNumbers defaultRun
    FizzBuzzTests.multiplesOfThreeShouldPrintFizz defaultRun
    FizzBuzzTests.multiplesOfFiveShouldPrintBuzz defaultRun
    FizzBuzzTestHelpers.standardRuleTest 7 "Wizz" defaultRun
  ]
  
  if Seq.length errors = 0 then printfn "  All passed!"
  else for error in errors do printfn "  %s" error
