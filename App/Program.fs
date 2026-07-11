open LazySequence


// 49.5.1
let testEvenSeq =
    [
        (1, 2)
        (2, 4)
        (3, 6)
        (4, 8)
        (5, 10)
        (6, 12)
        (10, 20)
    ]

testEvenSeq
|> List.iter (fun (n, expected) ->
    let actual = Seq.item (n - 1) even_seq
    printfn "even_seq[%d] = %d (expected %d)" n actual expected)

// 49.5.2
let testFacSeq =
    [
        (0, 1)
        (1, 1)
        (2, 2)
        (3, 6)
        (4, 24)
        (5, 120)
    ]

testFacSeq
|> List.iter (fun (n, expected) ->
    let actual = Seq.item n fac_seq
    printfn "fac_seq[%d] = %d (expected %d)" n actual expected)

// 49.5.3
let testSeqSeq =
    [
        (0, 0)
        (1, -1)
        (2, 1)
        (3, -2)
        (4, 2)
        (5, -3)
        (6, 3)
    ]

testSeqSeq
|> List.iter (fun (n, expected) ->
    let actual = Seq.item n seq_seq
    printfn "seq_seq[%d] = %d (expected %d)" n actual expected)
