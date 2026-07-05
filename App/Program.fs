open Practice

// 40.1
let testSum =
    [
        ((fun x -> x % 2 = 0), [1; 2; 3; 4; 5], 6)
        ((fun x -> x > 3), [1; 2; 3; 4; 5], 9)
        ((fun x -> x > 0), [], 0)
        ((fun x -> false), [1; 2; 3], 0)
    ]

testSum
|> List.iter (fun (p, xs, expected) ->
    let actual = sum(p, xs)
    printfn "sum p %A = %d (expected %d)" xs actual expected)

// 40.2.1
let testCount =
    [
        ([1; 2; 2; 3; 3; 3], 3, 3)
        ([1; 2; 2; 3; 3; 3], 2, 2)
        ([1; 2; 2; 3; 3; 3], 1, 1)
        ([1; 2; 2; 3; 3; 3], 4, 0)
        ([], 1, 0)
    ]

testCount
|> List.iter (fun (xs, n, expected) ->
    let actual = count(xs, n)
    printfn "count %A %d = %d (expected %d)" xs n actual expected)

// 40.2.2
let testInsert =
    [
        ([1; 3; 5], 2, [1; 2; 3; 5])
        ([1; 3; 5], 0, [0; 1; 3; 5])
        ([1; 3; 5], 6, [1; 3; 5; 6])
        ([1; 3; 5], 3, [1; 3; 3; 5])
        ([], 1, [1])
    ]

testInsert
|> List.iter (fun (xs, n, expected) ->
    let actual = insert(xs, n)
    printfn "insert %A %d = %A (expected %A)" xs n actual expected)

// 40.2.3
let testIntersect =
    [
        ([1; 2; 3], [2; 3; 4], [2; 3])
        ([1; 2; 2; 3], [2; 2; 4], [2; 2])
        ([1; 2; 3], [4; 5; 6], [])
        ([], [1; 2; 3], [])
        ([1; 2; 3], [], [])
    ]

testIntersect
|> List.iter (fun (xs, ys, expected) ->
    let actual = intersect(xs, ys)
    printfn "intersect %A %A = %A (expected %A)" xs ys actual expected)

// 40.2.4
let testPlus =
    [
        ([1; 3; 5], [2; 4; 6], [1; 2; 3; 4; 5; 6])
        ([1; 2; 3], [2; 3; 4], [1; 2; 2; 3; 3; 4])
        ([], [1; 2; 3], [1; 2; 3])
        ([1; 2; 3], [], [1; 2; 3])
    ]

testPlus
|> List.iter (fun (xs, ys, expected) ->
    let actual = plus(xs, ys)
    printfn "plus %A %A = %A (expected %A)" xs ys actual expected)

// 40.2.5
let testMinus =
    [
        ([1; 2; 3; 4], [2; 4], [1; 3])
        ([1; 2; 2; 3], [2], [1; 2; 3])
        ([1; 2; 3], [1; 2; 3], [])
        ([1; 2; 3], [], [1; 2; 3])
        ([], [1; 2; 3], [])
    ]

testMinus
|> List.iter (fun (xs, ys, expected) ->
    let actual = minus(xs, ys)
    printfn "minus %A %A = %A (expected %A)" xs ys actual expected)

// 40.3.1
let testSmallest =
    [
        ([1; 2; 3], Some 1)
        ([3; 1; 2], Some 1)
        ([5], Some 5)
        ([], None)
    ]

testSmallest
|> List.iter (fun (xs, expected) ->
    let actual = smallest xs
    printfn "smallest %A = %A (expected %A)" xs actual expected)

// 40.3.2
let testDelete =
    [
        (2, [1; 2; 3], [1; 3])
        (2, [1; 2; 2; 3], [1; 2; 3])
        (4, [1; 2; 3], [1; 2; 3])
        (1, [], [])
    ]

testDelete
|> List.iter (fun (n, xs, expected) ->
    let actual = delete(n, xs)
    printfn "delete %d %A = %A (expected %A)" n xs actual expected)

// 40.3.3
let testSort =
    [
        ([3; 1; 2], [1; 2; 3])
        ([5; 4; 3; 2; 1], [1; 2; 3; 4; 5])
        ([1; 2; 3], [1; 2; 3])
        ([1], [1])
        ([], [])
    ]

testSort
|> List.iter (fun (xs, expected) ->
    let actual = sort xs
    printfn "sort %A = %A (expected %A)" xs actual expected)

// 40.4
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