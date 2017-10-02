module main.TupleExample


type TupleExample() = 
    member self.example1() = 
        let doubleSummaryStatistics (a:double, b:double, c:double, d:double) :unit = 
            let mutable sum:double = 0.0 
            let mutable avg:double = 0.0 
            let mutable min:double = a
            let mutable max:double = a 
            let numbers = [a;b;c;d]
            for number in numbers do 
                sum <- sum + number 
                if min > number then 
                   min <- number 
                if max < number then 
                   max <- number 

            avg <- sum / (double numbers.Length)
            printfn "<<double Summary statistics>>"
            printfn "numbers = %A" numbers 
            printfn "sum = %.2f" sum 
            printfn "avg = %.2f" avg 
            printfn "min = %.2f" min 
            printfn "max = %.2f" max 
            printfn ""

        let mutable numbers = (10.0, 20.0, 30.0, 40.0) 
        doubleSummaryStatistics numbers 
        doubleSummaryStatistics (1.0, 2.0, 3.0, 4.0) 


        let printProps (id:int64, name:string, age:int32, wage:double , active:bool) :unit =
            printfn "<<Properties>>"
            printfn "id = %d" id 
            printfn "name = %s" name 
            printfn "age = %d" age 
            printfn "wage =%.2f" wage 
            printfn "active = %b" active 
            printfn ""

        printProps (1L, "foo", 10, 100.0, true) 

        let a, b , c, d = numbers 
        printfn "%A , %A, %A, %A" a b c d 

        let display tuple1 =
           match tuple1 with 
           | (a,b,c) -> printfn "3-tuple = %A, %A, %A" a b c 
           

        display ("foo", "bar", "bim")


