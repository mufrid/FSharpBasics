module CurrencyConverter

open OrderTakingTypes

    let convertFromUSDToAnotherCurrency convertFromPayment convertToCurrency =

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