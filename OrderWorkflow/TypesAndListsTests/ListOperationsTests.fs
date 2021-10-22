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

[<Fact>]
let ``Add one item to the list`` () =
    let composers = ["verdi"; "vivaldi"]
    let expected = ["paganini"; "verdi"; "vivaldi"]

    let actual = AddAsFirstItemInList "paganini" composers

    Assert.Equal<list<string>>(expected, actual)

[<Fact>]
let ``Add one item as the last item in the list`` () =
    let composers = ["verdi"; "vivaldi"]
    let expected = ["verdi"; "vivaldi"; "paganini"]

    let actual = AppendItemToList composers "paganini"

    Assert.Equal<list<string>>(expected, actual)

