module Lists

// 34.1
let upto n =
    let rec helper i =
        if i > n then []
        else i :: helper (i + 1)
    helper 1

// 34.2
let rec dnto = function 
    | n when n <= 0 -> []
    | n -> n :: dnto(n - 1)

//// 34.3
let evenn n =
    let rec helper i =
        if i >= n then []
        else 2 * i :: helper (i + 1)
    helper 0