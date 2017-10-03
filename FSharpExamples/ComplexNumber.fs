module main.ComplexNumber

open System 


type ComplexNumber(re:double, im:double) = 
    let mutable _re = re 
    let mutable _im = im 

    new () = new ComplexNumber(0.0, 0.0) 
    member self.Re 
       with get() = _re 
       and set(value) = _re <- value 

    member self.Im 
       with get() = _im 
       and set(value) = _im <- value 

    static member (+) (cn1:ComplexNumber , cn2:ComplexNumber) = 
       let res = new ComplexNumber() 
       res.Re <- cn1.Re + cn2.Re
       res.Im <- cn1.Im + cn2.Im 
       res 

    static member (-) (cn1:ComplexNumber, cn2:ComplexNumber) = 
       let res = new ComplexNumber() 
       res.Re <- cn1.Re - cn2.Re 
       res.Im <- cn1.Im - cn2.Im 
       res 

    static member (*) (cn1:ComplexNumber , cn2:ComplexNumber) = 
       let res = new ComplexNumber() 
       res.Re <- cn1.Re*cn2.Re - cn1.Im*cn2.Im
       res.Im <- cn1.Re*cn2.Im + cn1.Im*cn2.Re
       res 

    static member (*) (cn:ComplexNumber , factor:double) = 
       let res = new ComplexNumber() 
       res.Re <- cn.Re*factor 
       res.Im <- cn.Im*factor 
       res 

    static member (/) (cn:ComplexNumber, factor:double) = 
       let res = new ComplexNumber() 
       res.Re <- cn.Re / factor 
       res.Im <- cn.Im / factor 
       res 

    static member (/) (cn1:ComplexNumber , cn2:ComplexNumber) = 
       let res = new ComplexNumber() 
       let factor = Math.Pow(cn2.Re, 2.0) + Math.Pow(cn2.Im , 2.0) 
       let mutable temp1 = new ComplexNumber(cn2.Re, -cn2.Im) 
       temp1 <- cn1*temp1 
       temp1 <- temp1/factor 
       temp1 

    override self.ToString() = 
       sprintf "%.2f + i*(%.2f)" self.Re self.Im

