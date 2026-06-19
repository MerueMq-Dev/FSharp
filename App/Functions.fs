module Functions

open System

// 5.5.1
let g (n) = n + 5 // int -> int

// 5.5.2 
let gg = fun n -> n + 5 // int -> int

//5.5.3
let h (x, y) = Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(y, 2.0)) // float * float -> float