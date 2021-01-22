module OrderTaking

    type OrderQuantity =
        | UnitQuantity of int
        | KilogramQuantity of decimal

    let doubleQuantity orderQuantity =
            match orderQuantity with
            | UnitQuantity unitQuantity ->
              (decimal)(unitQuantity * 2)
            | KilogramQuantity kilogramQuantity ->
              kilogramQuantity * 2.0m
