module main.DecisionMakingExample


type DecisionMakingExample() = 
    member self.testIf() = 
        let age = 15 
        if (age > 0 && age < 10) then 
            printfn "You are a kid."
        elif (age >= 10 && age < 20) then 
            printfn "You are a teenager."
        elif (age >= 20 && age < 50) then 
            printfn "You are an adult."
        else 
            printfn "You are an elderly."
