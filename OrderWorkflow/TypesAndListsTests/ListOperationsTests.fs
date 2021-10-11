module ListsOperationsTests

open Xunit
open ListsOperations

[<Fact>]
let ``Get first item in a list`` () =
    let composers = ["verdi"; "puccini"]
    let expected = "verdi"

    let actual = firstItemInList composers

    Assert.Equal(expected, actual)
 
