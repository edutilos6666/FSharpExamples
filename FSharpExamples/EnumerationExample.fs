module main.EnumerationExample


type WeekDays = 
  |Sun 
  |Mon 
  |Tue
  |Wed 
  |Thu
  |Fri
  |Sat

type EnumerationExample() = 
    member self.example1() = 
       let day1:WeekDays = WeekDays.Sun
       let day2:WeekDays = WeekDays.Wed
       let day3:WeekDays = WeekDays.Fri
       printfn "day1 = %A" day1
       printfn "day2 = %A" day2
       printfn "day3 = %A" day3

