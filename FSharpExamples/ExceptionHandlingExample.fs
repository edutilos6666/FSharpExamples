module main.ExceptionHandlingExample



exception Error1 of string 
exception Error2 of string * int

type ExceptionHandlingExample() = 
    member self.example1() = 
       let safeDiv x y = 
          try 
             Some(x/y)
          with 
             | :? System.DivideByZeroException -> printfn "Division By Zero"; None 

       let res1 = safeDiv 10 0 
       let res2 = safeDiv 10 3 
       printfn "res1 = %A" res1 
       printfn "res2 = %A" res2 

 
       let uselessFunction x y = 
           try 
               if x = y then raise (Error1("x = y"))
               else  raise (Error2 ("x != y ", 100 ))
           with 
              |Error1(str) -> printfn "Error1 = %s" str 
              |Error2(str, index) -> printfn "Error2 = %s and %d" str index 
       
       uselessFunction 10 5
       uselessFunction 10 10 


