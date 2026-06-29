module TimeOfDay

type TimeOfDay = { f: string; hours: int; minutes: int; }

let (.>.) x y = x > y