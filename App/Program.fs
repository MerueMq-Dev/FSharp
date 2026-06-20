open Math

let testCases =
    [
        // положительные числа
        (1, 5, true)
        (2, 4, true)
        (2, 5, false)
        (3, 9, true)
        (3, 10, false)
        (5, 25, true)
        (5, 26, false)

        // отрицательный делитель
        (-2, 4, true)
        (-2, 5, false)
        (-3, 9, true)
        (-3, 10, false)

        // отрицательное делимое
        (2, -4, true)
        (2, -5, false)
        (3, -9, true)
        (3, -10, false)

        // оба отрицательные
        (-2, -4, true)
        (-2, -5, false)
        (-3, -9, true)
        (-3, -10, false)

        // ноль как делимое
        (1, 0, true)
        (2, 0, true)
        (-3, 0, true)
    ]

testCases
|> List.iter (fun (n, m, expected) ->
    let actual = notDivisible(n, m)
    printfn "notDivisible(%d, %d) = %b (expected %b)"
            n m actual expected)



let test =
    [
        (2, true)
        (3, true)
        (5, true)
        (7, true)
        (11, true)
        (13, true)
        (97, true)
        (7919, true)
        // составные числа
        (4, false)
        (6, false)
        (9, false)
        (15, false)
        (25, false)
        (49, false)
        (100, false)
        // граничные случаи
        (1, false)
        (0, false)
        (-1, false)
        (-7, false)
    ]

test
|> List.iter (fun (n, expected) ->
    let actual = prime n
    printfn "prime(%d) = %b (expected %b)" n actual expected)