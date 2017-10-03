module main.PatternMatchingExample



type MonthNames = 
    |January
    |February
    |March 
    |April
    |May
    |June
    |July
    |August
    |September
    |October
    |November
    |December


type Point = {x:double; y:double}

type PatternMatchingExample() = 
    member self.example1() = 
       let rec fib n = 
         match n with 
         | 0 -> 0 
         | 1 -> 1 
         | _ -> fib(n-1) + fib(n-2) 
      
       for i in 1..10 do 
          printf "%d ; " (fib i)
       
       printfn ""


    member self.example2() = 
       let getSeasonName monthName =
          match monthName with 
          | MonthNames.December | MonthNames.January | MonthNames.February -> "Winter"
          | MonthNames.March | MonthNames.April | MonthNames.May -> "Spring" 
          | MonthNames.June | MonthNames.July | MonthNames.August -> "Summer" 
          | MonthNames.September | MonthNames.October | MonthNames.November -> "Autumn"

       printfn "December = %A" (getSeasonName MonthNames.December)
       printfn "October = %A" (getSeasonName MonthNames.October)
       printfn "March = %A" (getSeasonName MonthNames.March)



    member self.example3() = 
       let getRate = function 
          |"foo" -> 3.0
          |"bar" -> 4.0
          |"bim" -> 5.0 
          |"pako" -> 6.0 
          |_ -> nan 
       
       printfn "foo rate = %A" (getRate "foo")
       printfn "bar rate = %A" (getRate "bar")
       printfn "pako rate = %A" (getRate "pako")
       printfn "deko rate = %A" (getRate "deko")



    member self.example4() = 
       let sign = function 
          |0 -> 0 
          |x when x < 0 -> -1
          |x when x > 0 -> 1

       printfn "sign 0 = %A" (sign 0) 
       printfn "sign 10 = %A" (sign 10) 
       printfn "sign -10 = %A" (sign -10)


       let compareDoubles = function 
         |(x1 , x2 ) when x1 < x2 -> printfn "%.2f  < %.2f" x1 x2 
         |(x1, x2) when x1 > x2 -> printfn "%.2f > %.2f" x1 x2 
         |(x1 , x2) -> printfn "%.2f = %.2f" x1 x2

       printfn "<<compareDoubles>>"
       compareDoubles (10.0, 20.0) 
       compareDoubles (20.0, 10.0) 
       compareDoubles (10.0, 10.0)  


       let detectLanguage (name, languageCode) = 
          match (name, languageCode) with 
             |(_, "en") -> printfn "%s, it is English." name 
             |(_, "de") -> printfn "%s, it is German." name 
             |(_, "ru") -> printfn "%s, it is Russian." name 
             |(_, "tr") -> printfn "%s, it is Turkish." name 
             |(_, "az") -> printfn "%s, it is Azerbaijani." name 
             |(_,_) -> printfn "%s, language code : %s is unknown to the system" name languageCode

       detectLanguage ("foo", "en") 
       detectLanguage ("foo", "de")
       detectLanguage ("foo", "ru")
       detectLanguage ("foo", "tr")
       detectLanguage ("foo", "az") 
       detectLanguage ("foo", "in") 


       let detectCoordinate (point:Point) = 
          match point with 
          | {x=0.0; y=0.0} -> printfn "Point is at the origin." 
          | {x=0.0; y = yVal} -> printfn "Point is on the x-axis.Value is %.2f" yVal 
          | {x = xVal; y = 0.0} -> printfn "Point is on the y-axis. Value is %.2f" xVal
          | {x = xVal; y = yVal} -> printfn "Point is on (%.2f, %.2f)" xVal yVal
       
       detectCoordinate {x=0.0; y=0.0}
       detectCoordinate {x=0.0; y=10.0}
       detectCoordinate {x=10.0; y=0.0}
       detectCoordinate {x=10.0; y=10.0}



