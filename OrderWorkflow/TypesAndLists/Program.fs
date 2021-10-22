// Learn more about F# at http://fsharp.org

open ListsOperations

let printElement element = printfn "%s " element

[<EntryPoint>]
let main argv =
    printfn "Learning the basics of F# lists!"

    let composers = [
        "verdi"
        "puccini"
     ]

    let moreComposers = AddAsFirstItemInList "vivaldi" composers
    let allComposers = AppendItemToList moreComposers "paganini"
    printfn "List of all composers:"
    allComposers
        |> List.iter printElement

    printfn "Composers having name starting with P:"
    filterItemsStartingWithLetter allComposers "p"
        |> List.iter printElement
    
    printfn "First composer in the list: %s" (firstItemInList allComposers)

    0 // return an integer exit code