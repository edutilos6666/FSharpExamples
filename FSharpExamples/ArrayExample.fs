module main.ArrayExample

open System 

type ArrayExample() = 
    member self.example1() = 
        let arr1 = [|10;20;30;40;50|]
        let arr2 = [|
                     10
                     20
                     30
                     40
                     50
                     |]
        let arr3 = [| for i in 1..10 -> i*i*i|]
        printfn "arr1 = %A" arr1
        printfn "arr2 = %A" arr2 
        printfn "arr3 = %A" arr3 
        


//append : 'T [] → 'T [] → 'T []
//average : ^T [] → ^T
//averageBy : ('T → ^U) → 'T [] → ^U
//blit : 'T [] → int → 'T [] → int → int → unit
//choose : ('T → U option) → 'T [] → 'U []
//collect : ('T → 'U []) → T [] → 'U []
//concat : seq<'T []> → 'T []
//copy : 'T → 'T []
//create : int → 'T → 'T []
//empty : 'T []
//exists : ('T → bool) → 'T [] → bool
//exists2 : ('T1 → 'T2 → bool) → 'T1 [] → 'T2 [] → bool
//fill : 'T [] → int → int → 'T → unit
//filter : ('T → bool) → 'T [] → 'T []
//find : ('T → bool) → 'T [] → 'T
//findIndex : ('T → bool) → 'T [] → int
//fold : ('State → 'T → 'State) → 'State → 'T [] → 'State
//fold2 : ('State → 'T1 → 'T2 → 'State) → 'State → 'T1 [] → 'T2 [] → 'State
//foldBack : ('T → 'State → 'State) → 'T [] → 'State → 'State
//foldBack2 : ('T1 → 'T2 → 'State → 'State) → 'T1 [] → 'T2 [] → 'State → 'State
//forall : ('T → bool) → 'T [] → bool
//forall2 : ('T1 → 'T2 → bool) → 'T1 [] → 'T2 [] → bool
//get : 'T [] → int → 'T
//init : int → (int → 'T) → 'T []
//isEmpty : 'T [] → bool
//iter : ('T → unit) → 'T [] → unit
//iter2 : ('T1 → 'T2 → unit) → 'T1 [] → 'T2 [] → unit)
//iteri : (int → 'T → unit) → 'T [] → unit
//iteri2 : (int → 'T1 → 'T2 → unit) → 'T1 [] → 'T2 [] → unit
//length : 'T [] → int
//map : ('T → 'U) → 'T [] → 'U []
//map2 : ('T1 → 'T2 → 'U) → 'T1 [] → 'T2 [] → 'U []
//mapi : (int → 'T → 'U) → 'T [] → 'U []
//mapi2 : (int → 'T1 → 'T2 → 'U) → 'T1 [] → 'T2 [] → 'U []
//max : 'T [] → 'T
//maxBy : ('T → 'U) → 'T [] → 'T
//min : ('T [] → 'T
//minBy : ('T → 'U) → 'T [] → 'T
//ofList : 'T list → 'T []
//ofSeq : seq<'T> → 'T []
//partition : ('T → bool) → 'T [] → 'T [] * 'T []
//permute : (int → int) → 'T [] → 'T []
//pick : ('T → 'U option) → 'T [] → 'U
//reduce : ('T → 'T → 'T) → 'T [] → 'T
//reduceBack : ('T → 'T → 'T) → 'T [] → 'T
//rev : 'T [] → 'T []
//scan : ('State → 'T → 'State) → 'State → 'T [] → 'State [])
//scanBack : ('T → 'State → 'State) → 'T [] → 'State → 'State []
//set : 'T [] → int → 'T → unit
//sort : 'T[] → 'T []
//sortBy : ('T → 'Key) → 'T [] → 'T []
//sortInPlace : 'T [] → unit
//sortInPlaceBy : ('T → 'Key) → 'T [] → unit
//sortInPlaceWith : ('T → 'T → int) → 'T [] → unit
//sortWith : ('T → 'T → int) → 'T [] → 'T []
//sub : 'T [] → int → int → 'T []
//sum : 'T [] → ^T
//sumBy : ('T → ^U) → 'T [] → ^U
//toList : 'T [] → 'T list
//toSeq : 'T [] → seq<'T>
//tryFind : ('T → bool) → 'T [] → 'T option
//tryFindIndex : ('T → bool) → 'T [] → int option
//tryPick : ('T → 'U option) → 'T [] → 'U option
//unzip : ('T1 * 'T2) [] → 'T1 [] * 'T2 []
//unzip3 : ('T1 * 'T2 * 'T3) [] → 'T1 [] * 'T2 [] * 'T3 []
//zeroCreate : int → 'T []
//zip : 'T1 [] → 'T2 [] → ('T1 * 'T2) []
//zip3 : 'T1 [] → 'T2 [] → 'T3 [] → ('T1 * 'T2 * 113 'T3) []
    member self.example2() = 
        let arr1 = [|for i in 1..10 -> (double i)|]
        let arr2 = [|for i in 11..20 -> (double i)|]
        let append = Array.append arr1 arr2 
        let average = Array.average arr1 
        let averageBy = Array.averageBy (fun el-> el*el) arr1 
        let arr3:double array  = Array.zeroCreate arr1.Length
        Array.blit arr1 0 arr3 0 
        let choose = Array.choose (fun el -> Some(el)) arr1 
        let collect = Array.collect (fun el -> [|el;el+1.0;el+2.0|]) arr1 
        let concat = Array.concat [arr1; arr2]
        let copy = Array.copy arr1
        let create = Array.create 10 "foo"
        let empty = Array.empty
        let exists = Array.exists (fun el -> el % 2.0 = 0.0) arr1
        let exists2 = Array.exists2 (fun el1 el2 -> (el1+el2) % 2.0 = 0.0) arr1 arr2
        let fill = Array.fill create 0 5 "bar"
        let filter = Array.filter (fun el-> el % 2.0 = 0.0) arr1
        printfn "append = %A" append 
        printfn "average = %A" average 
        printfn "averageBy = %A" averageBy
        printfn "blit = %A" arr3 
        printfn "choose = %A" choose 
        printfn "collect = %A" collect 
        printfn "concat = %A" concat 
        printfn "copy = %A" copy 
        printfn "create = %A" create 
        printfn "empty = %A" empty 
        printfn "exists = %A" exists 
        printfn "exists2 = %A" exists2
        printfn "fill = %A" fill 
        printfn "filter = %A" filter 
        let find = Array.find (fun el-> el % 2.0 = 0.0) arr1 
        let findIndex = Array.findIndex (fun el -> el % 2.0 = 0.0) arr1
        let fold = Array.fold (fun acc el -> acc + el) 0.0 arr1 
        let fold2 = Array.fold2 (fun acc el1 el2 -> acc + el1 + el2) 0.0 arr1 arr2
        let foldBack = Array.foldBack (fun el acc -> acc + el) arr1 0.0 
        let foldBack2 = Array.foldBack2 (fun el1 el2 acc -> el1 + el2 + acc) arr1 arr2 0.0 
        let forall = Array.forall (fun el -> el % 2.0 = 0.0) arr1 
        let forall2 = Array.forall2 (fun el1 el2 -> (el1 + el2) % 2.0 = 0.0) arr1 arr2 
        let get = Array.get arr1 0 
        let init = Array.init 10 (fun i -> i*i*i)
        let isEmpty = Array.isEmpty arr1 
        printfn "find = %A" find 
        printfn "findIndex = %A" findIndex 
        printfn "fold = %A" fold 
        printfn "fold2 = %A" fold2
        printfn "foldBack = %A" foldBack 
        printfn "foldBack2 = %A" foldBack2 
        printfn "forall = %A" forall
        printfn "forall2 = %A" forall2 
        printfn "get = %A" get 
        printfn "init = %A" init
        printfn "isEmpty = %A" isEmpty 
        let length = Array.length arr1 
        let map = Array.map (fun el-> el*el) arr1 
        let map2 = Array.map2 (fun el1 el2 -> (el1+el2)*(el1+el2)) arr1 arr2 
        let mapi = Array.mapi (fun i el -> (Math.Pow(((double i) + el), 2.0))) arr1 
        let mapi2 = Array.mapi2 (fun i el1 el2 -> (Math.Pow(((double i) + el1 + el2),2.0))) arr1 arr2
        let max = Array.max arr1 
        let maxBy = Array.maxBy (fun el-> el*el) arr1 
        let min = Array.min arr1 
        let minBy = Array.minBy (fun el -> el*el) arr1 
        let ofList = Array.ofList [10;20;30;40;50]
        let ofSeq = Array.ofSeq (seq {1..5..50})
        let partition = Array.partition (fun el -> el % 2.0 = 0.0) arr1 
        let permute = Array.permute (fun i -> (i + 3) % arr1.Length) arr1 
        printfn "length = %A" length 
        printfn "map = %A" map 
        printfn "map2 = %A" map2 
        printfn "mapi = %A" mapi
        printfn "mapi2 = %A" mapi2 
        printfn "max = %A" max 
        printfn "maxBy = %A" maxBy 
        printfn "min = %A" min 
        printfn "minBy = %A" minBy 
        printfn "ofList = %A" ofList 
        printfn "ofSeq = %A" ofSeq 
        printfn "partition = %A" partition 
        printfn "permute = %A" permute 
        let pick = Array.pick (fun el -> Some(el)) arr1 
        let reduce = Array.reduce (fun el1 el2 -> el1 + el2) arr1 
        let reduceBack = Array.reduceBack (fun el1 el2 -> el1 + el2) arr1 
        let rev = Array.rev arr1 
        let scan = Array.scan (fun acc el -> acc + el) 0.0 arr1
        let scanBack = Array.scanBack (fun el acc -> el + acc) arr1 0.0
        let copySet = Array.copy arr1 
        Array.set copySet 0 100.0 
        let sort = Array.sort arr1 
        let sortBy = Array.sortBy (fun el -> -el) arr1 
        let sortWith = Array.sortWith (fun el1 el2 -> (int (el1 - el2))) arr1 
        let copySortInPlace = Array.copy arr1 
        Array.sortInPlace copySortInPlace
        let copySortInPlaceBy = Array.copy arr1 
        Array.sortInPlaceBy (fun el-> -el) copySortInPlaceBy 
        let copySortInPlaceWith = Array.copy arr1 
        Array.sortInPlaceWith (fun el1 el2 -> (int (el1 - el2))) arr1 
        printfn "pick = %A" pick 
        printfn "reduce = %A" reduce 
        printfn "reduceBack = %A" reduceBack 
        printfn "rev = %A" rev 
        printfn "scan = %A" scan 
        printfn "scanBack = %A" scanBack 
        printfn "copySet = %A" copySet 
        printfn "sort = %A" sort 
        printfn "sortBy = %A" sortBy 
        printfn "sortWith = %A" sortWith 
        printfn "sortInPlace = %A" copySortInPlace
        printfn "sortInPlaceBy = %A" copySortInPlaceBy
        printfn "sortInPlaceWith = %A" copySortInPlaceWith
        let sub = Array.sub arr1 0 3 
        let sum = Array.sub arr1 
        let sumBy = Array.sumBy (fun el -> el*el) arr1 
        let toList = Array.toList arr1 
        let toSeq = Array.toSeq arr1 
        let tryFind =  Array.tryFind (fun el-> el % 2.0 = 0.0) arr1 
        let tryFindIndex = Array.tryFindIndex (fun el-> el % 2.0 = 0.0) arr1 
        let tryPick = Array.tryPick (fun el -> Some(el)) arr1 
        let zip = Array.zip arr1 arr2 
        let zip3 = Array.zip3 arr1 arr2 [|for i in 21..30 -> (double i)|]
        let unzip = Array.unzip zip 
        let unzip3 = Array.unzip3 zip3
        printfn "sub = %A" sub 
        printfn "sum = %A" sum 
        printfn "sumBy = %A" sumBy
        printfn "toList = %A" toList 
        printfn "toSeq = %A" toSeq 
        match tryFind with 
        |Some v -> printfn "tryFind value = %A" v 
        |None  -> printfn "tryFind value is None" 
        match tryFindIndex with 
        |Some v -> printfn "tryFindIndex value = %A" v
        |None -> printfn "tryFindIndex value is None"
        match tryPick with 
        |Some v -> printfn "tryPick value = %A" v 
        |None -> printfn "tryPick value is None"
        printfn "zip = %A" zip
        printfn "zip3 = %A" zip3
        printfn "unzip = %A" unzip
        printfn "unzip3 = %A" unzip3
        let zeroCreate = Array.zeroCreate 10 
        printfn "zeroCreate = %A" zeroCreate
        printfn "<<iter>>"
        Array.iter (fun el-> printf "%.2f ; " el) arr1 
        printfn "<<iteri>>"
        Array.iteri (fun i el -> printfn "%d = %.2f" i el) arr1 
        printfn "<<iter2>>" 
        Array.iter2 (fun el1 el2 -> printfn "%.2f => %.2f" el1 el2) arr1 arr2
        printfn "<<iteri2>>"
        Array.iteri2 (fun i el1 el2 -> printfn "%d = %.2f => %.2f" i el1 el2) arr1 arr2
        

