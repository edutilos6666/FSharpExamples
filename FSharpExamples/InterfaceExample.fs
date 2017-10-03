module main.InterfaceExample

type IReadable = 
    abstract isReadable:unit->bool
    abstract read:unit-> unit 

type IWritable = 
    abstract isWritable:unit->bool 
    abstract write:unit->unit 

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
           self.Filename.Contains ".read" 

       member self.read()  = 
           if ((self:>IReadable).isReadable()) then 
               printfn "%s was read." self.Filename
           else 
               printfn "%s is not readable." self.Filename


    interface IWritable with 
       member self.isWritable() = 
          self.Filename.Contains ".write" 

       member self.write() = 
          if((self :> IWritable).isWritable()) then
             printfn "%s was written." self.Filename
          else 
             printfn "%s is not writable." self.Filename

    interface IExecutable with 
       member self.isExecutable() = 
           self.Filename.Contains ".exe" 

       member self.execute() = 
          if((self :> IExecutable).isExecutable()) then 
             printfn "%s was executed." self.Filename
          else 
             printfn "%s is not executable." self.Filename





let analyzeCustomFile(cf:CustomFile) :unit = 
    printfn "<<infos on %s>>" cf.Filename
    printfn "is readable = %b" ((cf :>IReadable).isReadable())
    printfn "is writable = %b" ((cf :> IWritable).isWritable())
    printfn "is executable = %b" ((cf :> IExecutable).isExecutable())
    (cf :> IReadable).read()
    (cf :> IWritable).write()
    (cf :> IExecutable).execute()
    printfn ""

type InterfaceExample() = 
    member self.example1() = 
       let cf1 = new CustomFile("foo.read")
       let cf2 = new CustomFile "foo.write"
       let cf3 = new CustomFile "foo.exe" 
       let cf4 = new CustomFile "foo.read.write.exe" 
       analyzeCustomFile cf1
       analyzeCustomFile cf2 
       analyzeCustomFile cf3 
       analyzeCustomFile cf4 
       