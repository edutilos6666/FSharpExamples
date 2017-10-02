module main.Program 


let testModule1 = 
    let x1:int = 10 
    let x2:int = 3 
    let add = Arithmetic.add x1 x2 
    let sub = Arithmetic.sub x1 x2
    let mult = Arithmetic.mult x1 x2 
    let div = Arithmetic.div x1 x2 
    printfn "<<Arithmetic Resulst>>" 
    printfn "x1 = %d , x2 = %d " x1 x2 
    printfn "x1 + x2 = %d" add
    printfn "x1 - x2 = %d" sub 
    printfn "x1 * x2 = %d" mult 
    printfn "x1 / x2 = %d" div 


open Arithmetic
let testModule2 = 

    let x1 = 10 
    let x2 = 3 
    let res_add = add x1 x2 
    let res_sub = sub x1 x2 
    let res_mult = mult x1 x2 
    let res_div = div x1 x2 
    printfn "<<Arithmetic Operators 2>>"
    printfn "x1 = %d , x2 = %d" x1 x2 
    printfn "x1 + x2 = %d" res_add 
    printfn "x1 - x2 = %d" res_sub 
    printfn "x1 * x2 = %d" res_mult 
    printfn "x1 / x2 = %d" res_div
    let w1 = new Worker(1L , "foo", 10, 100.0, true) 
    printfn "w1 = %s" (w1.ToString())
    w1.Id <- 2L 
    w1.Name <- "new foo"
    w1.Age <- 20 
    printfn "w1 = %s" (w1.ToString()) 



module module1 = 
   let name = "foo" 

module module2 = 
   let name = "bar"


[<EntryPoint>]
let main argv = 
    testModule1
    printfn ""
    testModule2
    printfn "module1.name = %s" (module1.name)
    printfn "module2.name = %s" module2.name 
    0
   