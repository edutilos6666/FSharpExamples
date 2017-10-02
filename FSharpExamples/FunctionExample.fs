module main.FunctionExample


let add (x:int) (y:int) :int = 
    x + y

let sub x y :int = 
    x - y

let mul  (x:int) (y:int) :int = 
    x * y 

let div (x:int) (y:int) :int = 
    x / y

let modulo x y :int = 
    x % y 

 

let fadd (x:double) (y:double) :double = 
    x + y

let fsub (x:double) (y:double) :double = 
    x - y

let fmul (x:double) (y:double) :double = 
    x * y

let fdiv (x:double) (y:double) :double = 
    x / y

let fmod (x:double) (y:double) :double = 
    x % y 

let fpow (x:double) (y:double) :double = 
    x ** y


//recursion
let rec fibo x:int  = 
    if x <= 1 then 
        1 
    else 
        fibo(x-1) + fibo(x-2) 


let rec factorial x:int = 
    if x <= 1 then 
         1
    else 
        x*factorial(x-1)



type FunctionExample() = 
    member self.example1() = 
        let x = 10 
        let y = 3 
        let res_add = add x y 
        let res_sub = sub x y 
        let res_mul = mul x y 
        let res_div = div x y
        let res_mod = modulo x y 
        printfn "%d + %d = %d" x y res_add 
        printfn "%d - %d = %d" x y res_sub 
        printfn "%d * %d = %d" x y res_mul
        printfn "%d / %d = %d" x y res_div 
        printfn "%d %% %d = %d" x y res_mod
        printfn ""
    
    //double 
    member self.example2() =
        let x = 10.0 
        let y = 3.0 
        let res_add = fadd x y 
        let res_sub = fsub x y 
        let res_mul = fmul x y 
        let res_div = fdiv x y 
        let res_mod = fmod x y 
        let res_pow = fpow x y 
        printfn "%.2f + %.2f = %.2f" x y res_add 
        printfn "%.2f - %.2f = %.2f" x y res_sub 
        printfn "%.2f * %.2f = %.2f" x y res_mul 
        printfn "%.2f / %.2f = %.2f" x y res_div 
        printfn "%.2f %% %.2f = %.2f" x y res_mod 
        printfn "%.2f ** %.2f = %.2f" x y res_pow 
        printfn ""



    // rec 
    member self.example3() = 
        printfn "<<fibonacci>>" 
        for i = 1 to 10 do 
            printf "%d ;" (fibo i )
        printfn ""
        printfn "10! = %d" (factorial 10) 
        printfn "5! = %d" (factorial 5) 
        printfn ""


    // lambda expression 
    member self.example4() = 
        let applyFunction (f:double->double->double) (x:double) (y:double) :double = f x y
        //firstly named functions 
        let myAdd x y = x + y
        let mySub x y = x - y
        let myMul x y = x * y
        let myDiv x y = x / y
        let myMod x y = x % y 
        let myPow x y = x ** y 
        let x = 10.0 
        let y = 3.0 
        printfn "<<named functions>>" 
        printfn "%.2f + %.2f = %.2f" x y (applyFunction myAdd x y ) 
        printfn "%.2f - %.2f = %.2f" x y (applyFunction mySub x y) 
        printfn "%.2f * %.2f = %.2f" x y (applyFunction myMul x y) 
        printfn "%.2f / %.2f = %.2f" x y (applyFunction myDiv x y)
        printfn "%.2f %% %.2f = %.2f" x y (applyFunction myMod x y) 
        printfn "%.2f ** %.2f = %.2f" x y (applyFunction myPow x y) 
        printfn ""
        //now lambda 
        let resAdd = applyFunction (fun a b -> a + b) x y 
        let resSub = applyFunction (fun a b -> a - b) x y
        let resMul = applyFunction (fun a b -> a * b) x y
        let resDiv = applyFunction (fun a b -> a / b) x y 
        let resMod = applyFunction (fun a b -> a % b) x y
        let resPow = applyFunction (fun a b -> a ** b) x y 
        printfn "<<lambda expression>>"
        printfn "%.2f + %.2f = %.2f" x y resAdd 
        printfn "%.2f - %.2f = %.2f" x y resSub 
        printfn "%.2f * %.2f = %.2f" x y resMul 
        printfn "%.2f / %.2f = %.2f" x y resDiv 
        printfn "%.2f %% %.2f = %.2f" x y resMod 
        printfn "%.2f ** %.2f = %.2f" x y resPow 
        printfn ""


        let printer (f:int64->string->int32->double->bool->unit) (id:int64) (name:string) (age:int32) (wage:double) (active:bool):unit  =
            f id name age wage active 

        let printProps (id:int64) (name:string) (age:int32) (wage:double) (active:bool) = 
            printfn "<<Properties>>"
            printfn "id = %d" id 
            printfn "name = %s" name 
            printfn "age = %d" age 
            printfn "wage = %.2f" wage 
            printfn "active = %b" active 
            printfn ""
        
        printer printProps 1L "foo" 10 100.0 true
        
        
    // function composition and pipelining 
    member self.example5() =         
        let f1 x = x + 1 
        let f2 x = x * 5 
        let f_composed = f1 >> f2
        let mutable res = f_composed 10 
        printfn "res = %d" res 
        res <-  10 |> f1 |> f2 
        printfn "res = %d" res 
        printfn "" 



