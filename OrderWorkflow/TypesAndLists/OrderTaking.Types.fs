module OrderTakingTypes

    type OrderQuantity =
        | UnitQuantity of int
        | KilogramQuantity of decimal
