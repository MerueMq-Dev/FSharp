module ImperativeStyle
// 47.4.1
let f n = 
    let mutable factorial = n
    let mutable factorialSum = 1
    while factorial > 0 do
       factorialSum  <- factorialSum * factorial
       factorial <- factorial - 1
    factorialSum

// 47.4.2
let fibo n = 
   let mutable fibonachi = n
   let mutable n1 = 0
   let mutable n2 = 1
   while fibonachi > 0 do
     let temp = n2
     n2 <- n2 + n1
     n1 <- temp
     fibonachi <- fibonachi - 1
   n1