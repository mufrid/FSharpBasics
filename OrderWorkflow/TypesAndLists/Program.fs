// Learn more about F# at http://fsharp.org

open System
open OrderTaking

let composers = ["verdi"; "puccini"]
let moreComposers = "vivaldi" :: composers
let evenMoreComposers = ["paganini"]
let allComposers = List.append moreComposers evenMoreComposers
let printElement element = printfn "%s " element

let filterEveryboydExceptForComposersStartingWithP = List.filter (fun (x:string) -> x.StartsWith("p"))

let orderQuantity = UnitQuantity 4

[<EntryPoint>]
let main argv =
    printfn "Learning the basics of F# lists!"

    printfn "Composers having name starting with P:"
    allComposers 
        |> filterEveryboydExceptForComposersStartingWithP 
        |> List.iter printElement
    
    printfn "First composer in the list: %s" moreComposers.Head

    printfn $"Doubled order quantity of {orderQuantity} is {doubleQuantity orderQuantity}"

    0 // return an integer exit code
