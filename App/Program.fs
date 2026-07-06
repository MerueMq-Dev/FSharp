open Lists3

// 41.4.1
let testListFilter =
    [
        ((fun x -> x % 2 = 0), [1; 2; 3; 4; 5], [2; 4])
        ((fun x -> x > 3), [1; 2; 3; 4; 5], [4; 5])
        ((fun x -> true), [1; 2; 3], [1; 2; 3])
        ((fun x -> false), [1; 2; 3], [])
        ((fun x -> x > 0), [], [])
    ]

testListFilter
|> List.iter (fun (f, xs, expected) ->
    let actual = list_filter f xs
    printfn "list_filter f %A = %A (expected %A)" xs actual expected)

// 41.4.2
let testSum =
    [
        ((fun x -> x % 2 = 0), [1; 2; 3; 4; 5], 6)
        ((fun x -> x > 3), [1; 2; 3; 4; 5], 9)
        ((fun x -> false), [1; 2; 3], 0)
        ((fun x -> x > 0), [], 0)
    ]

testSum
|> List.iter (fun (p, xs, expected) ->
    let actual = sum(p, xs)
    printfn "sum p %A = %d (expected %d)" xs actual expected)

// 41.4.3
let testRevrev =
    [
        ([[1; 2]; [3; 4; 5]], [[5; 4; 3]; [2; 1]])
        ([[1]; [2]; [3]], [[3]; [2]; [1]])
        ([[1; 2; 3]], [[3; 2; 1]])
        ([], [])
    ]

testRevrev
|> List.iter (fun (xs, expected) ->
    let actual = revrev xs
    printfn "revrev %A = %A (expected %A)" xs actual expected)