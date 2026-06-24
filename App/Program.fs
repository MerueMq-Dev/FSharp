open Curry



let add (x, y) = x + y
let addCurried = curry add

printfn "%d" (addCurried 3 4)      // 7
printfn "%d" (uncurry addCurried (3, 4))  // 7