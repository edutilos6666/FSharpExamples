module main.FileIOExample

open System 
open System.Text
open System.IO

type FileIOExample() = 
    //Printf.bprintf
    member self.example1() = 
       let mutable builder = new StringBuilder()
       let names = ["foo"; "bar"; "bim"; "pako"]
       Printf.bprintf builder "id = %d\n" 1L 
       Printf.bprintf builder "name = %s\n" "foo"
       Printf.bprintf builder "age = %d\n" 10 
       Printf.bprintf builder "wage = %.2f\n" 100.0 
       Printf.bprintf builder "active = %b\n" true  
       printfn "%s" (builder.ToString())


    //Printf.eprintf 
    member self.example2() = 
       let (id, name, age, wage, active ) = (1L , "foo", 10 , 100.0, true)
       eprintfn "id = %d" id 
       eprintfn "name = %s" name 
       eprintfn "age = %d" age 
       eprintfn "wage = %.2f" wage 
       eprintfn "active = %b" active 


    //fprintfn
    member self.example3() = 
       let (id, name, age, wage, active ) = (1L , "foo", 10 , 100.0, true)
       let writer = new StreamWriter("Worker.txt") 
       fprintfn writer "id = %d" id 
       fprintfn writer "name = %s" name 
       fprintfn writer "age = %d" age 
       fprintfn writer "wage = %.2f" wage 
       fprintfn writer "active = %b" active 
       writer.Close()
       let reader = new StreamReader("Worker.txt") 
       let mutable line = "" 
       while (not (reader.EndOfStream)) do 
           line <- (reader.ReadLine())
           printfn "line = %s" line 
       

    //kbprintf 
    member self.example4() = 
       let (id, name, age, wage, active ) = (1L , "foo", 10 , 100.0, true)
       let builder = new StringBuilder()
       let str = Printf.kbprintf (fun () -> "foo") builder "id = %d" id 
       printfn "%s" (builder.ToString())
       printfn "%s" str 


    //Console class 
    member self.example5() = 
       Console.WriteLine("insert your id: ") 
       let id:int64 = (Convert.ToInt64(Console.ReadLine()))
       Console.WriteLine("insert your name: ") 
       let name:string = Console.ReadLine()
       Console.WriteLine("insert your age: ") 
       let age:int32 = Convert.ToInt32(Console.ReadLine())
       Console.WriteLine("insert your wage: ") 
       let wage:double = Convert.ToDouble(Console.ReadLine())
       Console.WriteLine("insert whether you are active: ") 
       let active:bool = Convert.ToBoolean(Console.ReadLine())
       Console.WriteLine("[id, name, age, wage, active] = [{0}, {1},{2},{3},{4}]", id, name, age, wage, active) 
       

    //File ReadAllText, WriteAllText
    member self.example6() = 
       let filename = "Workers2.txt" 
       let names = ["foo"; "bar"; "bim"; "pako"]
       File.WriteAllLines(filename, names) 
       let lines = File.ReadAllLines(filename) 
       for line in lines do 
          printfn "line = %s" line 


