module main.DelegateExample 


type DelegateBinOp = delegate of (double*double) -> double 
type DelegateBinOp2 = delegate of double*double -> double 


type MyHelperClass() = 
    static member add x y = x + y
    static member sub x y = x - y
    static member mul x y = x * y
    member self.Div x y = x / y 
    member self.Mod x y = x % y 
    member self.Pow x y = x ** y 

type DelegateExample() = 
    member self.example1() = 
       let add (x:double, y:double) :double  = x + y
       let sub  (x:double, y:double) :double = x - y
       let mul (x:double, y:double) :double = x * y 
       let div (x:double, y:double) :double = x / y 
       let modulo (x:double, y:double) :double = x % y 
       let pow (x:double, y:double) :double = x ** y
       //we can not use lambda expression for delegate in f#  
       let delAdd:DelegateBinOp = new DelegateBinOp(add)
       let delSub:DelegateBinOp = new DelegateBinOp(sub) 
       let delMul:DelegateBinOp = new DelegateBinOp(mul) 
       let delDiv:DelegateBinOp = new DelegateBinOp(div) 
       let delMod:DelegateBinOp = new DelegateBinOp(modulo) 
       let delPow:DelegateBinOp = new DelegateBinOp(pow) 
       let (x, y) = (10.0, 3.0) 
       printfn "<<Delegate Example>>" 
       printfn "x = %.2f , y = %.2f" x y 
       printfn "x + y = %.2f" (delAdd.Invoke(x, y))
       printfn "x - y = %.2f" (delSub.Invoke(x,y))
       printfn "x * y = %.2f" (delMul.Invoke(x,y))
       printfn "x / y = %.2f" (delDiv.Invoke(x,y))
       printfn "x %% y = %.2f" (delMod.Invoke(x,y))
       printfn "x ** y= %.2f" (delPow.Invoke(x,y))
       

    member self.example2() = 
       let add (x:double) (y:double) :double = x + y
       let sub x y = x - y
       let mul x y = x * y
       let div x y = x / y 
       let modulo x y = x % y 
       let pow x y = x ** y 
       let delAdd:DelegateBinOp2 = new DelegateBinOp2(add)
       let delSub = new DelegateBinOp2(sub) 
       let delMul = new DelegateBinOp2(mul) 
       let delDiv = new DelegateBinOp2(div)
       let delMod = new DelegateBinOp2(modulo)
       let delPow = new DelegateBinOp2(pow) 
       let (x, y) = (10.0, 3.0) 
       printfn "<<Delegate Example 2>>" 
       printfn "x  = %.2f , y = %.2f" x y 
       printfn "x + y = %.2f" (delAdd.Invoke(x,y))
       printfn "x - y = %.2f" (delSub.Invoke(x,y))
       printfn "x * y = %.2f" (delMul.Invoke(x,y))
       printfn "x / y= %.2f" (delDiv.Invoke(x,y))
       printfn "x %% y = %.2f" (delMod.Invoke(x,y))
       printfn "x ** y = %.2f" (delPow.Invoke(x,y))


    member self.example3() = 
       let clazz = new MyHelperClass() 
       let delAdd = new DelegateBinOp2(MyHelperClass.add)
       let delSub = new DelegateBinOp2(MyHelperClass.sub)
       let delMul = new DelegateBinOp2(MyHelperClass.mul)
       let delDiv = new DelegateBinOp2(clazz.Div)
       let delMod = new DelegateBinOp2(clazz.Mod)
       let delPow = new DelegateBinOp2(clazz.Pow) 
       let (x,y) = (10.0, 3.0) 
       printfn "<<Delegate Example 3>>"
       printfn "x = %.2f , y = %.2f" x y
       printfn "x + y = %.2f" (delAdd.Invoke(x,y))
       printfn "x - y = %.2f" (delSub.Invoke(x,y))
       printfn "x * y = %.2f" (delMul.Invoke(x,y))
       printfn "x / y = %.2f" (delDiv.Invoke(x,y))
       printfn "x %% y = %.2f" (delMod.Invoke(x,y))
       printfn "x ** y = %.2f" (delPow.Invoke(x,y))

