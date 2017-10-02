// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
module main 

open System

let test_DataTypes = 
    let id = 1L 
    let name = "foo"
    let age = 10 
    let wage = 100.0 
    let active = true 
    printfn "id = %d" id 
    printfn "name = %s" name 
    printfn "age = %d" age 
    printfn "wage = %.2f" wage 
    printfn "active = %b" active 



type Person(id , name, age, wage, active) = 
    member this.id = id 
    member this.name = name 
    member this.age = age 
    member this.wage = wage 
    member this.active = active 


let printPerson (p:Person) = 
    printfn "[id, name , age , wage, active ] = [%d,%s,%d,%.2f,%b]" 
             p.id p.name p.age p.wage p.active   

let test_Person = 
    let mutable p1 = new Person(1, "foo", 10 , 100.0, true)
    printfn "<<Printing Person>>"
    printPerson p1 
    p1 <- new Person(2 , "bar", 10 , 100.0, false)  
    printPerson p1 



type Worker(id, name, age, wage, active) = 
     let mutable Id = id 
     let mutable Name = name 
     let mutable Age = age 
     let mutable Wage = wage 
     let mutable Active = active 

     member self.setId(value) = Id <- value 
     member self.getId() = Id 
     member self.setName(value) = Name  <- value 
     member self.getName() = Name 
     member self.setAge(value) = Age <- value 
     member self.getAge() = Age 
     member self.setWage(value) = Wage <- value 
     member self.getWage() = Wage 
     member self.setActive(value) = Active <- value 
     member self.isActive() = Active 
     member self.toString() = 
            sprintf "Worker(%d,%s,%d,%.2f,%b)" Id  Name Age Wage Active 


let printWorker( w:Worker) = 
    printfn "%s" (w.toString() )


let testWorker = 
    let mutable w = new Worker(1, "foo", 10, 100.0, true)
    printWorker w
    w.setId(2) 
    w.setName("new foo")
    w.setAge(20)
    w.setWage(200.0)
    w.setActive(false)
    printWorker w
     

         
  

type Programmer(id:int64, name:string, age:int32, wage:double, active:bool) = 
     let mutable Id = id 
     let mutable Name = name 
     let mutable Age = age 
     let mutable Wage = wage 
     let mutable Active = active 

     member self.setId(value:int64) = Id <- value 
     member self.getId() = Id 
     member self.setName(value:string) = Name <- value 
     member self.getName() = Name 
     member self.setAge(value:int32) = Age <- value 
     member self.getAge() = Age 
     member self.setWage(value:double) = Wage <- value 
     member self.getWage() = Wage 
     member self.setActive(value:bool) = Active <- value 
     member self.isActive() = Active 
     member self.toString() = 
            sprintf "Programmer(%d,%s,%d,%.2f,%b)" Id Name Age Wage Active  


let testProgrammer = 
    let p1 = new Programmer(1L, "foo", 10, 100.0, true) 
    printfn "p1 = %s" (p1.toString()) 
    p1.setId(2L) 
    p1.setName("bar")
    p1.setAge(20)
    p1.setWage(200.0)
    p1.setActive(false)
    printfn "p1 = %s" (p1.toString())



type ComplexNumber (re:double, im:double) = 
     let mutable Re = re 
     let mutable Im = im 
     //secondary constructor 
     new () = ComplexNumber(0.0, 0.0)
     
     //getter and setter 
     member self.getRe() = Re 
     member self.setRe(value:double) = Re <-value 
     member self.getIm() = Im 
     member self.setIm(value:double) = Im <- value 
     //other methods 
     member self.add(other:ComplexNumber) = 
         let mutable res = new ComplexNumber() 
         res.setRe(self.getRe() + other.getRe())
         res.setIm(self.getIm() + other.getIm())
         res 

     member self.sub(other:ComplexNumber) = 
         let mutable res = new ComplexNumber() 
         res.setRe(self.getRe() - other.getRe())
         res.setIm(self.getIm() - other.getIm())
         res 

     member self.mul(other:ComplexNumber) = 
         let mutable res = new ComplexNumber() 
         res.setRe(self.getRe()*other.getRe() - self.getIm()*other.getIm())
         res.setIm(self.getRe()*other.getIm() + self.getIm()*other.getRe())
         res 

     member self.mulByFactor(factor:double) = 
         let res = new ComplexNumber() 
         res.setRe(self.getRe()*factor)
         res.setIm(self.getIm()*factor)
         res 
     
     member self.divByFactor(factor:double) = 
         let res = new ComplexNumber() 
         res.setRe(self.getRe()/factor)
         res.setIm(self.getIm()/factor)
         res 

     member self.div(other:ComplexNumber) = 
         let factor = Math.Pow(other.getRe(), 2.0) + Math.Pow(other.getIm(),2.0)
         let temp1 = new ComplexNumber(other.getRe(), -other.getIm())
         let mutable res = self.mul(temp1) 
         res <- res.divByFactor(factor) 
         res 
      
     member self.toString() = 
         sprintf "%.2f + i*(%.2f)" Re Im 
  
  
   
