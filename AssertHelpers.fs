module AssertHelpers

let assertString message passed =
  if passed then null else message

let assertRuleFailed step str passed = 
  assertString $"Multiples of {step} should print \"{str}\"" passed

let assertRuleOverstep step str passed = 
  assertString $"Non-multiples of {step} should NOT print \"{str}\"" passed