module OrderTakingTests

open Xunit
open OrderTakingFunctions
open OrderTakingTypes

[<Fact>]
let ``Convert from USD to NOK`` () =
    let paymentAmount = 4.0m
    let paymentInUSDCash = { Amount=paymentAmount; Currency=USD; Method=Cash }
    let expected = 32.0m

    let actual = convertToAnotherCurrency paymentInUSDCash NOR

    Assert.Equal(expected, actual.Amount)
