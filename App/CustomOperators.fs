module CustomOperators

// 23.4.1
let normalize (g, s, c) =
    let total = (g * 20 + s) * 12 + c
    let copper = ((total % 12) + 12) % 12
    let totalSilver = (total - copper) / 12
    let silver = ((totalSilver % 20) + 20) % 20
    let gold = (totalSilver - silver) / 20
    (gold, silver, copper)

let (.+.) (g1, s1, c1) (g2, s2, c2) =
    normalize (g1 + g2, s1 + s2, c1 + c2)

let (.-.) (g1, s1, c1) (g2, s2, c2) =
    normalize (g1 - g2, s1 - s2, c1 - c2)

// 23.4.2
let (.+) (a: float, b: float) (c: float, d: float) = (a + c, b + d)

let (.-) (a: float, b: float) (c: float, d: float) = (a - c, b - d)

let (.*) (a: float, b: float) (c: float, d: float) = (a * c - b * d, b * c + a * d)

let (./) (a: float, b: float) (c: float, d: float) =
    let denom = c * c + d * d
    (a, b) .* (c / denom, -d / denom)