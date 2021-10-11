module CurrencyConverter

open OrderTakingTypes

    // Type that represent functions ie. behavior
    // Convert payment from one currency to another
    // First parameter is input of type payment, the second parameter is input of type Currency and the second payment is the output
    type ConvertPaymentCurrency = Payment -> Currency -> Payment

    let ConvertPaymentCurrency convertFromPayment convertToCurrency =

        let convertedAmount = 
            match convertToCurrency with
            | USD ->
                convertFromPayment.Amount
            | NOK ->
                convertFromPayment.Amount * 8.0m
            | EUR ->
                convertFromPayment.Amount * 0.83m
        let convertedPayment = { Amount=convertedAmount; Currency=convertToCurrency; Method=convertFromPayment.Method }
        convertedPayment