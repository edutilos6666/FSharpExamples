module main.ListExample
open System 

type ListExample() = 
    //generate list
    member self.example1() = 
        let list1 = [10; 20 ; 30; 40; 50]
        let list2 = [1 .. 10]
        let list3 = List.init 5 (fun i -> (i , i*i, i*i*i, i*i*i*i))
        let list4 = 1 :: 2 :: 3 :: 4 :: 5 ::[]
        let list5 = ['A'..'Z']
        let list6  = [for i in 1 .. 10 do yield (i*i)]
        let list7 = [for i in 1.. 100 do if i%3 = 0 && i%5 = 0 then yield i]
        let list8 = [for i in 1 ..3 do yield! [i .. i+2]]
        printfn "list1 = %A" list1 
        printfn "list2 = %A" list2 
        printfn "list3 = %A" list3 
        printfn "list4 = %A" list4 
        printfn "list5 = %A" list5 
        printfn "list6 = %A" list6 
        printfn "list7 = %A" list7 
        printfn "list8 = %A" list8 
        printfn ""
        
        
    //list properties 
    member self.example2() = 
        let list1 = [1..10]
        printfn "list1 = %A" list1
        printfn "list1.Head = %d" list1.Head 
        printfn "list1.Tail = %A" list1.Tail
        printfn "list1.Tail.Head = %d" list1.Tail.Head
        printfn "list1.Tail.Tail.Head = %d" list1.Tail.Tail.Head 
        printfn "list1.Tail.Tail.Tail.Tail.Head = %d" list1.Tail.Tail.Tail.Head 
        printfn "list1.IsEmpty = %b" list1.IsEmpty
        printfn "list1.Length = %d" list1.Length
        printfn "list1.Item(0) = %d" (list1.Item(0))
        printfn "list1.Item(1) = %d" (list1.Item(1))
//        printfn "list1.Item(-1) = %d" (list1.Item(-1)) -> throws Exception
        printfn ""    
        

    //List methods 
