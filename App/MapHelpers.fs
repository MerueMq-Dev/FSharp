module MapHelpers

// 43.3
let try_find key m =
    Map.fold (fun acc k v -> if k = key then Some v else acc) None m