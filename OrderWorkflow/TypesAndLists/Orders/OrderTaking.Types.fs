module OrderTakingTypes

    type OrderQuantity =
        | UnitQuantity of int
        | KilogramQuantity of decimal

    type CardType = 
        Visa | Mastercard

    type CardNumber = CardNumber of string

    type CreditCardInfo =
        {
            CardType : CardType
            CardNumber : CardNumber
        }

    type Currency = NOK | USD | EUR

    type PaymentMethod =
        | Cash
        | Card of CardNumber


    type Payment = 
        {
            Amount : decimal
            Currency : Currency
            Method: PaymentMethod option
        }