let testComplexNumber = 
    let cn1 = new ComplexNumber(3.0, 3.0)
    let cn2 = new ComplexNumber(2.0, 2.0)
    let cnAdd = cn1.add(cn2) 
    let cnSub = cn1.sub(cn2)
    let cnMul = cn1.mul(cn2) 
    let cnDiv = cn1.div(cn2)
    printfn "<<Complex Numbers>>"
    printfn "cn1 = %s" (cn1.toString())
    printfn "cn2 = %s" (cn2.toString())
    printfn "cn1 + cn2 = %s" (cnAdd.toString())
    printfn "cn1 - cn2 = %s" (cnSub.toString())
    printfn "cn1 * cn2 = %s" (cnMul.toString())
    printfn "cn1 / cn2 = %s" (cnDiv.toString())



//class with true getter and setter 
type Programmer3(id:int64 , name:string , age:int32, wage:double, active:bool) = 
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
        and set(value) = _name <-value 

     member self.Age 
        with get() = _age 
        and set(value) = _age <-value 

     member self.Wage 
        with get() = _wage 
        and set(value) = _wage <-value 

     member self.Active 
        with get() = _active 
        and set(value) = _active <- value 



     member self.toString() = 
         sprintf "Programmer3(%d,%s,%d,%.2f,%b)" self.Id self.Name self.Age self.Wage self.Active 


let testProgrammer3 = 
    let p1 = new Programmer3(1L, "foo", 10, 100.0, true) 
    printfn "p1 = %s" (p1.toString())
    p1.Id <- 2L 
    p1.Name <- "new foo"
    p1.Age <- 20 
    p1.Wage <- 200.0 
    p1.Active <- false 

    printfn "p1 = %s" (p1.toString())
    



// interface example 
type IReadable = 
   abstract isReadable: unit->bool 
   abstract read: unit->unit 

type IWritable = 
   abstract isWritable: unit->bool
   abstract write: unit->unit

type IExecutable = 
   abstract isExecutable:unit->bool
   abstract execute:unit->unit 

type CustomFile(filename:string) = 
   let mutable _filename = filename 

   member self.Filename 
      with get() = _filename 
      and set(value) = _filename <- value 

   interface IReadable with 
      member self.isReadable() = 
          self.Filename.Contains(".read")

      member self.read() = 
          if((self :> IReadable).isReadable()) then  
             printfn "%s was read." self.Filename 
          else 
             printfn "%s is not readable." self.Filename 

   interface IWritable with 
       member self.isWritable() = 
           self.Filename.Contains(".write")

       member self.write() = 
           if((self :> IWritable).isWritable()) then 
              printfn "%s was written." self.Filename 
           else 
              printfn "%s is not writable." self.Filename 

   interface IExecutable with 
       member self.isExecutable() = 
           self.Filename.Contains(".exe") 
      
       member self.execute() = 
           if((self :> IExecutable).isExecutable()) then 
               printfn "%s was executed." self.Filename 
           else 
               printfn "%s is not executable." self.Filename 

   override self.ToString()  = 
        sprintf "%s" self.Filename 


let testCustomFile = 
    let cf1:CustomFile = new CustomFile("foo.read")
    printfn "<<information on %s>>" cf1.Filename 
    printfn "is readable = %b" ((cf1 :> IReadable).isReadable())
    printfn "is writable = %b" ((cf1 :> IWritable).isWritable())
    printfn "is executable = %b" ((cf1 :> IExecutable).isExecutable())
    (cf1 :> IReadable).read()
    (cf1 :> IWritable).write()
    (cf1 :> IExecutable).execute()
    printfn ""
    let cf2 = new CustomFile("foo.write")
    printfn "<<information on %s>>" cf2.Filename 
    printfn "is readable = %b" ((cf2 :> IReadable).isReadable())
    printfn "is writable = %b" ((cf2 :> IWritable).isWritable())
    printfn "is executable = %b" ((cf2 :> IExecutable).isExecutable())
    (cf2 :> IReadable).read()
    (cf2 :> IWritable).write()
    (cf2 :> IExecutable).execute()
    printfn ""
    let cf3 = new CustomFile("foo.exe")
    printfn "<<information on %s>>" cf3.Filename 
    printfn "is readable = %b" ((cf3 :> IReadable).isReadable())
    printfn "is writable = %b" ((cf3 :> IWritable).isWritable())
    printfn "is executable = %b" ((cf3 :> IExecutable).isExecutable())
    (cf3 :> IReadable).read()
    (cf3 :> IWritable).write()
    (cf3 :> IExecutable).execute()
    printfn ""
    let cf4 = new CustomFile("foo.read.write.exe")
    printfn "<<information on %s>>" cf4.Filename 
    printfn "is readable = %b" ((cf4 :> IReadable).isReadable())
    printfn "is writable = %b" ((cf4 :> IWritable).isWritable())
    printfn "is executable = %b" ((cf4 :> IExecutable).isExecutable())
    (cf4 :> IReadable).read()
    (cf4 :> IWritable).write()
    (cf4 :> IExecutable).execute()
    printfn ""



