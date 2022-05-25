// 1 работа
(*
open System

let rec readList n = 
    if n=0 then []
    else
    let Head = System.Convert.ToInt32(System.Console.ReadLine())
    let Tail = readList (n-1)
    Head::Tail

let readData = 
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    readList n

let rec writeList = function
    | [] -> ()
    | head::tail -> 
        printfn "%O" head
        writeList tail

let task list f=
    let rec rec_task list curlist = 
        match list with
        |[]->curlist
        |h::t->
            let arg1 = h
            let arg2 = if t<>[] then t.Head else 1
            let arg3 = if t<>[] then (if t.Tail<>[] then t.Tail.Head else 1) else 1
            let newCurlist = curlist @ [f arg1 arg2 arg3]
            let newList = if t<>[] then (if t.Tail<>[] then t.Tail.Tail else []) else []//сдвиг
            rec_task newList newCurlist
    rec_task list []


[<EntryPoint>]
let main argv =
    let list = readData
    Console.WriteLine("ans:")
    writeList (task list (fun x y z->x+y+z))
    0 // return an integer exit code
*)
// 3 работа
(*
open System

let rec readList n = 
    if n=0 then []
    else
    let Head = System.Convert.ToInt32(System.Console.ReadLine())
    let Tail = readList (n-1)
    Head::Tail

let readData = 
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    readList n

let rec writeList = function
    | [] -> ()
    | head::tail -> 
        printfn "%O" head
        writeList tail

let findMax list =
    let rec rec_findMax list cur =
        match list with
        |[]->cur
        |h::t->
            let newCur = if (h>cur) then h else cur
            let newList = if t<>[] then t else []
            rec_findMax newList newCur
    rec_findMax list list.Head

let item list idx =
    let rec rec_item list idx count =
        match list with
        |[]->0
        |h::t->
            if idx=count then h
            else
                rec_item t idx (count+1)
    rec_item list idx 0

[<EntryPoint>]
let main argv =
    let list = readData
    Console.WriteLine("Ввод индекса:")
    let idx = int (Console.ReadLine())
    
    if (item list idx = findMax list) then Console.WriteLine("является")
    else Console.WriteLine("не является")

    0 // return an integer exit code
*)
// 4 работа
(*
open System

let rec readList n = 
    if n=0 then []
    else
    let Head = System.Convert.ToInt32(System.Console.ReadLine())
    let Tail = readList (n-1)
    Head::Tail

let readData = 
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    readList n

let rec writeList = function
    | [] -> ()
    | head::tail -> 
        printfn "%O" head
        writeList tail

   //возвращает значение по индексу
let item list idx =
    let rec rec_item list idx count =
        match list with
        |[]->0
        |h::t->
            if idx=count then h
            else
                rec_item t idx (count+1)
    rec_item list idx 0

    //удалить элемент
let DelElem list n =
    let rec DelElem (list:'a list) n (curlist:'a list) curIdx  =
        if n = curIdx then curlist @ list.Tail
        else
            let newCurlist = curlist @ [list.Head]
            DelElem list.Tail n newCurlist (curIdx+1)
    DelElem list n [] 0

    //находит индекс первого значения равного заданному
let findFirstIndex list x =
    let rec recFindFirstIndex list x count =
        match list with
        |[]-> -1
        |h::t->
            if h=x then count 
            else
                recFindFirstIndex t x (count+1)
    recFindFirstIndex list x 0


let findMax list =
    let rec rec_findMax list cur =
        match list with
        |[]->cur
        |h::t->
            let newCur = if (h>cur) then h else cur
            let newList = if t<>[] then t else []
            rec_findMax newList newCur
    rec_findMax list list.Head

let findMin list =
    let rec rec_findMax list cur =
        match list with
        |[]->cur
        |h::t->
            let newCur = if (h<cur) then h else cur
            let newList = if t<>[] then t else []
            rec_findMax newList newCur
    rec_findMax list list.Head

    //имеет лист значение?
let IsHave list x =
    let rec recIsHave list x =
        match list with
        |[]-> false
        |h::t->
            if (h=x) then true else recIsHave t x
    recIsHave list x

    //сортровка + реверз
let revSort list =
    let rec recRevSort list curlist =
        match list with
        |[]->curlist
        |_->
            let max = findMax list
            let idxMax = findFirstIndex list max
            let newList = DelElem list idxMax
            let newCurlist = curlist @ [max]
            recRevSort newList newCurlist
    recRevSort list []

    //прохожу все числа от минимума к максимуму
let rec proc list min max curEl curList =
    if curEl = (max+1) then curList
    else //элемент существует в списке но еще его индекс не записан
        if (IsHave list curEl = true && IsHave curList (findFirstIndex list curEl) = false) then 
            let idxEl = findFirstIndex list curEl
            let newCurlist = [idxEl] @ curList
            
            proc list min max curEl newCurlist
        else
            proc list min max (curEl+1) curList


let proga list =
    proc list (findMin list) (findMax list) (findMin list) []
    

[<EntryPoint>]
let main argv =
    let list = readData
    let ans = proga list
    writeList ans


    0 // return an integer exit code

*)
// 25 работа
(*
open System

let rec readList n = 
    if n=0 then []
    else
    let Head = System.Convert.ToInt32(System.Console.ReadLine())
    let Tail = readList (n-1)
    Head::Tail

let readData = 
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    readList n

let rec writeList = function
    | [] -> ()
    | head::tail -> 
        printfn "%O" head
        writeList tail

let findMax list =
    let rec rec_findMax list cur =
        match list with
        |[]->cur
        |h::t->
            let newCur = if (h>cur) then h else cur
            let newList = if t<>[] then t else []
            rec_findMax newList newCur
    rec_findMax list list.Head

let item list idx =
    let rec rec_item list idx count =
        match list with
        |[]->0
        |h::t->
            if idx=count then h
            else
                rec_item t idx (count+1)
    rec_item list idx 0

    //вовзращает новый список со значениями интервала
let intervalList list a b =
    let rec recIntervalList list a b curlist =
        match list with
        |[]->curlist
        |h::t->
            let newCurlist = if (h>=a&&h<=b) then curlist @ [h] else curlist
            let newList = if t<>[] then t else []
            recIntervalList newList a b newCurlist
    recIntervalList list a b []


[<EntryPoint>]
let main argv =
    let list = readData
    Console.WriteLine("ввод интервала")
    let a = int (Console.ReadLine())
    let b = int (Console.ReadLine())

    let ans = intervalList list a b
    Console.WriteLine(findMax ans)
    

    0 // return an integer exit code

*)
// 28 работа
(*
open System

let rec readList n = 
    if n=0 then []
    else
    let Head = System.Convert.ToInt32(System.Console.ReadLine())
    let Tail = readList (n-1)
    Head::Tail

let readData = 
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    readList n

let rec writeList = function
    | [] -> ()
    | head::tail -> 
        printfn "%O" head
        writeList tail

        //найти макс в списке
let findMax list =
    let rec rec_findMax list cur =
        match list with
        |[]->cur
        |h::t->
            let newCur = if (h>cur) then h else cur
            let newList = if t<>[] then t else []
            rec_findMax newList newCur
    rec_findMax list list.Head

    //достать значение по индексу
let item list idx =
    let rec rec_item list idx count =
        match list with
        |[]->0
        |h::t->
            if idx=count then h
            else
                rec_item t idx (count+1)
    rec_item list idx 0

    //находит индекс первого значения равного заданному
let findFirstIndex list x =
    let rec recFindFirstIndex list x count =
        match list with
        |[]->0
        |h::t->
            if h=x then count 
            else
                recFindFirstIndex t x (count+1)
    recFindFirstIndex list x 0

    //перевернуть список
let revList list =
    let rec recRevList list curlist =
        match list with 
        |[]->curlist
        |h::t->
            let newCurlist = [h] @ curlist
            let newList = if t<> [] then t else []
            recRevList newList newCurlist
    recRevList list []

    //вовзращает новый список со значениями интервала
let intervalList list a b =
    let rec recIntervalList list a b curlist =
        match list with
        |[]->curlist
        |h::t->
            let newCurlist = if (h>=a&&h<=b) then curlist @ [h] else curlist
            let newList = if t<>[] then t else []
            recIntervalList newList a b newCurlist
    recIntervalList list a b []

    //список со значениями между заданными индексами
let intervalIndexList list a b =
    let rec recIntervaIndexlList list a b curlist count=
        match list with
        |[]->curlist
        |h::t->
            let newCurlist = if (count>a && count<b) then curlist @ [h] else curlist
            recIntervaIndexlList t a b newCurlist (count+1)
    recIntervaIndexlList list a b [] 0

[<EntryPoint>]
let main argv =
    let list = readData

    let idxMax1 = list|>findMax|>item list

    let idxMax2 = (list.Length-1) - (list|>revList|>findMax|>item (revList list)) 
    Console.WriteLine("ответ")

    let ans = intervalIndexList list idxMax1 idxMax2
    writeList ans    

    0 // return an integer exit code

*)
// 52 работа
(*
// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp
// See the 'F# Tutorial' project for more help.
open System

let rec writeList = function
    | [] -> ()
    | head::tail -> 
        printfn "%O" head
        writeList tail

//простое число?
let isProst x =
    let rec rec_isProst x count=
        if count=x then true 
        else
            if x%count=0 then false else rec_isProst x (count+1)
    rec_isProst x 2

//сколько раз заданное простое число явл делителем
let rec addDif x n list=
    if x%n=0 then 
        let newList=list@[n]
        addDif (x/n) n newList
    else
        let newList=list@[]
        newList
                
let task x =
    let rec rec_task x count curlist=
        if count=x then curlist else
            let newCurlist = if (x%count=0)&&(isProst count) then (addDif x count curlist) else curlist
            rec_task x (count+1) newCurlist
    rec_task x 2 []

[<EntryPoint>]
let main argv =
    let x = int(Console.ReadLine())
    let list=task x
    writeList list
    0 // return an integer exit code

*)
