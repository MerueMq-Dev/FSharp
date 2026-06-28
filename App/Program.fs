open CustomOperators

// 23.4.1 (.+.)
let testMoneyAdd =
    [
        ((1, 0, 0), (0, 0, 0), (1, 0, 0))
        ((0, 0, 11), (0, 0, 1), (0, 1, 0))
        ((0, 19, 11), (0, 0, 1), (1, 0, 0))
        ((1, 0, 128), (0, 0, 0), (1, 10, 8))
        ((32, 23, 5), (0, 0, 7), (33, 4, 0))
        ((5, 10, 6), (3, 15, 9), (9, 6, 3))
    ]
testMoneyAdd
|> List.iter (fun (x, y, expected) ->
    let actual = x .+. y
    printfn "%A .+. %A = %A (expected %A)" x y actual expected)

// 23.4.1 (.-.)
let testMoneySub =
    [
        ((1, 0, 0), (0, 0, 1), (0, 19, 11))
        ((1, 0, 0), (0, 0, 0), (1, 0, 0))
        ((0, 1, 0), (0, 0, 1), (0, 0, 11))
        ((10, 5, 3), (3, 15, 9), (6, 9, 6))
        ((33, 4, 0), (0, 0, 7), (32, 23, 5))
        ((1, 0, 0), (1, 0, 0), (0, 0, 0))
    ]
testMoneySub
|> List.iter (fun (x, y, expected) ->
    let actual = x .-. y
    printfn "%A .-. %A = %A (expected %A)" x y actual expected)

// 23.4.2 (.+)
let testComplexAdd =
    [
        ((1.0, 2.0), (3.0, 4.0), (4.0, 6.0))
        ((0.0, 0.0), (1.0, 1.0), (1.0, 1.0))
        ((-1.0, 3.0), (1.0, -3.0), (0.0, 0.0))
    ]
testComplexAdd
|> List.iter (fun (x, y, expected) ->
    let actual = x .+ y
    printfn "%A .+ %A = %A (expected %A)" x y actual expected)

// 23.4.2 (.-)
let testComplexSub =
    [
        ((3.0, 4.0), (1.0, 2.0), (2.0, 2.0))
        ((1.0, 1.0), (1.0, 1.0), (0.0, 0.0))
        ((0.0, 0.0), (1.0, -3.0), (-1.0, 3.0))
    ]
testComplexSub
|> List.iter (fun (x, y, expected) ->
    let actual = x .- y
    printfn "%A .- %A = %A (expected %A)" x y actual expected)

// 23.4.2 (.*)
let testComplexMul =
    [
        ((1.0, 0.0), (3.0, 4.0), (3.0, 4.0))
        ((0.0, 1.0), (0.0, 1.0), (-1.0, 0.0))
        ((2.0, 3.0), (1.0, -1.0), (5.0, 1.0))
    ]
testComplexMul
|> List.iter (fun (x, y, expected) ->
    let actual = x .* y
    printfn "%A .* %A = %A (expected %A)" x y actual expected)

// 23.4.2 (./)
let testComplexDiv =
    [
        ((1.0, 0.0), (1.0, 0.0), (1.0, 0.0))
        ((4.0, 2.0), (2.0, 0.0), (2.0, 1.0))
        ((-1.0, 0.0), (0.0, 1.0), (0.0, 1.0))
    ]
testComplexDiv
|> List.iter (fun (x, y, expected) ->
    let actual = x ./ y
    printfn "%A ./ %A = %A (expected %A)" x y actual expected)