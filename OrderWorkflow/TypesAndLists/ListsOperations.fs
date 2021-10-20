module ListsOperations

let firstItemInList (itemsList: list<string>) =
    itemsList.Head

let filterItemsStartingWithLetter (itemsList: list<string>) (letter : string) =
    itemsList
    |> List.filter (fun (item:string) -> item.StartsWith(letter))

let AddAsFirstItemInList item itemsList =
    let extendedList = item :: itemsList
    extendedList