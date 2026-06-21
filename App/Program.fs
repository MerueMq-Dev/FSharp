

// 17.4.1
open Strings

let testPow =
    [
        ("ab", 3, "ababab")
        ("ab", 1, "ab")
        ("ab", 0, "")
        ("x", 5, "xxxxx")
        ("", 3, "")
    ]

testPow
|> List.iter (fun (s, n, expected) ->
    let actual = pow(s, n)
    printfn "pow(%s, %d) = %s (expected %s)" s n actual expected)

// 17.4.2
let testIsIthChar =
    [
        ("hello", 0, 'h', true)
        ("hello", 1, 'e', true)
        ("hello", 4, 'o', true)
        ("hello", 0, 'x', false)
        ("hello", 2, 'e', false)
    ]

testIsIthChar
|> List.iter (fun (s, n, c, expected) ->
    let actual = isIthChar(s, n, c)
    printfn "isIthChar(%s, %d, %c) = %b (expected %b)" s n c actual expected)

// 17.4.3
let testOccFromIth =
    [
        ("hello", 0, 'l', 2)
        ("hello", 3, 'l', 1)
        ("hello", 4, 'l', 0)
        ("hello", 0, 'x', 0)
        ("aaa",   0, 'a', 3)
        ("aaa",   1, 'a', 2)
    ]

testOccFromIth
|> List.iter (fun (s, n, c, expected) ->
    let actual = occFromIth(s, n, c)
    printfn "occFromIth(%s, %d, %c) = %d (expected %d)" s n c actual expected)