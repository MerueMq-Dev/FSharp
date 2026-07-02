module TimeOfDay2

type F = 
  | AM
  | PM

type TimeOfDay = { hours : int; minutes : int; f: F }

let (.>.) x y =
        match x, y with
        | { f = PM }, { f = AM } -> true
        | { f = AM }, { f = PM } -> false
        | x, y -> x.hours * 60 + x.minutes > y.hours * 60 + y.minutes

