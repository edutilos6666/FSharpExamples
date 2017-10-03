module main.GenericsExample



type GenericWorker<'T1,'T2,'T3,'T4,'T5> (id:'T1,name:'T2, age:'T3, wage:'T4, active:'T5) = 
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


    override self.ToString() :string = 
       sprintf "GenericWorker(%A,%A,%A,%A,%A)" self.Id self.Name self.Age self.Wage self.Active 


type GenericsExample() = 

    member self.printProps<'T1,'T2,'T3,'T4,'T5> (id:'T1) (name:'T2) (age:'T3) (wage:'T4) (active:'T5) = 
       printfn "<<Properties>>"
       printfn "id = %A" id 
       printfn "name = %A" name 
       printfn "age = %A" age 
       printfn "wage = %A" wage 
       printfn "active = %A" active    

    member self.example1() = 
       self.printProps<int64,string,int32,double,bool> 1L "foo" 10 100.0 true 
       self.printProps<string,string,string,string,string> "2" "bar" "20" "200.0" "false"


    member self.example2() = 
       let mutable w = new GenericWorker<int64,string,int32,double,bool>(1L, "foo", 10, 100.0, true) 
       printfn "%s" (w.ToString())
       w.Id <- 2L 
       w.Name <- "bar" 
       w.Age <- 20 
       w.Wage <- 200.0 
       w.Active <- false 
       printfn "%s" (w.ToString())
       let mutable w2 = new GenericWorker<string,string,string,string,string>("2", "bar", "20","200.0", "false")
       printfn "%s" (w2.ToString()) 
