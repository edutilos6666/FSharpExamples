module main.InheritanceExample

open System 

[<AbstractClass>]
type Shape() = 
    abstract member perimeter:unit->double 
    abstract member area:unit->double 

type Triangle(a:double, b:double, c:double) = 
    inherit Shape()
    let mutable _a = a 
    let mutable _b = b 
    let mutable _c = c 

    member self.A 
       with get() = _a
       and set(value) = _a <- value 

    member self.B 
       with get() = _b 
       and set(value) = _b <- value 

    member self.C 
       with get() = _c
       and set(value) = _c <- value 

    override self.perimeter() = 
       self.A + self.B + self.C 

    override self.area() = 
       let S = self.perimeter() / 2.0 
       Math.Sqrt(S*(S-self.A)*(S-self.B)*(S-self.C))

    override self.ToString() = 
       sprintf "Triangle(%.2f,%.2f,%.2f)" self.A self.B self.C


type Rectangle(width:double, height:double) = 
    inherit Shape() 
    let mutable _width = width 
    let mutable _height = height

    member self.Width 
       with get() = _width 
       and set(value) = _width <- value 

    member self.Height 
       with get() = _height 
       and set(value) = _height <- value 

    override self.perimeter() = 
       2.0*(self.Width + self.Height)

    override self.area() = 
       self.Width * self.Height

    override self.ToString() = 
       sprintf "Rectangle(%.2f,%.2f)" self.Width self.Height


type Circle(r:double) = 
    inherit Shape() 
    let mutable _r = r 

    member self.R 
       with get() = _r 
       and set(value) = _r <- value 

    override self.perimeter() = 
       2.0*Math.PI*self.R 

    override self.area() = 
       Math.PI*Math.Pow(self.R, 2.0)

    override self.ToString() = 
       sprintf "Circle(%.2f)" self.R 


let printShape (s:Shape) = 
    printfn "infos about %s" (s.ToString())
    printfn "perimeter = %.2f" (s.perimeter())
    printfn "area = %.2f" (s.area())
    printfn ""
       


type InheritanceExample() = 
    member self.example1() = 
       printShape(new Triangle(8.0, 9.0, 10.0))
       printShape(new Rectangle(10.0, 20.0))
       printShape(new Circle(10.0))

