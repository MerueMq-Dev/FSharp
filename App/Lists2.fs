module Lists2

// 39.1
let rec rmodd = function
    | [] -> []
    | [_] -> []
    | _ :: x :: xs -> x :: rmodd xs

// 39.2
let rec del_even = function
    | [] -> []
    | x :: xs ->
        if x % 2 = 0 then
            del_even xs
        else
            x :: del_even xs

// 39.3
let rec multiplicity x xs =
    match xs with
    | [] -> 0
    | y :: ys ->
        (if x = y then 1 else 0) + multiplicity x ys

// 39.4
let rec split = function
    | [] -> ([], [])
    | [x] -> ([x], [])
    | x :: y :: xs ->
        let (xs1, xs2) = split xs
        (x :: xs1, y :: xs2)

// 39.5
let rec zip (xs1, xs2) =
    match (xs1, xs2) with
    | ([], []) -> []
    | (x :: xs, y :: ys) -> (x, y) :: zip (xs, ys)
    | _ -> failwith "Lists have different lengths"