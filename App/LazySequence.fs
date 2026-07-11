module LazySequence
// 49.5.1
let even_seq = Seq.initInfinite (fun n -> 2 * (n + 1))

// 49.5.2
let rec factorial n = 
    if n = 0 then 1 
    else n * factorial (n - 1)

let fac_seq = Seq.initInfinite (fun i -> factorial i)

// 49.5.3
let seq_seq =
   Seq.initInfinite (fun i ->
      if i % 2 = 0 then i / 2
      else -(i + 1) / 2)