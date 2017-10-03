module main.ClassExample

open System 
open System.Collections.Generic

type Worker (id:int64, name:string, age:int32, wage:double, active:bool) = 
    let mutable _id = id 
    let mutable _name = name 
    let mutable _age = age 
    let mutable _wage = wage 
    let mutable _active = active 

    //secondary constructor 
    new() = new Worker(0L, "", 0, 0.0, false) 
    
    //getter and setters 
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

    //ToString 
    override self.ToString() :string = 
       sprintf "Worker(%d,%s,%d,%.2f,%b)" self.Id self.Name self.Age self.Wage self.Active 



type WorkerDAOImpl() = 
    let mutable container = new Dictionary<int64,Worker>()
    member self.save (w:Worker) = 
        container.Add(w.Id,w)

    member self.update(id:int64,newW:Worker) = 
        container.Remove(id) 
        container.Add(id, newW)

    member self.remove(id:int64) = 
        container.Remove(id) 

    member self.findById(id:int64) = 
        container.Item(id)

    member self.findAll() = 
        container.Values

type ClassExample() = 
    //test Worker
    member self.example1() = 
       let w1 = new Worker(1L, "foo", 10, 100.0, true) 
       printfn "w1 = %s" (w1.ToString())
       w1.Id <- 2L 
       w1.Name <- "bar"
       w1.Age <- 20 
       w1.Wage <- 200.0
       w1.Active <- false 
       printfn "w1 = %s" (w1.ToString())

    //test WorkerDAOImpl
    member self.example2() = 
       let dao = new WorkerDAOImpl()
       dao.save (new Worker(1L , "foo", 10, 100.0, true))
       dao.save(new Worker(2L, "bar", 20, 200.0 , false))
       dao.save(new Worker(3L, "bim", 30, 300.0, true))
       printfn "<<all workers>>"
       let mutable all = dao.findAll()
       for worker in all do 
           printfn "%s" (worker.ToString())

       dao.update(1L , new Worker(1L , "new foo", 66, 666.6, false))
       let  mutable one = dao.findById(1L) 
       printfn "worker after update = %s" (one.ToString())
       dao.remove(1L) 
       all <- dao.findAll()
       printfn "<<all workers after remove>>"
       for worker in all do 
           printfn "%s" (worker.ToString())


