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

    type Currency = EUR | USD
    type PaymentAmount = PaymentAmount of decimal

    type PaymentMethod =
        | Cash
        | Card of CardNumber


    type Payment = 
        {
            Amount : PaymentAmount
            Currency : Currency
            Method: PaymentMethod
        }

    // Type that represent functions ie. behavior
    // Convert payment from one currency to another
    // First payment is input, Current is the parameter and the second payment is the output
    type ConvertPaymentCurrency = Payment -> Currency -> Payment
