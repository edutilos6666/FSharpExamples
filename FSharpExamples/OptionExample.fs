module main.OptionExample


type OptionExample() = 
    member self.example1() = 
        let safeDiv x y = 
            match y with 
              |0  -> None 
              |_ -> Some(x/y) 

        let mutable x = 10
        let mutable y = 0 
        printfn "%d / %d = %A" x y (safeDiv x y) 
        y <- 3 
        printfn "%d / %d = %A" x y (safeDiv x y) 

        let checkIfPositive x = 
            if x > 0 then 
               Some(x) 
            else 
               None
            
        printfn "x is positive = %A" (checkIfPositive x) 
        x <- -10 
        printfn "x is positive = %A" (checkIfPositive x)  
        
        
        let isHundred = function 
           | Some(100) -> true 
           | Some(_) | None -> false 
           
        printfn "x is 100 = %A" (isHundred (Some(x)))
        x <- 100 
        printfn "x is 100 = %A" (isHundred (Some(x)))
        printfn "None is 100 = %A" (isHundred None)       

