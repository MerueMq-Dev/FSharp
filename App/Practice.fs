module Practice

// 40.1
let rec sum (p, xs) = 
  match xs with
  | [] -> 0
  | h :: t -> if p h then h + sum (p, t) else sum (p, t)


//// 40.2.1
let rec count (xs, n) = 
  match xs with
  | [] -> 0
  | h :: t when n < h -> 0
  | h :: t -> if n = h then 1 + count (t, n) else count (t, n)


// 40.2.2
let rec insert (xs, n) = 
    match xs with
    | [] -> [n]
    | h :: t when h >= n -> h :: n :: t
    | h :: t when h < n -> h :: insert(t, n)   
    | _ -> []

// 40.2.3
let rec intersect (xs1, xs2) = 
   match (xs1, xs2) with   
   | ([], n) -> []
   | (n, []) -> []   
   | (h1::t1, h2::t2) when h1 = h2 -> h1 :: intersect (t1, t2)
   | (h1::t1, h2::t2) when h1 > h2 -> intersect (h1:: t1, t2)
   | (h1::t1, h2::t2) when h1 < h2 -> intersect (t1, h2 :: t2)
   | _ -> []

// 40.2.4
let rec plus (xs1, xs2) =
  match (xs1, xs2) with
     | ([], n) -> n
     | (n, []) -> n 
     | (h1::t1, h2::t2) when h1 = h2 -> h1 :: h2 :: plus (t1, t2)
     | (h1::t1, h2::t2) when h1 > h2 -> h2 :: plus (h1 :: t1, t2)
     | (h1::t1, h2::t2) when h1 < h2 -> h1 :: plus (t1, h2 :: t2)
     | _ -> []


// 40.2.5
let rec minus (xs1, xs2) =
    match xs1, xs2 with
    | [], _ -> []
    | xs, [] -> xs
    | h1::t1, h2::t2 when h1 < h2 -> h1 :: minus(t1, h2::t2)
    | h1::t1, h2::t2 when h1 = h2 -> minus(t1, t2)
    | h1::t1, h2::t2 -> minus(h1::t1, t2)

// 40.3.1
let rec smallest = function
    | [] -> None
    | [n] -> Some n
    | h :: t ->
        match smallest t with
        | Some m when h < m -> Some h
        | res -> res

// 40.3.2
let rec delete (n, xs) =
    match xs with
    | [] -> []
    | h::t ->
        if h = n then t
        else h :: delete(n, t)

// 40.3.3
let rec sort = function
    | xs ->
        match smallest xs with
        | None -> []
        | Some m -> m :: sort (delete(m, xs))

// 40.4
let rec revrev = function
    | [] -> []
    | xs :: rest ->
        let rec rev acc = function
            | [] -> acc
            | h :: t -> rev (h :: acc) t
        revrev rest @ [rev [] xs]