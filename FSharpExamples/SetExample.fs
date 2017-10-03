module main.SetExample


type SetExample() = 
    //creating set 
    member self.example1() = 
        let s1 = Set.empty.Add(10).Add(20).Add(30).Add(40)
        let s2 = Set.ofList ["foo"; "bar"; "bim"; "pako"]
        let s3 = Set.ofArray [|"edu"; "tilos"; "leo"|]
        let s4 = Set.ofSeq {1..5..100}
        printfn "s1 = %A" s1 
        printfn "s2 = %A" s2 
        printfn "s3 = %A" s3
        printfn "s4 = %A" s4
        printfn ""


//add : 'T → Set<'T> → Set<'T>
//contains : 'T → Set<'T> → bool
//count : Set<'T> → int
//difference : Set<'T> → Set<'T> → Set<'T>
//empty : Set<'T>
//exists : ('T → bool) → Set<'T> → bool
//filter : ('T → bool) → Set<'T> → Set<'T>
//fold : ('State → 'T → 'State) → 'State → Set<'T> → 'State
//foldBack : ('T → 'State → 'State) → Set<'T> → 'State → 'State
//forall : ('T → bool) → Set<'T> → bool
//intersect : Set<'T> → Set<'T> → Set<'T>
//intersectMany : seq<Set<'T>> → Set<'T>
//isEmpty : Set<'T> → bool
//isProperSubset : Set<'T> → Set<'T> → bool
//isProperSuperset : Set<'T> → Set<'T> → bool
//isSubset : Set<'T> → Set<'T> → bool
//isSuperset : Set<'T> → Set<'T> → bool
//iter : ('T → unit) → Set<'T> → unit
//map : ('T → 'U) → Set<'T> → Set<'U>
//maxElement : Set<'T> → 'T
//minElement : Set<'T> → 'T
//ofArray : 'T array → Set<'T>
//ofList : 'T list → Set<'T>
//ofSeq : seq<'T> → Set<'T>
//partition : ('T → bool) → Set<'T> → Set<'T> * Set<'T>
//remove : 'T → Set<'T> → Set<'T>
//singleton : 'T → Set<'T>
//toArray : Set<'T> → 'T array
//toList : Set<'T> → 'T list
//toSeq : Set<'T> → seq<'T>
//union : Set<'T> → Set<'T> → Set<'T>
//unionMany : seq<Set<'T>> → Set<'T>
    //set methods 
    member self.example2() = 
    //add : 'T → Set<'T> → Set<'T>
//contains : 'T → Set<'T> → bool
//count : Set<'T> → int
//difference : Set<'T> → Set<'T> → Set<'T>
//empty : Set<'T>
//exists : ('T → bool) → Set<'T> → bool
//filter : ('T → bool) → Set<'T> → Set<'T>
//fold : ('State → 'T → 'State) → 'State → Set<'T> → 'State
//foldBack : ('T → 'State → 'State) → Set<'T> → 'State → 'State
//forall : ('T → bool) → Set<'T> → bool
//intersect : Set<'T> → Set<'T> → Set<'T>
//intersectMany : seq<Set<'T>> → Set<'T>
//isEmpty : Set<'T> → bool
//isProperSubset : Set<'T> → Set<'T> → bool
//isProperSuperset : Set<'T> → Set<'T> → bool
//isSubset : Set<'T> → Set<'T> → bool
//isSuperset : Set<'T> → Set<'T> → bool
//iter : ('T → unit) → Set<'T> → unit
//map : ('T → 'U) → Set<'T> → Set<'U>
//maxElement : Set<'T> → 'T
//minElement : Set<'T> → 'T
        let s1 = Set.ofSeq {1..10}
        let s2 = Set.ofSeq {5..15}
        let add = Set.empty.Add(10).Add(20).Add(30).Add(40).Add(50)
        let contains = Set.contains 10 s1 
        let count = Set.count s1 
        let difference = Set.difference s1 s2 
        let exists = Set.exists (fun el -> el % 2 = 0) s1 
        let filter = Set.filter (fun el -> el % 2 = 0) s1 
        let fold = Set.fold (fun acc el -> acc + el) 0 s1 
        let foldBack = Set.foldBack (fun el acc -> acc + el) s1 0 
        let forall = Set.forall (fun el -> el % 2 = 0) s1 
        let intersect = Set.intersect s1 s2 
        let intersectMany = Set.intersectMany [s1; s2; Set.ofSeq {10..20}]
        let isEmpty = Set.isEmpty s1 
        let isProperSubset = Set.isProperSubset s1 s2 
        let isProperSuperset = Set.isProperSuperset s1 s2 
        let isSubset = Set.isSubset s1 s2 
        let isSuperset = Set.isSuperset s1 s2 
        let map = Set.map (fun el -> el * el) s1
        let maxElement = Set.maxElement s1 
        let minElement = Set.minElement s1  
        printfn "add = %A" add 
        printfn "contains  = %A" contains 
        printfn  "count = %A" count 
        printfn "difference = %A" difference 
        printfn "exists = %A" exists 
        printfn "filter = %A" filter 
        printfn "fold = %A" fold 
        printfn "foldBack = %A" foldBack 
        printfn "forall = %A" forall 
        printfn "intersect = %A" intersect 
        printfn "intersectMany = %A" intersectMany
        printfn "isEmpty = %A" isEmpty 
        printfn "isProperSubset = %A" isProperSubset
        printfn "isProperSuperset = %A" isProperSuperset
        printfn "isSubset = %A" isSubset 
        printfn "isSuperset = %A" isSuperset 
        printfn "map = %A" map 
        printfn "maxElement = %A" maxElement 
        printfn "minElement = %A" minElement 
        let ofArray = Set.ofArray [|"foo"; "bar"; "bim"; "pako"|]
        let ofList = Set.ofList ["foo"; "bar"; "bim"; "pako"]
        let ofSeq = Set.ofSeq {1..5 ..100}
        let partition = Set.partition (fun el -> el % 2 = 0) s1
        let remove = Set.remove 10 s1 
        let singleton = Set.singleton 10 
        let toArray = Set.toArray s1 
        let toList = Set.toList s1 
        let toSeq = Set.toSeq s1 
        let union = Set.union s1 s2 
        let unionMany = Set.unionMany [s1; s2; Set.ofSeq {10..20}]
        printfn "ofArray = %A" ofArray
        printfn "ofList = %A" ofList 
        printfn "ofSeq = %A" ofSeq 
        printfn "partition = %A" partition 
        printfn "remove = %A" remove 
        printfn "singleton = %A" singleton 
        printfn "toArray = %A" toArray 
        printfn "toList = %A" toList 
        printfn "toSeq = %A" toSeq
        printfn "union = %A" union 
        printfn "unionMany = %A" unionMany 
        printfn "<<iter>>" 
        Seq.iter (fun el-> printf "%d ; " el) s1 
        printfn "" 

