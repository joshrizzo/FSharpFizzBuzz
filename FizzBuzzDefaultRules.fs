module FizzBuzzDefaultRules

let rules = [
  fun i -> if i % 3 = 0 then "Fizz" else ""
  fun i -> if i % 5 = 0 then "Buzz" else ""
  fun i -> if i % 7 = 0 then "Wizz" else ""
]