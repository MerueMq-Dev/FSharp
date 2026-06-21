module Vat

let vat n x = x * (1.0 + float n / 100.0)

let unvat n y = y / (1.0 + float n / 100.0)

let min f =
    let rec go n =
        if f n = 0 then n else go (n + 1)
    go 1