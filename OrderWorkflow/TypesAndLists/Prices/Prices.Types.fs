module PricesTypes

type PriceCurrency = NOK | USD | EUR

type PriceAmount = PriceAmount of decimal

type Price =
    {
        Amount : PriceAmount
        Currency : PriceCurrency
    }

type MembershipType = Gold | Regular | NotAMember

type CustomerAge = CustomerAge of uint

type Customer =
    {
        MembershipType : MembershipType
        Age : CustomerAge
    }

type Flexibility = Full | Partial | FeesOnly

type TicketType = 
    | YouthTicket of Flexibility
    | AdultTicket of Flexibility
    | ChildTicket of Flexibility

type DiscountValidityPeriod = 
    {
        StartTime : System.DateTime
        EndTime : System.DateTime
    }

type Discount =
    {
        Percentage : uint
        Validity : DiscountValidityPeriod
    }


