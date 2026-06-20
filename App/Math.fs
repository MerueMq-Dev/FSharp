module Math

// 16.1
let notDivisible (n, m) =
    match n with
    | 0 -> false
    | _ -> m % n = 0

//// 16.2
let rec primeHelper = function
    | (n, 1) -> true
    | (n, f) when n % f = 0 -> false
    | (n, 2) -> true
    | (n, f) -> primeHelper(n, f - 1)

let prime = function
    | n when n < 2 -> false 
    | n -> primeHelper(n, n - 1)
