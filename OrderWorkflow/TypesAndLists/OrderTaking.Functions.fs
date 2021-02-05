module OrderTakingFunctions

open OrderTakingTypes

    let doubleQuantity orderQuantity =
        match orderQuantity with
        | UnitQuantity unitQuantity ->
            (decimal)(unitQuantity * 2)
        | KilogramQuantity kilogramQuantity ->
            kilogramQuantity * 2.0m

    let convertToAnotherCurrency convertFromPayment convertToCurrency =
        let convertRatio = 8.0m
        let convertedAmount = convertFromPayment.Amount * convertRatio
        let convertedPayment = { Amount=convertedAmount; Currency=convertToCurrency; Method=convertFromPayment.Method }
        convertedPayment
        
