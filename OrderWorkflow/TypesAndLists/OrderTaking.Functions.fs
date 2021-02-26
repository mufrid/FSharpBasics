module OrderTakingFunctions

open OrderTakingTypes

    let doubleQuantity orderQuantity =
        match orderQuantity with
        | UnitQuantity unitQuantity ->
            (decimal)(unitQuantity * 2)
        | KilogramQuantity kilogramQuantity ->
            kilogramQuantity * 2.0m
        
