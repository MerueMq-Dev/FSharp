module MapHelpers

// 43.3
let try_find key m = Map.foldBack (fun k v acc -> if k = key then Some v else acc) m None