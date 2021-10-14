module ListsOperationsTests

open Xunit
open ListsOperations

[<Fact>]
let ``Get first item in a list`` () =
    let composers = ["verdi"; "puccini"]
    let expected = "verdi"

    let actual = firstItemInList composers

    Assert.Equal(expected, actual)

[<Fact>]
let ``Get only items starting with letter P`` () =
    let composers = ["verdi"; "puccini"; "paganini"]
    let expected = ["puccini"; "paganini"]

    let actual = filterItemsStartingWithLetter composers "p"

    Assert.Equal<list<string>>(expected, actual)

[<Fact>]
let ``Get only items starting with letter V`` () =
    let composers = ["verdi"; "vivaldi"; "puccini"; "paganini"]
    let expected = ["verdi"; "vivaldi"]

    let actual = filterItemsStartingWithLetter composers "v"

    Assert.Equal<list<string>>(expected, actual)
