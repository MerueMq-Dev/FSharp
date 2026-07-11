module SequenceExpressions
// 50.2.1
let fac_seq =
    seq {
        let mutable fact = 0
        for i in Seq.initInfinite ((+) 1) do
            yield fact
            fact <- fact * i
}

// 50.2.2
let seq_seq =
    seq {
        yield 0
        for i in Seq.initInfinite ((+) 1) do
            yield -i
            yield i
    }