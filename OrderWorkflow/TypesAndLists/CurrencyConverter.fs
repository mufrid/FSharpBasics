module CurrencyConverter

open OrderTakingTypes

    let convertToAnotherCurrency convertFromPayment convertToCurrency =
        let convertRatio = 8.0m
        let convertedAmount = convertFromPayment.Amount * convertRatio
        let convertedPayment = { Amount=convertedAmount; Currency=convertToCurrency; Method=convertFromPayment.Method }
        convertedPayment

