module main.EventExample


type WorkerWithEvent(id:int64,name:string,age:int32,wage:double,active:bool) = 
    let mutable _id = id 
    let mutable _name = name
    let mutable _age = age 
    let mutable _wage = wage 
    let mutable _active = active 

    let idChanged = new Event<unit>()
    let nameChanged = new Event<unit>()
    let ageChanged = new Event<unit>()
    let wageChanged = new Event<unit>()
    let activeChanged = new Event<unit>()


    member self.IdChanged = idChanged.Publish
    member self.NameChanged = nameChanged.Publish
    member self.AgeChanged = ageChanged.Publish
    member self.WageChanged = wageChanged.Publish
    member self.ActiveChanged = activeChanged.Publish

    member self.Id 
       with get() = _id 
       and set(value) = 
           _id <- value 
           idChanged.Trigger()

    member self.Name 
       with get() = _name 
       and set(value) = 
           _name <- value 
           nameChanged.Trigger()

    member self.Age 
       with get() = _age 
       and set(value) = 
           _age <- value 
           ageChanged.Trigger()

    member self.Wage 
       with get() = _wage 
       and set(value) = 
          _wage <- value 
          wageChanged.Trigger()


    member self.Active 
       with get() = _active 
       and set(value) = 
          _active <- value 
          activeChanged.Trigger()


type EventExample() = 
    member self.example1() = 
       let w1 = new WorkerWithEvent(1L, "foo", 10,100.0, true) 
       w1.IdChanged.Add(fun ()-> printfn "new id = %d" w1.Id)
       w1.NameChanged.Add(fun () -> printfn "new name = %s" w1.Name)
       w1.AgeChanged.Add(fun() -> printfn "new age = %d" w1.Age)
       w1.WageChanged.Add(fun() -> printfn "new wage = %.2f" w1.Wage)
       w1.ActiveChanged.Add(fun() -> printfn "new active = %b" w1.Active)
       w1.Id <- 2L 
       w1.Name <- "bar"
       w1.Age <- 20 
       w1.Wage <- 200.0
       w1.Active <- false 
       w1.IdChanged.Add(fun() -> printfn "another IdChanged Event")
       w1.NameChanged.Add(fun() -> printfn "another NameChanged Event")
       w1.AgeChanged.Add(fun() -> printfn "another AgeChanged Event")
       w1.WageChanged.Add(fun() -> printfn "another WageChanged Event")
       w1.ActiveChanged.Add(fun() -> printfn "another ActiveChanged Event")
       printfn ""
       w1.Id <- 3L 
       w1.Name <- "bim"
       w1.Age <- 30 
       w1.Wage <- 300.0
       w1.Active <- true 
       printfn ""

