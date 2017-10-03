module main.MapExample


type MapExample() = 
    //basics
    member self.example1() = 
        let m1 = Map.empty.
                     Add("foo" , 10).
                     Add("bar", 20).
                     Add("bim", 30).
                     Add("pako", 40) 

        let m2 = ["foo", 10; "bar", 20; "bim", 30; "pako", 40] |> Map.ofList
        printfn "m1 = %A" m1 
        printfn "m2 = %A" m2 
        printfn "m1.[foo] = %A" (m1.["foo"]) 


//Add
//ContainsKey
//Count
//IsEmpty
//Item
//Remove
//TryFind

//        Map.containsKey
//        Map.empty
//        Map.exists
//        Map.exists
//        Map.filter
//        Map.find
//        Map.findKey
//        Map.fold
//        Map.foldBack
//        Map.forall
//        Map.isEmpty
//        Map.iter
//        Map.map
//        Map.partition
//        Map.pick
//        Map.remove
//        Map.toArray
//        Map.toList
//        Map.toSeq
//        Map.tryFind
//        Map.tryFindKey
//        Map.tryPick
    member self.example2() = 
        let mutable m1 = Map.empty
        let mutable m1 = Map.add "foo" 10 m1 
        m1 <- Map.add "bar" 20 m1
        m1 <- Map.add "bim" 30 m1
        m1 <- Map.add "pako" 40 m1
        printfn "add = %A" m1 
        let m2 = Map.ofArray [|("foo" , 10) ; ("bar", 20) ; ("pako", 30)|]
        let m3 = Map.ofList [("foo", 10); ("bar", 20); ("bim", 30) ; ("pako", 40)]
        let m4 = Map.ofSeq ([("foo",10); ("bar", 20) ; ("bim", 30)] |> Seq.ofList )
        printfn "m2 = %A" m2 
        printfn "m3 = %A" m3 
        printfn "m4 = %A" m4
        let containsKey = Map.containsKey "foo" m1 
        let empty = Map.empty
        let exists = Map.exists (fun (k:string) (v:int) -> k.Length = 3) m1 
        let filter = Map.filter (fun (k:string) (v:int) -> k.Length = 3) m1 
        let find = Map.find "foo" m1 
        let findKey = Map.findKey (fun (k:string) (v:int) -> k.Length = 3) m1 
        let fold = Map.fold (fun (acc:int) (k:string) (v:int) -> acc + k.Length + v) 0 m1 
        let foldBack = Map.foldBack (fun (k:string) (v:int) (acc:int) -> acc + k.Length + v) m1 0
        let forall = Map.forall (fun (k:string) (v:int) -> k.Length = 3) m1 
        let isEmpty = Map.isEmpty m1 
        let map = Map.map (fun (k:string) (v:int) -> v*v*v) m1 
        let partition = Map.partition (fun (k:string) (v:int) -> k.Length = 3) m1 
        printfn "containsKey = %A" containsKey
        printfn "empty = %A" empty 
        printfn "exists = %A" exists 
        printfn "filter = %A" filter 
        printfn "find = %A" find
        printfn "findKey = %A" findKey 
        printfn "fold = %A" fold 
        printfn "foldBack = %A" foldBack 
        printfn "forall = %A" forall
        printfn "isEmpty = %A" isEmpty 
        printfn "map = %A" map 
        printfn "partition = %A" partition 
        let pick = Map.pick (fun (k:string) (v:int) -> Some(v)) m1 
        let remove = Map.remove "foo" m1 
        let toArray = Map.toArray m1 
        let toList = Map.toList m1 
        let toSeq = Map.toSeq m1 
        let tryFind = Map.tryFind "foo" m1 
        let tryFindKey = Map.tryFindKey (fun (k:string) (v:int) -> k.Length = 3) m1 
        let tryPick = Map.tryPick (fun (k:string) (v:int) -> Some(v)) m1    
        printfn "pick = %A" pick 
        printfn "remove = %A" remove 
        printfn "toArray = %A" toArray 
        printfn "toList = %A" toList 
        printfn "toSeq = %A" toSeq 
        match tryFind with 
        | Some x -> printfn "tryFind value = %A" x 
        | None -> printfn "tryFind value is None" 

        match tryFindKey with 
        | Some x -> printfn "tryFindKey value = %A" x 
        | None -> printfn "tryFindKey value is None" 

        match tryPick with 
        | Some x -> printfn "tryPick value = %A" x 
        | None -> printfn "tryPick value is None"
        