//abstract class 
[<AbstractClass>]
type Shape() = 
    abstract member perimeter:unit -> double
    abstract member area: unit -> double 

type Triangle(a:double, b:double , c:double) = 
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
       let P = self.perimeter() / 2.0 
       double (Math.Sqrt(P*(P-self.A)*(P-self.B)*(P-self.C)))

    override self.ToString() =
        sprintf "Triangle(%.2f,%.2f,%.2f" self.A self.B self.C 



type Rectangle(width:double , height:double) = 
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
        sprintf "Triangle(%.2f,%.2f)" self.Width self.Height


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


let testAbstractClass = 
    let s1:Triangle = new Triangle(8.0, 9.0, 10.0)
    printfn "<<infos on %s>>" (s1.ToString())
    printfn "perimeter = %.2f" (s1.perimeter())
    printfn "area = %.2f" (s1.area())
    let s2:Rectangle = new Rectangle(10.0, 20.0) 
    printfn "<<infos on %s>>" (s2.ToString())
    printfn "perimeter = %.2f" (s2.perimeter())
    printfn "area = %.2f" (s2.area())
    let s3:Circle = new Circle(10.0) 
    printfn "<<infos on %s>>" (s3.ToString())
    printfn "perimeter = %.2f" (s3.perimeter())
    printfn "area = %.2f" (s3.area())
    


// operator overloading 
type Box(width:double, height:double, depth: double)  = 
    let mutable _width = width 
    let mutable _height = height 
    let mutable _depth = depth 

    interface System.IComparable<Box> with 
       member self.CompareTo(other:Box) = 
          self.Volume().CompareTo(other.Volume())


    member self.Width 
      with get() = _width 
      and set(value) = _width <- value 

    member self.Height 
      with get() = _height 
      and set(value) = _height <- value 

    member self.Depth 
      with get() = _depth 
      and set(value) = _depth <- value 

    //secondary constructor 
    new() = Box(0.0, 0.0, 0.0)
    
    //volume
    member self.Volume() = 
        self.Width*self.Height*self.Depth 
        
    //operator overloading 
    static member (+) (b1:Box , b2:Box) = 
        let res = new Box()
        res.Width <- b1.Width + b2.Width 
        res.Height <- b1.Height + b2.Height 
        res.Depth <- b1.Depth + b2.Depth 
        res 

    static member (-) (b1:Box, b2:Box) = 
        let res = new Box()
        res.Width <- b1.Width - b2.Width
        res.Height <- b1.Height - b2.Height
        res.Depth <- b1.Depth - b2.Depth
        res 

    static member (*) (b1:Box, b2:Box) = 
       let res = new Box()
       res.Width <- b1.Width * b2.Width 
       res.Height <- b1.Height * b2.Height
       res.Depth <- b1.Depth * b2.Depth
       res 

    static member (/) (b1:Box , b2:Box) = 
       let res = new Box()
       res.Width <- b1.Width / b2.Width
       res.Height <- b1.Height / b2.Height
       res.Depth <- b1.Depth / b2.Depth
       res 

    static member (%) (b1:Box , b2:Box) = 
       let res = new Box()
       res.Width <- b1.Width % b2.Width
       res.Height <- b1.Height % b2.Height
       res.Depth <- b1.Depth % b2.Depth
       res 

    static member op_Equality (b1:Box, b2:Box) = 
       let v1 = b1.Volume()
       let v2 = b2.Volume()
       v1 = v2 

    static member op_Inequality (b1:Box, b2:Box) = 
       let v1 = b1.Volume()
       let v2 = b2.Volume()
       v1 <> v2 

    static member op_GreaterThan (b1:Box , b2:Box) = 
       let v1 = b1.Volume()
       let v2 = b2.Volume()
       v1 > v2 

    static member op_GreaterThanOrEqual (b1:Box, b2:Box) = 
       let v1 = b1.Volume()
       let v2 = b2.Volume()
       v1 >= v2 

    static member op_LessThan (b1:Box, b2:Box) = 
       let v1 = b1.Volume()
       let v2 = b2.Volume()
       v1 < v2 

    static member op_LessThanOrEqual (b1:Box, b2:Box) = 
       let v1 = b1.Volume()
       let v2 = b2.Volume()
       v1 <= v2 

  
    override self.ToString() = 
       sprintf "Box(%.2f,%.2f,%.2f)" self.Width self.Height self.Depth





