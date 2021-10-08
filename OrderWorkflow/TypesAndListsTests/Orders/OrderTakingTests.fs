module OrderTakingTests

open Xunit
open OrderTakingTypes
open OrderTakingFunctions

[<Fact>]
let ``Double unit quantity`` () =
    let orderQuantityInUnits = UnitQuantity 4
    let expected = decimal 8

    let actual = doubleQuantity orderQuantityInUnits

    Assert.Equal(expected, actual)

[<Fact>]
let ``Double kilogram quantity`` () =
    let orderQuantityInKilograms = KilogramQuantity 7.5m
    let expected = decimal 15

    let actual = doubleQuantity orderQuantityInKilograms

    Assert.Equal(expected, actual)
 