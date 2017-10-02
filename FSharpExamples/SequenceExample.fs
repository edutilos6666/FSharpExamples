module main.SequenceExample

type SequenceExample() = 
     //basics 
    member self.example1() = 
        let s1 = seq { 1 .. 10}
        let s2 = seq {1.. 5 ..50 }
        let s3 = seq {50 .. -5 .. 1}
        let s4 = seq { for a in 1.. 10 do yield a, a*a , a*a*a, a*a*a*a}
        let myFilter n = 
            n % 3 = 0 && n  % 5 = 0  
        let s5 = seq {for i in 1..100 do  if myFilter i then yield i } 
        printfn "s1 = %A" s1
        printfn "s2 = %A" s2
        printfn "s3 = %A" s3
        printfn "s4 = %A" s4
        printfn "s5 = %A" s5



//append : seq<'T> → seq<'T> → seq<'T>
//average : seq<^T> → ^T
//averageBy : ('T → ^U) → seq<'T> → ^U
//cache : seq<'T> → seq<'T>
//cast : IEnumerable → seq<'T>
//choose : ('T → 'U option) → seq<'T> → seq<'U>
//collect : ('T → 'Collection) → seq<'T> → seq<'U>
//compareWith : ('T → 'T → int) → seq<'T> → seq<'T> → int
//concat : seq<'Collection> → seq<'T>
//countBy : ('T → 'Key) → seq<'T> → seq<'Key * int>
//delay : (unit → seq<'T>) → seq<'T>
//distinct : seq<'T> → seq<'T>
//distinctBy : ('T → 'Key) → seq<'T> → seq<'T>
//empty : seq<'T>
//exactlyOne : seq<'T> → 'T
//exists : ('T → bool) → seq<'T> → bool
//exists2 : ('T1 → 'T2 → bool) → seq<'T1> → seq<'T2> → bool
//filter : ('T → bool) → seq<'T> → seq<'T>
//find : ('T → bool) → seq<'T> → 'T
//findIndex : ('T → bool) → seq<'T> → int
//fold : ('State → 'T → 'State) → 'State → seq<'T> → 'State
//forall : ('T → bool) → seq<'T> → bool
//forall2 : ('T1 → 'T2 → bool) → seq<'T1> → seq<'T2> → bool
//groupBy : ('T → 'Key) → seq<'T> → seq<'Key * seq<'T>>
//head : seq<'T> → 'T
//init : int → (int → 'T) → seq<'T>
//initInfinite : (int → 'T) → seq<'T>
//isEmpty : seq<'T> → bool
//iter : ('T → unit) → seq<'T> → unit
//iter2 : ('T1 → 'T2 → unit) → seq<'T1> → seq<'T2> → unit
//iteri : (int → 'T → unit) → seq<'T> → unit
//last : seq<'T> → 'T
//length : seq<'T> → int
//map : ('T → 'U) → seq<'T> → seq<'U>
//map2 : ('T1 → 'T2 → 'U) → seq<'T1> → seq<'T2> → seq<'U>
//mapi : (int → 'T → 'U) → seq<'T> → seq<'U>
//max : seq<'T> → 'T
//maxBy : ('T → 'U) → seq<'T> → 'T
//min : seq<'T> → 'T
//minBy : ('T → 'U) → seq<'T> → 'T
//nth : int → seq<'T> → 'T
//ofArray : 'T array → seq<'T>
//ofList : 'T list → seq<'T>
//pairwise : seq<'T> → seq<'T * 'T>
//pick : ('T → 'U option) → seq<'T> → 'U
//readonly : seq<'T> → seq<'T>
//reduce : ('T → 'T → 'T) → seq<'T> → 'T
//scan : ('State → 'T → 'State) → 'State → seq<'T> → seq<'State>
//singleton : 'T → seq<'T>
//skip : int → seq<'T> → seq<'T>
//skipWhile : ('T → bool) → seq<'T> → seq<'T>
//sort : seq<'T> → seq<'T>
//sortBy : ('T → 'Key) → seq<'T> → seq<'T>
//sum : seq<^T> → ^T
//sumBy
//take : int → seq<'T> → seq<'T>
//takeWhile : ('T → bool) → seq<'T> → seq<'T>
//toArray : seq<'T> → 'T[]
//toList : seq<'T> → 'T list
//truncate : int → seq<'T> → seq<'T>
//tryFind : ('T → bool) → seq<'T> → 'T option
//tryFindIndex : ('T → bool) → seq<'T> → int option
//tryPick : ('T → 'U option) → seq<'T> → 'U option
//unfold : ('State → 'T * 'State option) → 'State → seq<'T>
//where : ('T → bool) → seq<'T> → seq<'T>
//windowed : int → seq<'T> → seq<'T []>
//zip : seq<'T1> → seq<'T2> → seq<'T1 * 'T2>
//zip3 : seq<'T1> → seq<'T2> → seq<'T3> → seq<'T1 * 'T2 * 'T3>
    //sequence methods 
    member self.example2() = 
        let s1 = seq {for i in 1..10 do yield (double i) }
        let s2 = seq{for i in 11..20 do yield (double i)}
        let append = Seq.append s1 s2 
        let average = Seq.average s1 
        let averageBy = Seq.averageBy (fun el -> el**2.0) s1 
        let cache = Seq.cache s1 
        let cast = Seq.cast [1..10]
        let choose = Seq.choose (fun el -> Some(el)) s1 
        let collect = Seq.collect (fun el -> [el; el+1.0; el+2.0;el+3.0]) s1 
        let compareWith = Seq.compareWith (fun el1 el2 -> (int (el1 - el2))) s1 s2 
        let concat = Seq.concat [[1..10]; [11..20]; [21..30]]
        let countBy = Seq.countBy (fun el-> el**2.0) s1 
        let delay = Seq.delay (fun ()-> seq{1..10})
        let distinct = Seq.distinct s1
        let distinctBy = Seq.distinctBy (fun el-> el**2.0) s1 
        let empty = Seq.empty
        let exactlyOne = Seq.exactlyOne (Seq.singleton 10  )
        printfn "append = %A" append 
        printfn "average = %A" average 
        printfn "averageBy = %A" averageBy
        printfn "cache = %A" cache 
        printfn "cast = %A" cast 
        printfn "choose = %A" choose 
        printfn "collect = %A" collect 
        printfn "compareWith = %A" compareWith 
        printfn "concat = %A" concat 
        printfn "countBy = %A" countBy 
        printfn "delay = %A" delay 
        printfn "distinct = %A" distinct
        printfn "distinctBy = %A" distinctBy 
        printfn "empty = %A" empty 
        printfn "exactlyOne = %A" exactlyOne
        let exists = Seq.exists (fun el -> el % 2.0 = 0.0) s1 
        let exists2 = Seq.exists2 (fun el1 el2 -> (el1+el2)%2.0 =0.0) s1 s2 
        let filter = Seq.filter (fun el-> el % 2.0 = 0.0) s1
        let find = Seq.find (fun el -> el % 2.0 = 0.0) s1 
        let findIndex = Seq.findIndex (fun el-> el % 2.0 = 0.0) s1 
        let fold = Seq.fold (fun acc el -> acc + el) 0.0 s1 
        let forall = Seq.forall (fun el -> el % 2.0 = 0.0) s1 
        let forall2 = Seq.forall2 (fun el1 el2 -> (el1 + el2) % 2.0 = 0.0) s1 s2
        let groupBy = Seq.groupBy (fun el-> el**2.0) s1 
        let head = Seq.head s1 
        let init = Seq.init 10 (fun i -> i*i)
        let initInfinite = Seq.initInfinite (fun i -> i*i)
        let last = Seq.last s1
        let length = Seq.length s1 
        let map = Seq.map (fun el -> el**2.0) s1 
        printfn "exists = %A" exists 
        printfn "exists2 = %A" exists2 
        printfn "filter = %A" filter 
        printfn "find = %A" find 
        printfn "findIndex = %A" findIndex 
        printfn "fold = %A" fold 
        printfn "forall = %A" forall 
        printfn "forall2 = %A" forall2 
        printfn "groupBy = %A" groupBy 
        printfn "head = %A" head 
        printfn "init = %A" init 
        printfn "initInfinite = %A" initInfinite 
        printfn "last = %A" last 
        printfn "length = %A" length 
        printfn "map = %A" map 
        let map2 = Seq.map2 (fun el1 el2 -> el1 + el2) s1 s2 
        let mapi = Seq.mapi (fun i el -> (double i) + el) s1 
        let max = Seq.max s1
        let maxBy = Seq.maxBy (fun el -> el**2.0) s1
        let min = Seq.min s1 
        let minBy = Seq.minBy (fun el -> el**2.0) s1 
        let nth = Seq.nth 0 s1 
        let item = Seq.item 0 s1 
        let ofArray = Seq.ofArray [|10;20;30;40;50|]
        let ofList = Seq.ofList [10..20]
        let pairwise = Seq.pairwise s1 
        let pick = Seq.pick (fun el -> Some(el)) s1 
        let readonly = Seq.readonly s1 
        let reduce = Seq.reduce (fun acc el -> acc + el) s1 
        let scan = Seq.scan (fun acc el ->acc + el) 0.0 s1 
        let singleton = Seq.singleton 10 
        let skip = Seq.skip 2 s1 
        let skipWhile = Seq.skipWhile (fun el -> el%2.0 = 0.0) s1 
        let sort = Seq.sort s1
        let sortBy = Seq.sortBy (fun el -> el**2.0) s1 
        let sum = Seq.sum  s1 
        let sumBy = Seq.sumBy (fun el -> el**2.0) s1 
        printfn "map2 = %A" map2 
        printfn "mapi = %A" mapi
        printfn "max = %A" max 
        printfn "maxBy = %A" maxBy 
        printfn "min = %A" min 
        printfn "minBy = %A" minBy
        printfn "nth = %A" nth 
        printfn "item = %A" item 
        printfn "ofArray = %A" ofArray 
        printfn "ofList = %A" ofList 
        printfn "pairwise = %A" pairwise 
        printfn "pick = %A" pick 
        printfn "readonly = %A" readonly 
        printfn "reduce = %A" reduce 
        printfn "scan = %A" scan 
        printfn "singleton = %A" singleton 
        printfn "skip = %A" skip 
        printfn "skipWhile = %A" skipWhile
        printfn "sort = %A" sort 
        printfn "sortBy = %A" sortBy 
        printfn "sum = %A" sum 
        printfn "sumBy = %A" sumBy
        let take = Seq.take 3 s1
        let takeWhile = Seq.takeWhile (fun el -> el % 2.0 = 0.0) s1 
        let toArray = Seq.toArray s1 
        let toList = Seq.toList s1
        let truncate = Seq.truncate 3
        let tryFind = Seq.tryFind (fun el -> el % 2.0 = 0.0) s1 
        let tryFindIndex = Seq.tryFindIndex (fun el -> el % 2.0 = 0.0) s1 
        let tryPick = Seq.tryPick (fun el -> Some(el)) s1 
        let unfold = Seq.unfold (fun state -> if (state < 10) then  (Some(state, state+1)) else None) 0
        let where = Seq.where (fun el -> el % 2.0 = 0.0) s1 
        let windowed = Seq.windowed 5 s1
        let zip = Seq.zip s1 s2 
        let s3 = seq {for i in 1..10 do yield (double i)}
        let zip3 = Seq.zip3 s1 s2 s3 
        printfn "take = %A" take
        printfn "takeWhile = %A" takeWhile 
        printfn "toArray = %A" toArray
        printfn "toList = %A" toList 
        printfn "truncate = %A" truncate 
        printfn "tryFind = %A" tryFind 
        printfn "tryFindIndex = %A" tryFindIndex 
        printfn "tryPick = %A" tryPick 
        printfn "unfold = %A" unfold
        printfn "where = %A" where 
        printfn "windowed = %A" windowed 
        printfn "zip = %A" zip
        printfn "zip3 = %A" zip3 
        printfn "<<iter>>" 
        Seq.iter (fun el -> printf "%.2f ; " el) s1 
        printfn ""
        printfn "<<iter2>>" 
        Seq.iter2 (fun el1 el2 -> printfn "%.2f => %.2f" el1 el2) s1 s2 
        printfn "<<iteri>>"
        Seq.iteri(fun i el -> printfn "%d  = %.2f" i el) s1 
        ""
        

