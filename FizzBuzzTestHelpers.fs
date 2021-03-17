module FizzBuzzTestHelpers

let private indexIsMultipleOf step items item = 
  ((Seq.findIndex ((=) item) items) + 1) % step = 0

let private getMultiplesOf step items = 
  Seq.filter (indexIsMultipleOf step items) items

let private getNonMultiplesOf step items = 
  Seq.filter (not << indexIsMultipleOf step items) items

let private includesStr (str: string) (item: string) = 
  item.IndexOf str > 0

let private allIncludeStr str items = 
  Seq.forall (includesStr str) items

let private noneIncludeStr str items = 
  Seq.forall (not << includesStr str) items

let private allMultiplesIncludeStr step str items = 
  getMultiplesOf step items |> allIncludeStr str

let private allNonMultiplesDoNotIncludeStr step str items = 
  getNonMultiplesOf step items |> noneIncludeStr str

let standardRuleTest step str outputs = 
  if (not <| allMultiplesIncludeStr step str outputs) then
    AssertHelpers.assertRuleFailed step str false
  else
    allNonMultiplesDoNotIncludeStr step str outputs
    |> AssertHelpers.assertRuleOverstep step str