//append : 'T list → 'T list → 'T list
//average : 'T list → ^T
//averageBy : ('T → ^U) → 'T list → ^U
//choose : ('T → 'U option) → 'T list → 'U list
//collect : ('T → 'U list) → 'T list → 'U list
//concat : seq<'T list> → 'T list
//empty : 'T list
//exists : ('T → bool) → 'T list → bool
//exists2 : ('T1 → 'T2 → bool) → 'T1 list → 'T2 list → bool
//filter : ('T → bool) → 'T list → 'T list
//find : ('T → bool) → 'T list → 'T
//findIndex : ('T → bool) → 'T list → int
//fold : ('State → 'T → 'State) → 'State → 'T list → 'State
//fold2 : ('State → 'T1 → 'T2 → 'State) → 'State → 'T1 list → 'T2 list → 'State
//foldBack : ('T → 'State → 'State) → 'T list → 'State → 'State
//foldBack2 : ('T1 → 'T2 → 'State → 'State) → 'T1 list → 'T2 list → 'State → 'State
//forall : ('T → bool) → 'T list → bool
//forall2 : ('T1 → 'T2 → bool) → 'T1 list → 'T2 list → bool
//head : 'T list → 'T
//init : int → (int → 'T) → 'T list
//isEmpty : 'T list → bool
//iter : ('T → unit) → 'T list → unit
//iter2 : ('T1 → 'T2 → unit) → 'T1 list → 'T2 list → unit
//iteri : (int → 'T → unit) → 'T list → unit
//iteri2 : (int → 'T1 → 'T2 → unit) → 'T1 list → 'T2 list → unit
//length : 'T list → int
//map : ('T → 'U) → 'T list → 'U list
//map2 : ('T1 → 'T2 → 'U) → 'T1 list → 'T2 list → 'U list
//map3 : ('T1 → 'T2 → 'T3 → 'U) → 'T1 list → 'T2 list → 'T3 list → 'U list
//mapi : (int → 'T → 'U) → 'T list → 'U list
//mapi2 : (int → 'T1 → 'T2 → 'U) → 'T1 list → 'T2 list → 'U list
//max : 'T list → 'T
//maxBy : ('T → 'U) → 'T list → 'T
//min : 'T list → 'T
//minBy : ('T → 'U) → 'T list → 'T
//nth : 'T list → int → 'T
//ofArray : 'T [] → 'T list
//ofSeq : seq<'T> → 'T list
//partition : ('T → bool) → 'T list * 'T list
//permute : (int → int) → 'T list → 'T list
//pick : ('T → 'U option) → 'T list → 'U
//reduce : ('T → 'T → 'T) → 'T list → 'T
//reduceBack : ('T → 'T → 'T) → 'T list → 'T
//replicate : (int → 'T → 'T list)
//rev : 'T list → 'T list
//scan : ('State → 'T → 'State) → 'State → 'T list → 'State list
//scanBack : ('T → 'State → 'State) → 'T list → 'State → 'State list
//sort : 'T list → 'T list
//sortBy : ('T → 'Key) → 'T list → 'T list
//sortWith : ('T → 'T → int) → 'T list → 'T list
//sum : ^T list → ^T
//sumBy : ('T → ^U) → 'T list → ^U
//tail : 'T list → 'T list
//toArray : 'T list → 'T []
//toSeq : 'T list → seq<'T>
//tryFind : ('T → bool) → 'T list → 'T option
//tryFindIndex : ('T → bool) → 'T list → int option
//tryPick : ('T → 'U option) → 'T list → 'U option
//unzip : ('T1 * 'T2) list → 'T1 list * 'T2 list
//unzip3 : ('T1 * 'T2 * 'T3) list → 'T1 list * 'T2 list * 'T3 list
//zip : 'T1 list → 'T2 list → ('T1 * 'T2) list
//zip3 : 'T1 list → 'T2 list → 'T3 list → ('T1 * 'T2 * 'T3) list
    member self.example3() = 
        let mutable list1 = [for i in 1..10 do yield (double i)]
        let append = List.append [1..10] [11..20]
        let average = List.average list1 
        let averageBy = List.averageBy (fun el -> el*el) list1
        let choose = List.choose (fun el-> Some(Math.Pow(el, 2.0))) list1 
        let collect = List.collect (fun el -> [el; el+1.0; el+2.0]) list1 
        let concat = List.concat [[1..10]; [11..20]; [21..30]]
        let empty = List.empty 
        let exists = List.exists (fun el -> el%2.0 = 0.0) list1 
        let l1 = [1..10]
        let l2 = [11..20]
        let exist2 = List.exists2 (fun el1 el2 ->  (el1 + el2) % 2 = 0) l1 l2
        let filter = List.filter (fun el -> el % 2 = 0) l1 
        printfn "append = %A" append 
        printfn "average = %A" average 
        printfn "averageBy = %A" averageBy
        printfn "choose = %A" choose 
        printfn "collect = %A" collect
        printfn "concat = %A" concat 
        printfn "empty = %A" empty
        printfn "exists = %A" exists 
        printfn "exists2 = %A" exist2 
        printfn "filter = %A" filter 
        let find = List.find (fun el -> el % 2 =1 ) l1 
        let findIndex = List.findIndex (fun el -> el % 2 <> 0 ) l2 
        let fold = List.fold (fun acc el -> acc+ el) 0 l1 
        let fold2 = List.fold2 (fun acc el1 el2 -> acc + el1 + el2) 0 l1 l2 
        let foldBack = List.foldBack (fun el acc-> acc + el) l1  0 
        let foldBack2 = List.foldBack2 (fun  el1 el2 acc -> acc + el1 + el2)  l1 l2 0
        let forall = List.forall (fun el -> el % 2 = 0) l1 
        let forall2 = List.forall2 (fun el1 el2 -> (el1 + el2) % 2 = 0) l1 l2 
        let head = List.head l1 
        let init = List.init 5 (fun i -> i*i)
        let isEmpty = List.isEmpty l1 
        let length = List.length l1 
        let map = List.map (fun el -> el*el) l1 

        printfn "find = %A" find 
        printfn "findIndex = %A" findIndex
        printfn "fold = %A" fold 
        printfn "fold2 = %A" fold2
        printfn "foldBack = %A" foldBack 
        printfn "foldBack2 = %A" foldBack2 
        printfn "forall = %A" forall
        printfn "forall2 = %A" forall2 
        printfn "head = %A" head 
        printfn "init = %A" init
        printfn "isEmpty = %A" isEmpty 
        printfn "length = %A" length 
        printfn "map = %A" map 

        let map2 = List.map2 (fun el1 el2 -> (el1+el2)*(el1+el2)) l1 l2 
        let l3 = [21..30]
        let map3 = List.map3 (fun el1 el2 el3 -> (el1+el2+el3)*(el1+el2+el3)) l1 l2 l3
        let mapi = List.mapi (fun i el -> (sprintf "%d=>%d" i el)) l1 
        let mapi2 = List.mapi2 (fun i el1 el2 -> (sprintf "%d => %d;%d" i el1 el2)) l1 l2 
        let max = List.max l1 
        let maxBy = List.maxBy (fun el -> el*el) l1 
        let min = List.min l1 
        let minBy = List.minBy (fun el -> el*el) l1
        let nth = List.nth l1 0 
        let item = List.item 0 l1 
        let ofArray = List.ofArray [|1;2;3;4;5;6|]

        printfn "map2 = %A" map2
        printfn "map3 = %A" map3
        printfn "mapi = %A" mapi 
        printfn "mapi2 = %A" mapi2
        printfn "max = %A" max 
        printfn "maxBy = %A" maxBy 
        printfn "min = %A" min 
        printfn "minBy = %A" minBy 
        printfn "nth = %A" nth  //deprecated warning 
        printfn "item = %A" item 
        printfn "ofArray = %A" ofArray

        let ofSeq = List.ofSeq [1;2;3;4;5]
        let partition = List.partition (fun el -> el%2 = 0) l1 
        let permute = List.permute (fun index-> (index+3)%l1.Length) l1 
        let pick = List.pick (fun el -> Some(el*el)) l1 
        let reduce = List.reduce (fun acc el -> acc + el) l1
        let reduceBack = List.reduce (fun acc el-> acc + el) l1 
        let replicate = List.replicate 5 "* "
        let rev = List.rev l1 
        let scan = List.scan (fun acc el -> acc + el) 0 l1 
        let scanBack = List.scanBack (fun el acc -> el + acc) l1 0 
        let sort = List.sort l1 
        let sortBy = List.sortBy (fun el -> el*el) l1 
        let sortWith = List.sortWith (fun el1 el2 -> el1 - el2 ) l1 
        let sum = List.sum l1 
        let sumBy = List.sumBy (fun el-> el*el) l1 
        let tail = List.tail l1 

        printfn "ofSeq = %A" ofSeq
        printfn "partition = %A" partition 
        printfn "permute = %A" permute 
        printfn "pick = %A" pick 
        printfn "reduce = %A" reduce 
        printfn "reduceBack = %A" reduceBack 
        printfn "replicate = %A" replicate 
        printfn "rev = %A" rev 
        printfn "scan = %A" scan 
        printfn "scanBack = %A" scanBack 
        printfn "sort = %A" sort 
        printfn "sortBy = %A" sortBy 
        printfn "sortWith = %A" sortWith 
        printfn "sum = %A" sum 
        printfn "sumBy = %A" sumBy 
        printfn "tail = %A" tail 

        let toArray = List.toArray l1
        let toSeq = List.toSeq l1
        let tryFind = List.tryFind (fun el -> el%2 = 0) l1 
        let tryFindIndex = List.tryFindIndex (fun el -> el%2 = 0) l1
        let tryPick = List.tryPick (fun el-> Some(el)) l1 
        let zip = List.zip l1 l2 
        let zip3 = List.zip3 l1 l2 l3 
        let unzip = List.unzip zip
        let unzip3 = List.unzip3 zip3

        printfn "toArray = %A" toArray
        printfn "toSeq = %A" toSeq
        printfn "tryFind =%A" tryFind 
        printfn "tryFindIndex = %A" tryFindIndex
        printfn "tryPick = %A" tryPick 
        printfn "zip = %A" zip
        printfn "zip3 = %A" zip3
        printfn "unzip = %A" unzip
        printfn "unzip3 = %A" unzip3


        //iter 
        printfn "<<iter>>"
        List.iter (fun el-> printf "%d; " el) l1 
        printfn ""
        printfn "<<iter2>>"
        List.iter2 (fun el1 el2 -> printfn "%d => %d" el1 el2) l1 l2 
        printfn "<<iteri>>"
        List.iteri (fun i el -> printf "%d = %d; " i el) l1
        printfn ""
        printfn "<<iteri2>>"
        List.iteri2 (fun i el1 el2 -> printfn "%d : %d => %d" i el1 el2) l1 l2 

        
        ""           

