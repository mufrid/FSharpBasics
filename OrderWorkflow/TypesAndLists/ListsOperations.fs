module ListsOperations

let firstItemInList (itemsList: list<string>) =
    itemsList.Head

let firstItemInArray (itemsList: ResizeArray<string>) =
    itemsList.[0]

let filterItemsStartingWithLetter (itemsList: list<string>) (letter : string) =
    itemsList
    |> List.filter (fun (item:string) -> item.StartsWith(letter))

let AddAsFirstItemInList item itemsList =
    let extendedList = item :: itemsList
    extendedList

let AppendItemToList itemsList item =
    let toAppend = [item]
    let extendedList = List.append itemsList toAppend
    extendedList

let InsertAsFirstItemInList (item: string) (itemsList: ResizeArray<string>) =
    itemsList.Insert(0, item)
    itemsList