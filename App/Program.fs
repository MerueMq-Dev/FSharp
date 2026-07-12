open LazyEvaluation2

let testNth =
    [
        (0, 0)
        (1, 1)
        (2, 2)
        (5, 5)
        (10, 10)
        (30000, 30000)
    ]

let rec nat (n:int) : 'a cell = Cons (n, lazy(nat(n+1)))
let n0 = nat 0
testNth
|> List.iter (fun (n, expected) ->
    let actual = nth n0 n
    printfn "nth n0 %d = %d (expected %d)" n actual expected)