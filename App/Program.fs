open Lists

// 34.1
let testUpto =
    [
        (1, [1])
        (3, [1; 2; 3])
        (5, [1; 2; 3; 4; 5])
        (0, [])
    ]

testUpto
|> List.iter (fun (n, expected) ->
    let actual = upto n
    printfn "upto %d = %A (expected %A)" n actual expected)

// 34.2
let testDnto =
    [
        (1, [1])
        (3, [3; 2; 1])
        (5, [5; 4; 3; 2; 1])
        (0, [])
    ]

testDnto
|> List.iter (fun (n, expected) ->
    let actual = dnto n
    printfn "dnto %d = %A (expected %A)" n actual expected)

// 34.3
let testEvenn =
    [
        (1, [0])
        (3, [0; 2; 4])
        (5, [0; 2; 4; 6; 8])
        (0, [])
    ]

testEvenn
|> List.iter (fun (n, expected) ->
    let actual = evenn n
    printfn "evenn %d = %A (expected %A)" n actual expected)