module main.OperatorOverloadingExample


type Box(width:double, height:double, depth:double) = 
    let mutable _width = width 
    let mutable _height = height 
    let mutable _depth = depth 

    new () = new Box(0.0, 0.0, 0.0) 

    member self.Width 
       with get() = _width 
       and set(value) = _width <- value 

    member self.Height 
       with get() = _height 
       and set(value) = _height <- value 

    member self.Depth 
       with get() = _depth 
       and set(value) = _depth <- value 


    member self.volume() = 
       self.Width * self.Height * self.Depth

    static member (+) (b1:Box , b2:Box) = 
       let ret =  new Box()
       ret.Width <- b1.Width + b2.Width
       ret.Height <- b1.Height + b2.Height
       ret.Depth <- b1.Depth + b2.Depth
       ret 

    static member (-) (b1:Box , b2:Box) = 
       let ret = new Box() 
       ret.Width <- b1.Width - b2.Width
       ret.Height <- b1.Height - b2.Height
       ret.Depth <- b1.Depth - b2.Depth
       ret 

    static member (*) (b1:Box, b2:Box) = 
       let ret = new Box()
       ret.Width <- b1.Width * b2.Width
       ret.Height <- b1.Height * b2.Height
       ret.Depth <- b1.Depth * b2.Depth
       ret 

    static member (/) (b1:Box, b2:Box) = 
       let ret = new Box()
       ret.Width <- b1.Width / b2.Width
       ret.Height <- b1.Height / b2.Height
       ret.Depth <- b1.Depth / b2.Depth
       ret 

    static member (%) (b1:Box, b2:Box) =
       let ret = new Box()
       ret.Width <- b1.Width % b2.Width
       ret.Height <- b1.Height % b2.Height
       ret.Depth <- b1.Depth % b2.Depth
       ret 


   
    static member op_Equality (b1:Box , b2:Box) = 
       let v1 = b1.volume()
       let v2 = b2.volume()
       v1 = v2 

    static member op_Inequality (b1:Box , b2:Box) = 
       let v1 = b1.volume() 
       let v2 = b2.volume()
       v1 <> v2 

    //>, >= , < , <= are not working properly 
    member self.gt(other:Box) = 
       let v1 = self.volume()
       let v2 = other.volume()
       v1 > v2 

    member self.ge(other:Box) = 
       let v1 = self.volume()
       let v2 = self.volume()
       v1 >= v2 

    member self.lt(other:Box) = 
       let v1 = self.volume()
       let v2 = self.volume()
       v1 < v2 

    member self.le(other:Box) = 
       let v1 = self.volume()
       let v2 = self.volume()
       v1 <= v2 

    override self.ToString() = 
       sprintf "Box(%.2f,%.2f,%.2f)" self.Width self.Height self.Depth




type OperatorOverloadingExample() = 
    member self.example1() = 
       let b1 = new Box(3.0, 3.0, 3.0) 
       let b2 = new Box(2.0, 2.0, 2.0) 
       let bAdd = b1 + b2 
       let bSub = b1 - b2 
       let bMul = b1 * b2 
       let bDiv = b1 / b2 
       let bMod = b1 % b2 
       let bEq = b1 = b2 
       let bNe = b1 <> b2 
       let bGt = b1.gt(b2) 
       let bGe = b1.ge(b2) 
       let bLt = b1.lt(b2)
       let bLe = b1.le(b2) 
       printfn "<<Operator Overloading Example>>"
       printfn "b1 = %A" b1 
       printfn "b2 = %A" b2 
       printfn "b1 + b2 = %A" bAdd
       printfn "b1 - b2 = %A" bSub 
       printfn "b1 * b2 = %A" bMul 
       printfn "b1 / b2 = %A" bDiv 
       printfn "b1 %% b2 = %A" bMod 
       printfn "b1 = b2 = %A" bEq 
       printfn "b1 <> b2 = %A" bNe 
       printfn "b1 > b2 = %A" bGt 
       printfn "b1 >= b2 = %A" bGe 
       printfn "b1 < b2 = %A" bLt 
       printfn "b1 <= b2 = %A" bLe
       printfn ""


