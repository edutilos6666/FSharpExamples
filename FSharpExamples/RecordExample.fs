module main.RecordExample


//type person = {
//   id : int64;  
//   name : string;
//   age : int32; 
//   wage : double; 
//   active : bool
//}

//mutable record 
type person = {
   mutable id : int64;  
   mutable name : string;
   mutable age : int32; 
   mutable wage : double; 
   mutable active : bool
}


let printPerson p = 
    printfn "<<Person Properties>>"
    printfn "id = %d" p.id 
    printfn "name = %s" p.name 
    printfn "age = %d" p.age 
    printfn "wage = %.2f" p.wage 
    printfn "active = %b" p.active 
    printfn "" 


type student = {
      id : int
      name : string 
      registrationText : string 
      isRegistered : bool  
}

type RecordExample() = 

         
    member self.example1() = 
        let mutable p1 = {id = 1L; name = "foo"; age = 10; wage = 100.0; active = true}
        printPerson p1 
        p1.id <- 2L 
        p1.name <- "bar"
        p1.age <- 20 
        p1.wage <- 200.0 
        p1.active <- false 
        printPerson p1 


  


    member self.example2() = 
        let generateStudent() = 
            {id = 1; name = "foo"; registrationText = "Not Registered"; isRegistered = false}

        let registerStudent st = 
            {st with 
                registrationText = "Registered"; 
                isRegistered = true 
             }

        let printStudent msg  st = 
            printfn "%s => %A" msg st 

        let mutable st = generateStudent() 
        printStudent "Before registration" st 
        st <- registerStudent st
        printStudent "After registration" st 

          
            

