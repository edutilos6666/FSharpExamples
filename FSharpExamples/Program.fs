module main.Program 


let testModule1() = 
    let x1:int = 10 
    let x2:int = 3 
    let add = Arithmetic.add x1 x2 
    let sub = Arithmetic.sub x1 x2
    let mult = Arithmetic.mult x1 x2 
    let div = Arithmetic.div x1 x2 
    printfn "<<Arithmetic Resulst>>" 
    printfn "x1 = %d , x2 = %d " x1 x2 
    printfn "x1 + x2 = %d" add
    printfn "x1 - x2 = %d" sub 
    printfn "x1 * x2 = %d" mult 
    printfn "x1 / x2 = %d" div 


open Arithmetic
let testModule2() = 

    let x1 = 10 
    let x2 = 3 
    let res_add = add x1 x2 
    let res_sub = sub x1 x2 
    let res_mult = mult x1 x2 
    let res_div = div x1 x2 
    printfn "<<Arithmetic Operators 2>>"
    printfn "x1 = %d , x2 = %d" x1 x2 
    printfn "x1 + x2 = %d" res_add 
    printfn "x1 - x2 = %d" res_sub 
    printfn "x1 * x2 = %d" res_mult 
    printfn "x1 / x2 = %d" res_div
    let w1 = new Worker(1L , "foo", 10, 100.0, true) 
    printfn "w1 = %s" (w1.ToString())
    w1.Id <- 2L 
    w1.Name <- "new foo"
    w1.Age <- 20 
    printfn "w1 = %s" (w1.ToString()) 



module module1 = 
   let name = "foo" 

module module2 = 
   let name = "bar"



let test_DataTypeExample() = 
//     DataTypeExample.example1()
       DataTypeExample.example2()


let test_OperatorsExample() = 
       let runner = new OperatorsExample.OperatorsExample()
//       runner.testArithmeticOps()
//       runner.testComparisonOps()
//       runner.testLogicalOperators()
       runner.testBitwiseOps()



let test_DecisionMakingExample() = 
      let runner = new DecisionMakingExample.DecisionMakingExample()
      runner.testIf()

let test_LoopExample() = 
      let runner = new LoopExample.LoopExample()
//      runner.example1()
//      runner.example2()
      runner.example3()

let test_FunctionExample() = 
      let runner = new FunctionExample.FunctionExample()
//      runner.example1()
//      runner.example2()
//      runner.example3()
//      runner.example4()
      runner.example5()


let test_StringExample() = 
     let runner = new StringExample.StringExample() 
//     runner.example1()
     runner.example2()

let test_OptionExample() = 
     let runner = new OptionExample.OptionExample()
     runner.example1()


let test_TupleExample() = 
     let runner = new TupleExample.TupleExample()
     runner.example1()

let test_RecordExample() = 
     let runner = new RecordExample.RecordExample()
//     runner.example1()
     runner.example2()

let test_ListExample() = 
     let runner = new ListExample.ListExample()
//     runner.example1()
//     runner.example2()
     runner.example3()


let test_SequenceExample() = 
     let runner = new SequenceExample.SequenceExample()
//     runner.example1()
     runner.example2()



let test_SetExample() = 
    let runner = new SetExample.SetExample()
//    runner.example1()
    runner.example2()

let test_MapExample() = 
    let runner = new MapExample.MapExample()
//    runner.example1()
    runner.example2()


let test_DiscriminatedUnionExample() = 
    let runner = new DiscriminatedUnionExample.DiscriminatedUnionExample()
    runner.example1()


let test_ArrayExample() = 
    let runner = new ArrayExample.ArrayExample()
//    runner.example1()
    runner.example2()

let test_MutableListExample() = 
    let runner = new MutableListExample.MutableListExample()
//    runner.example1()
    runner.example2()


let test_MutableDictionaryExample() = 
    let runner = new MutableDictionaryExample.MutableDictionaryExample()
//    runner.example1()
    runner.example2()


let test_FileIOExample() = 
    let runner = new FileIOExample.FileIOExample()
//    runner.example1()
//    runner.example2()
//    runner.example3()
//    runner.example4()
//    runner.example5()
    runner.example6()

let test_GenericsExample() = 
    let runner = new GenericsExample.GenericsExample()
//    runner.example1()
    runner.example2()


let test_DelegateExample() = 
    let runner = new DelegateExample.DelegateExample()
//    runner.example1()
//    runner.example2()
    runner.example3()

let test_EnumerationExample() = 
    let runner = new EnumerationExample.EnumerationExample()
    runner.example1()


let test_PatternMatchingExample() =
    let runner = new PatternMatchingExample.PatternMatchingExample()
//    runner.example1()
//    runner.example2()
//    runner.example3()
    runner.example4()


let test_ExceptionHandlingExample() = 
    let runner = new ExceptionHandlingExample.ExceptionHandlingExample()
    runner.example1()


let test_ClassExample() = 
    let runner = new ClassExample.ClassExample()
//    runner.example1()
    runner.example2()

let test_InheritanceExample() = 
    let runner = new InheritanceExample.InheritanceExample()
    runner.example1()


let test_InterfaceExample() = 
    let runner = new InterfaceExample.InterfaceExample()
    runner.example1()


let test_OperatorOverloadingExample() = 
    let runner = new OperatorOverloadingExample.OperatorOverloadingExample()
    runner.example1()

let test_EventExample() = 
    let runner = new EventExample.EventExample()
    runner.example1()


let test_StructExample() = 
    let runner = new StructExample.StructExample()
    runner.example1()


let test_ComplexNumber() = 
    let cn1 = new ComplexNumber.ComplexNumber(3.0, 3.0) 
    let cn2 = new ComplexNumber.ComplexNumber(2.0, 2.0) 
    let cnAdd = cn1 + cn2 
    let cnSub = cn1 - cn2 
    let cnMul = cn1 * cn2 
    let cnDiv = cn1 / cn2 
    printfn "<<ComplexNumber Example>>"
    printfn "cn1 = %A" cn1 
    printfn "cn2 = %A" cn2 
    printfn "cn1 + cn2 = %A" cnAdd 
    printfn "cn1 - cn2 = %A" cnSub
    printfn "cn1 * cn2 = %A" cnMul 
    printfn "cn1 / cn2 = %A" cnDiv 
    printfn ""

[<EntryPoint>]
let main argv = 
//    testModule1()
//    printfn ""
//    testModule2()
//    printfn "module1.name = %s" (module1.name)
//    printfn "module2.name = %s" module2.name 
//    test_DataTypeExample()
//    test_OperatorsExample()
//    test_DecisionMakingExample()
//    test_LoopExample()
//    test_FunctionExample()
//    test_StringExample()
//    test_OptionExample()
//    test_TupleExample()
//    test_RecordExample()
//    test_ListExample()
//    test_SequenceExample()
//    test_SetExample()
//    test_MapExample()
//    test_DiscriminatedUnionExample()
//    test_ArrayExample()
//    test_MutableListExample()
//    test_MutableDictionaryExample()
//    test_FileIOExample()
//    test_GenericsExample()
//    test_DelegateExample()
//    test_EnumerationExample()
//    test_PatternMatchingExample()
//    test_ExceptionHandlingExample()
//    test_ClassExample()
//    test_InheritanceExample()
//    test_InterfaceExample()
//    test_OperatorOverloadingExample()
//    test_EventExample()
//    test_StructExample()
    test_ComplexNumber()
    0
   