module main.DiscriminatedUnionExample

open System 

type Voltage = 
| High 
| Low


type Shape = 
| Triangle of double*double*double 
| Rectangle of double*double 
| Circle of double 


let toggleVoltage = function 
   |High -> Low 
   |Low -> High 


let perimeter shape = 
   match shape with 
   |Triangle (a,b,c) -> a+ b + c 
   |Rectangle (width, height) -> 2.0*(width + height)
   |Circle r -> 2.0*Math.PI*r 


let area shape = 
   match shape with 
   |Triangle (a,b,c) -> 
           let S = (perimeter shape) /2.0;  
           Math.Sqrt(S*(S-a)*(S-b)*(S-c))
   |Rectangle (width , height) -> width*height 
   |Circle r -> Math.PI*Math.Pow(r, 2.0)

type DiscriminatedUnionExample() = 
    //
    member self.example1() = 
        printfn "<<Voltage example>>" 
        let state1 = High
        let state2 = Low 
        let change = toggleVoltage High 
        printfn "state1 = %A" state1 
        printfn "state2 = %A" state2 
        printfn "change = %A" change 
        printfn "toggleVoltage change = %A" (toggleVoltage change)
        printfn ""
        printfn "<<Shape example>>" 
        let s1 = Triangle(8.0, 9.0, 10.0) 
        let s2 = Rectangle(10.0, 20.0) 
        let s3 = Circle(10.0) 
        printfn "perimeter s1 = %A" (perimeter s1) 
        printfn "area s1 = %A" (area s1)
        printfn "perimeter s2 = %A" (perimeter s2) 
        printfn "area s2 = %A" (area s2) 
        printfn "perimeter s3 = %A" (perimeter s3) 
        printfn "area s3 = %A" (area s3)  
        