let testOperatorOverloading = 
    let b1 = new Box(3.0, 3.0, 3.0) 
    let b2 = new Box(2.0, 2.0, 2.0) 
    let bAdd = b1 + b2 
    let bSub = b1 - b2 
    let bMul = b1 * b2 
    let bDiv = b1 / b2 
    let bMod = b1 % b2 
    let bEq = b1 = b2 
    let bNe = b1 <> b2 
//    let gt = b1 > b2   -> does not work at runtime
//    let ge = b1 >= b2  -> does not work at runtime 
    printfn "b1 = %s" (b1.ToString())
    printfn "b2 = %s" (b2.ToString())
    printfn "b1 + b2 = %s" (bAdd.ToString())
    printfn "b1 - b2 = %s" (bSub.ToString())
    printfn "b1 * b2 = %s" (bMul.ToString())
    printfn "b11 / b2 = %s" (bDiv.ToString())
    printfn "b1 %% b2 = %s" (bMod.ToString())
    printfn "b1 = b2 = %b" bEq 
    printfn "b1 <> b2 = %b" bNe 
    printfn ""



//struct example 
type PersonStruct = struct 
     val Id: int64 
     val Name: string 
     val Age: int32 
     val Wage: double 
     val Active: bool 
     new (id, name, age, wage, active) = 
       {Id=id; Name=name; Age=age; Wage=wage; Active=active}

     override self.ToString() = 
        sprintf "PersonStruct(%d,%s,%d,%.2f,%b)" self.Id self.Name self.Age self.Wage self.Active
end 


let testPersonStruct = 
   let mutable p = new PersonStruct(1L, "foo", 10 , 100.0, true) 
   printfn "p = %s" (p.ToString())
   p <- new PersonStruct(2L, "bar", 20, 200.0, false) 
   printfn "p = %s" (p.ToString())
   


//event example 
type WorkerWithEvent(id:int64, name:string , age:int32, wage:double, active:bool) = 
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

    new() = new WorkerWithEvent(0L , "", 0, 0.0, false)


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


    override self.ToString() = 
        sprintf "WorkerWithEvent(%d,%s,%d,%.2f,%b)" self.Id self.Name self.Age self.Wage self.Active

let testWorkerWithEvent = 
    let w1 = new WorkerWithEvent(1L, "foo", 10, 100.0, true)
    w1.IdChanged.Add(fun () -> printf "new Id = %d\n" w1.Id)
    w1.NameChanged.Add(fun() -> printf "new name = %s\n" w1.Name)
    w1.AgeChanged.Add(fun() -> printf "new age = %d\n" w1.Age)
    w1.WageChanged.Add(fun() -> printf "new wage = %.2f\n" w1.Wage)
    w1.ActiveChanged.Add(fun() -> printf "new active = %b\n" w1.Active)
    w1.Id <- 2L 
    w1.Name <- "bar"
    w1.Age <- 20 
    w1.Wage <- 200.0 
    w1.Active <- false
    w1.IdChanged.Add(fun() -> printf "Another IdChanged Event\n")
    w1.NameChanged.Add(fun() -> printf "Another NameChanged Event\n")
    w1.AgeChanged.Add(fun() -> printf "Another AgeChanged Event\n")
    w1.WageChanged.Add(fun() -> printf "Another WageChanged Event\n")
    w1.ActiveChanged.Add(fun() -> printf "Another ActiveChanged Event\n")
    printfn ""
    w1.Id <- 3L 
    w1.Name <- "bim"
    w1.Age <- 30
    w1.Wage <- 300.0
    w1.Active <- true 
 
    

[<EntryPoint>]
let main argv = 
   test_DataTypes 
   printfn ""
   test_Person
   printfn ""
   testWorker
   printfn ""
   testProgrammer
   printfn ""
   testComplexNumber 
   printfn ""
   testProgrammer3 
   printfn ""
   testCustomFile
   printfn ""
   testAbstractClass
   printfn ""
   testOperatorOverloading
   printfn "" 
   testPersonStruct
   printfn ""
   testWorkerWithEvent
   0 // return an integer exit code


