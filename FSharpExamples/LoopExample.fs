module main.LoopExample

type LoopExample() = 
    //for to and for downto 
    member self.example1() = 
        printfn "<<for ... to example >>"
        for i = 1 to 10 do 
            printf "%d ; " i 
        printfn ""
        printfn "<<for ... downto example >>"
        for i = 10 downto 1 do 
            printf "%d ; " i 
        printfn ""

    //for ... in 
    member self.example2() =         
        let numbers = [10; 20; 30; 40; 50]
        printfn "<<numbers>>"
        for i in numbers do 
            printf "%d ; " i 
        printfn ""
        let names = ["foo"; "bar"; "bim"; "pako"]
        printfn "<<names>>" 
        for name in names do 
            printf "%s ; " name 
        printfn "" 
        let wages = [100.0; 200.0; 300.0; 400.0; 500.0]
        printfn "<<wages>>" 
        for wage in wages do 
            printf "%.2f ; " wage 
        printfn "" 
        
        let seq1 = seq { for i in 1 .. 10 -> (i, i*i , i*i*i)}
        printfn "<<seq1>>" 
        for (i , i_squared, i_cube) in seq1 do 
            printfn "%d => %d => %d" i i_squared i_cube 
        printfn ""
        
        
    //while ... do
    member self.example3() =         
        let mutable n = 0 
        while(n < 10) do 
            printfn "number = %d" n 
            n<- n + 1
        printfn ""

