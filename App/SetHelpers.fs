module SetHelpers

// 42.3
let rec allSubsets n k =
    if k = 0 then set [ Set.empty ]
    elif n < k then set []
    else
        Set.union
            (allSubsets (n - 1) k)
            (Set.map (Set.add n) (allSubsets (n - 1) (k - 1)))