module CurrencyConverterTests

open Xunit
open CurrencyConverter
open CurrencyConverterUSD
open OrderTakingTypes

[<Fact>]
let ``Convert from USD to NOK`` () =
    let paymentAmount = 4.0m
    let paymentInUSDCash = { Amount=paymentAmount; Currency=USD; Method=Some(Cash) }
    let expected = 32.0m

    let actual = convertFromUSDToAnotherCurrency paymentInUSDCash NOK

    Assert.Equal(expected, actual.Amount)

[<Fact>]
let ``Convert from USD to EUR`` () =
    let paymentAmount = 4.0m
    let paymentInUSDCash = { Amount=paymentAmount; Currency=USD; Method=Option.None }
    let expected = 3.320m

    let actual = convertFromUSDToAnotherCurrency paymentInUSDCash EUR

    Assert.Equal(expected, actual.Amount)
    
[<Fact>]
let ``No conversion USD -> USD`` () =
    let paymentAmount = 4.0m
    let visaCardNumber = CardNumber "Visa"
    let visaCreditCard = Card visaCardNumber
    let paymentInUSDCash = { Amount=paymentAmount; Currency=USD; Method=Some(visaCreditCard) }
    let expected = 4.0m

    let actual = convertFromUSDToAnotherCurrency paymentInUSDCash USD

    Assert.Equal(expected, actual.Amount)

[<Fact>]
let ``Convert from USD to NOK using ConvertPaymentCurrency type`` () =
    let paymentAmount = 4.0m
    let paymentInUSDCash = { Amount=paymentAmount; Currency=USD; Method=Some(Cash) }
    let expected = {Amount = 32.0m; Currency=NOK; Method=Some(Cash) }

    let actual = ConvertPaymentCurrency paymentInUSDCash NOK 

    Assert.Equal(expected, actual)
    

