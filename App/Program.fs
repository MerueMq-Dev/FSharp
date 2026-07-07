open SetHelpers

let testAllSubsets =
    [
        (3, 0, [[]])
        (3, 1, [[1]; [2]; [3]])
        (3, 2, [[1; 2]; [1; 3]; [2; 3]])
        (3, 3, [[1; 2; 3]])
        (4, 2, [[1; 2]; [1; 3]; [1; 4]; [2; 3]; [2; 4]; [3; 4]])
        (0, 0, [[]])
    ]

testAllSubsets
|> List.iter (fun (n, k, expected) ->
    let actual = allSubsets n k
    printfn "allSubsets %d %d = %A (expected %A)" n k actual expected)