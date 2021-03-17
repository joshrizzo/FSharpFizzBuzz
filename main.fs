TestRunner.runAll 

printfn "\nOutput: "
for item in FizzBuzz.run 25 FizzBuzzDefaultRules.rules do
  printfn "  %s" item
