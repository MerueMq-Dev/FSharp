open MapHelpers

let testTryFind =
    [
        (1, Map.ofList [(1, "a"); (2, "b"); (3, "c")], Some "a")
        (2, Map.ofList [(1, "a"); (2, "b"); (3, "c")], Some "b")
        (4, Map.ofList [(1, "a"); (2, "b"); (3, "c")], None)
        (1, Map.empty, None)
    ]

testTryFind
|> List.iter (fun (key, m, expected) ->
    let actual = try_find key m
    printfn "try_find %d %A = %A (expected %A)" key m actual expected)