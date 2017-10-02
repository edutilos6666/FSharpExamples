module main.Arithmetic 
let add x y =
   x + y

let sub x y =
   x - y
       
let mult x y =
   x * y

let div x y =
   x / y


type Worker(id:int64, name:string , age:int32, wage:double, active:bool) = 
    let mutable _id = id 
    let mutable _name = name 
    let mutable _age = age 
    let mutable _wage = wage
    let mutable _active = active 

    member self.Id
       with get() = _id 
       and set(value) = _id <- value 

    member self.Name 
       with get() = _name 
       and set(value) = _name <- value 

    member self.Age 
       with get() = _age 
       and set(value) = _age <- value 

    member self.Wage 
       with get() = _wage 
       and set(value) = _wage <- value 

    member self.Active 
       with get() = _active 
       and set(value) = _active <- value 

    override self.ToString() = 
        sprintf "Worker(%d,%s,%d,%.2f,%b)" self.Id self.Name self.Age self.Wage self.Active



