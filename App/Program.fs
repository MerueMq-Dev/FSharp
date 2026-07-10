open LazyEvaluation


// 48.4.1
let testFibo1 =
    [
        (6, 1, 0, 8)
        (6, 5, 3, 55)
        (0, 1, 0, 0)
        (1, 1, 0, 1)
        (2, 1, 0, 1)
        (3, 1, 0, 2)
    ]

testFibo1
|> List.iter (fun (n, n1, n2, expected) ->
    let actual = fibo1 n n1 n2
    printfn "fibo1 %d %d %d = %d (expected %d)" n n1 n2 actual expected)

// 48.4.2
let testFibo2 =
    [
        (0, id, 0)
        (1, id, 1)
        (2, id, 1)
        (3, id, 2)
        (4, id, 3)
        (5, id, 5)
        (6, id, 8)
    ]

testFibo2
|> List.iter (fun (n, c, expected) ->
    let actual = fibo2 n c
    printfn "fibo2 %d = %d (expected %d)" n actual expected)

// 48.4.3
let testBigList =
    [
        (0, id, [])
        (1, id, [1])
        (5, id, [1; 1; 1; 1; 1])
        (10, id, List.replicate 10 1)
        (230000, id, List.replicate 230000 1)
    ]

testBigList
|> List.iter (fun (n, k, expected) ->
    let actual = bigList n k
    printfn "bigList %d = (length %d) (expected length %d)" n (List.length actual) (List.length expected))