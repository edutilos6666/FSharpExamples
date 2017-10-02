module main.OperatorsExample

type OperatorsExample() = 
    member self.testArithmeticOps() = 
          let x = 10.0 
          let y = 3.0 
          let resAdd = x + y
          let resSub = x - y
          let resMul = x * y 
          let resDiv = x / y
          let resMod = x % y 
          let resPow = x ** y 
          printfn "<<Arithmetic Operators>>"
          printfn "x = %.2f , y = %.2f" x y 
          printfn "x + y = %.2f" resAdd
          printfn "x - y = %.2f" resSub 
          printfn "x * y = %.2f" resMul 
          printfn "x / y = %.2f" resDiv 
          printfn "x %% y = %.2f" resMod 
          printfn "x ** y = %.2f" resPow 
          printfn ""

    member self.testComparisonOps() = 
          let x = 10.0 
          let y = 3.0 
          let eq = (x = y) 
          let ne = x <> y 
          let gt = x > y     
          let ge = x >= y 
          let lt = x < y 
          let le = x <= y 
          printfn "<<Comparison Operators>>"
          printfn "x = %.2f , y = %.2f" x y 
          printfn "x = y = %b" eq 
          printfn "x <> y = %b" ne 
          printfn "x > y = %b" gt 
          printfn "x >= y = %b" ge 
          printfn "x < y = %b" lt 
          printfn "x <= y = %b" le 
          printfn ""

    member self.testLogicalOperators() = 
          let x = true 
          let y = false 
          let res_and = x && y 
          let res_or = x || y 
          let res_not_x = not x 
          let res_not_y = not y 
          printfn "<<Logical Operators>>"
          printfn "x = %b , y = %b" x y 
          printfn "x && y = %b" res_and 
          printfn "x || y = %b" res_or 
          printfn "not x = %b" res_not_x 
          printfn "not y = %b" res_not_y 
          printfn ""

    member self.testBitwiseOps() = 
          let x = 10 
          let y = 23
          let res_and = x &&& y 
          let res_or = x ||| y 
          let res_xor = x ^^^ y
          let res_leftshift = x <<< 2 
          let res_rightshift = x >>> 2 
          printfn "<<Bitwise Operators>>"
          printfn "x = %d , y = %d" x y 
          printfn "x &&& y = %d" res_and 
          printfn "x ||| y = %d" res_or 
          printfn "x <<< 2 = %d" res_leftshift
          printfn "x >>> 2 = %d" res_rightshift
          printfn ""
