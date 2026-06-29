open TimeOfDay

let testTimeOfDay =
    [
        // PM > AM
        ({ hours = 1; minutes = 0; f = "PM" }, { hours = 1; minutes = 0; f = "AM" }, true)
        ({ hours = 1; minutes = 0; f = "AM" }, { hours = 1; minutes = 0; f = "PM" }, false)
        // часы больше но AM < PM
        ({ hours = 11; minutes = 0; f = "AM" }, { hours = 1; minutes = 0; f = "PM" }, false)
        ({ hours = 1; minutes = 0; f = "PM" }, { hours = 11; minutes = 0; f = "AM" }, true)
        // сравнение часов (одинаковый f)
        ({ hours = 5; minutes = 0; f = "AM" }, { hours = 3; minutes = 0; f = "AM" }, true)
        ({ hours = 3; minutes = 0; f = "AM" }, { hours = 5; minutes = 0; f = "AM" }, false)
        // минуты больше но часы меньше
        ({ hours = 3; minutes = 59; f = "AM" }, { hours = 5; minutes = 0; f = "AM" }, false)
        ({ hours = 5; minutes = 0; f = "AM" }, { hours = 3; minutes = 59; f = "AM" }, true)
        // сравнение минут (одинаковые f и hours)
        ({ hours = 5; minutes = 30; f = "AM" }, { hours = 5; minutes = 0; f = "AM" }, true)
        ({ hours = 5; minutes = 0; f = "AM" }, { hours = 5; minutes = 30; f = "AM" }, false)
        // равные
        ({ hours = 5; minutes = 30; f = "AM" }, { hours = 5; minutes = 30; f = "AM" }, false)
        ({ hours = 5; minutes = 30; f = "PM" }, { hours = 5; minutes = 30; f = "PM" }, false)
    ]

testTimeOfDay
|> List.iter (fun (x, y, expected) ->
    let actual = x .>. y
    printfn "%d:%d %s .>. %d:%d %s = %b (expected %b)"
        x.hours x.minutes x.f y.hours y.minutes y.f actual expected)