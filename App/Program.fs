open Lists2

// 39.1
let testRmodd =
    [
        ([1; 2; 3; 4; 5], [2; 4])
        ([1; 2; 3], [2])
        ([1], [])
        ([], [])
    ]

testRmodd
|> List.iter (fun (xs, expected) ->
    let actual = rmodd xs
    printfn "rmodd %A = %A (expected %A)" xs actual expected)

// 39.2
let testDelEven =
    [
        ([1; 2; 3; 4; 5], [1; 3; 5])
        ([2; 4; 6], [])
        ([1; 3; 5], [1; 3; 5])
        ([], [])
    ]

testDelEven
|> List.iter (fun (xs, expected) ->
    let actual = del_even xs
    printfn "del_even %A = %A (expected %A)" xs actual expected)

// 39.3
let testMultiplicity =
    [
        (1, [1; 2; 1; 3; 1], 3)
        (2, [1; 2; 3], 1)
        (4, [1; 2; 3], 0)
        (1, [], 0)
    ]

testMultiplicity
|> List.iter (fun (x, xs, expected) ->
    let actual = multiplicity x xs
    printfn "multiplicity %d %A = %d (expected %d)" x xs actual expected)

// 39.4
let testSplit =
    [
        ([1; 2; 3; 4], ([1; 3], [2; 4]))
        ([1; 2; 3], ([1; 3], [2]))
        ([1], ([1], []))
        ([], ([], []))
    ]

testSplit
|> List.iter (fun (xs, expected) ->
    let actual = split xs
    printfn "split %A = %A (expected %A)" xs actual expected)

// 39.5
let testZip =
    [
        (([1; 2; 3], [4; 5; 6]), [(1,4); (2,5); (3,6)])
        (([1], [2]), [(1,2)])
        (([], []), [])
    ]

testZip
|> List.iter (fun (xs, expected) ->
    let actual = zip xs
    printfn "zip %A = %A (expected %A)" xs actual expected)