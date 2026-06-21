open Vat

// 20.3.1
let testVat =
    [
        (0, 100.0, 100.0)
        (100, 100.0, 200.0)
        (50, 100.0, 150.0)
        (25, 200.0, 250.0)
        (20, 50.0, 60.0)
    ]

testVat
|> List.iter (fun (n, x, expected) ->
    let actual = vat n x
    printfn "vat %d %f = %f (expected %f)" n x actual expected)

// 20.3.2
let testUnvat =
    [
        (0, 100.0)
        (100, 100.0)
        (50, 100.0)
        (25, 200.0)
        (20, 50.0)
    ]

testUnvat
|> List.iter (fun (n, x) ->
    let actual = unvat n (vat n x)
    printfn "unvat %d (vat %d %f) = %f (expected %f)" n n x actual x)

// 20.3.3
let testMin =
    [
        ((fun n -> n - 3), 3)
        ((fun n -> n - 1), 1)
        ((fun n -> n - 10), 10)
        ((fun n -> n * n - 4 * n + 4), 2)  // (n-2)^2
    ]

testMin
|> List.iter (fun (f, expected) ->
    let actual = min f
    printfn "min f = %d (expected %d)" actual expected)