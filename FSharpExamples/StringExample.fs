module main.StringExample
open System.Text
open System.IO

type StringExample() = 
    //basics 
    member self.example1() = 
        let mutable str1 = "foo" 
        let mutable str2 = "bar" 
        let mutable joined = str1 + str2 
        printfn "str1 = %s" str1 
        printfn "str2 = %s" str2 
        printfn "joined = %s" joined 
        //verbatim string 
        let verbatimStr = @"<xml version=""1.0"" encoding=""UTF-8"">"
        printfn "verbatimStr = %s" verbatimStr 
        let builder = new StringBuilder()
        let mutable names = ["foo"; "bar" ; "bim"]
        for name in names do 
            builder.AppendLine name 

        printfn "builder = %s" (builder.ToString())
        let writer = new StringWriter() 
        for name in names do 
             writer.WriteLine name 

        printfn "writer = %s" (writer.ToString()) 

        let mutable multilineStr = "foo\n \
                                    bar\n \
                                    bim\n"
        printfn "multilineStr = %s" multilineStr 
        printfn ""





//collect : (char → string) → string → string
//concat : string → seq<string> → string
//exists : (char → bool) → string → bool
//forall : (char → bool) → string → bool
//init : int → (int → string) → string
//iter : (char → unit) → string → unit
//iteri : (int → char → unit) → string → unit
//length : string → int
//map : (char → char) → string → string
//mapi : (int → char → char) → string → string
//replicate : int → string → string
    member self.example2() = 
        let mutable str1 = "foobar"
        let collect = String.collect (fun c -> sprintf "%c " c) str1
        let concat = String.concat "; " ["foo"; "bar"; "bim"; "pako"]
        let exists_f = String.exists (fun c -> c = 'f') str1 
        let exists_e = String.exists (fun c -> c = 'e') str1
        let forall = String.forall (fun c -> c.ToString() = c.ToString().ToLower()) str1 
        let length = String.length str1 
        let map = String.map (fun c -> System.Char.ToUpper c) str1 
        let mapi = String.mapi (fun i c -> if i % 2 = 0 then System.Char.ToUpper c else c) str1
        let replicate = String.replicate 10 "*="
        printfn "str1 = %s" str1 
        printfn "collect = %s" collect 
        printfn "concat = %s" concat 
        printfn "exists_f = %b" exists_f 
        printfn "exists_e = %b" exists_e 
        printfn "forall = %b" forall 
        printfn "length = %d" length 
        printfn "map = %s" map 
        printfn "mapi = %s" mapi
        printfn "replicate = %s" replicate 
        printfn "<<iter>>"
        String.iter (fun c -> printf "+%c+ " c) str1 
        printfn ""
        printfn "<<iteri>>" 
        String.iteri (fun i c -> if i % 2 = 0 then printf "+%c+ " c else printf "-%c- " c) str1  
        printfn ""
        let toUpper = str1.ToUpper() 
        let toUpperInvariant = str1.ToUpperInvariant()
        let toLower = toUpper.ToLower()
        let toLowerInvariant = toUpper.ToLowerInvariant()
        str1 <- "foobar" 
        let startsWithFoo = str1.StartsWith "foo"
        let endsWithBar = str1.EndsWith "bar" 
        let containsFoo = str1.Contains "foo"
        let containsBar = str1.Contains "bar"
        let containsBim = str1.Contains "bim"
        printfn "toUpper = %s" toUpper 
        printfn "toUpperInvariant = %s" toUpperInvariant
        printfn "toLower = %s" toLower 
        printfn "toLowerInvariant = %s" toLowerInvariant
        printfn "startsWithFoo = %b" startsWithFoo
        printfn "endsWithBar = %b" endsWithBar
        printfn "containsFoo = %b" containsFoo
        printfn "containsBar = %b" containsBar 
        printfn "containsBim = %b" containsBim 
        printfn "replicate2 = %s" <| String.replicate 10 "*+-" 
        printfn ""

