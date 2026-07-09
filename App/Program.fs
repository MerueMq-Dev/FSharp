open ImperativeStyle


// 47.4.1
let testFactorial =
    [
        (0, 1)
        (1, 1)
        (2, 2)
        (3, 6)
        (5, 120)
        (7, 5040)
    ]

testFactorial
|> List.iter (fun (n, expected) ->
    let actual = f n
    printfn "f %d = %d (expected %d)" n actual expected)

// 47.4.2
let testFibo =
    [
        (0, 0)
        (1, 1)
        (2, 1)
        (3, 2)
        (4, 3)
        (5, 5)
        (6, 8)
        (7, 13)
    ]

testFibo
|> List.iter (fun (n, expected) ->
    let actual = fibo n
    printfn "fibo %d = %d (expected %d)" n actual expected)