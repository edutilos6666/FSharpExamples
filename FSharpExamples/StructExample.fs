module main.StructExample


type PersonStruct = struct 
    val Id:int64 
    val Name:string 
    val Age:int32
    val Wage:double 
    val Active:bool 

    new (id, name, age, wage, active ) = 
      {Id = id; Name = name; Age = age; Wage = wage; Active = active}

    override self.ToString() = 
       sprintf "PersonStruct(%d,%s,%d,%.2f,%b)" self.Id self.Name self.Age self.Wage self.Active 

end 



type StructExample() = 
    member self.example1() = 
        let mutable p = new PersonStruct(1L, "foo", 10, 100.0, true) 
        printfn "p = %s" (p.ToString())
        p <- new PersonStruct(2L , "bar", 20, 200.0, false) 
        printfn "p = %s" (p.ToString())

