// Learn more about F# at http://fsharp.org

open ListsOperations

let composers = ["verdi"; "puccini"]
let moreComposers = "vivaldi" :: composers
let evenMoreComposers = ["paganini"]
let allComposers = List.append moreComposers evenMoreComposers
let printElement element = printfn "%s " element

[<EntryPoint>]
let main argv =
    printfn "Learning the basics of F# lists!"

    printfn "List of all composers:"
    allComposers
        |> List.iter printElement

    printfn "Composers having name starting with P:"
    filterItemsStartingWithLetter allComposers "p"
        |> List.iter printElement
    
    let firstComposerInTheList = firstItemInList allComposers
    printfn "First composer in the list: %s" firstComposerInTheList

    0 // return an integer exit code
