module main.DataTypeExample

let example1() = 
    let id:int64 = 1L 
    let name:string = "foo"
    let age:int32 = 10 
    let wage:double = 100.0 
    let active:bool = true 
    printfn "<<Data type examples>>"
    printfn "id = %d" id 
    printfn "name = %s" name 
    printfn "age = %d" age 
    printfn "wage = %.2f" wage 
    printfn "active = %b" active 
    printfn ""


let example2() = 
    let id = 2L 
    let name = "bar"
    let age = 20 
    let wage = 200.0 
    let active = false
    printfn "<<Data type examples>>" 
    printfn "id = %d" id 
    printfn "name = %s" name 
    printfn "age = %d" age 
    printfn "wage = %.2f" wage 
    printfn "active = %b" active 
    printfn ""


