open System


let rec prostoe a b =
    if a = b then a
    else
        if (a > b) then 
            let NEWA = b 
            let NEWB = a - b
            prostoe NEWA NEWB
        else 
            let NEWA = a 
            let NEWB = b - a
            prostoe NEWA NEWB

let rec nod n m = // 56 32 = 8   24 32  24 8  0 8
    if n = 0 || m = 0 then n + m 
    else
        let newn =
            if n>m then n % m 
            else n
        let newm =
            if n<=m then m % n 
            else m
        nod newn newm

let Foon n m =
    if n = m then n
    else nod n m
    

let foon n foon1 init =
    let rec foon2 x foon3 init n = 
        if n < 1 then init
        else
            let newInit = 
                if prostoe x n = 1 then foon3 init 
                else init
            let newN = n - 1
            foon2 x foon3 newInit newN
    foon2 n foon1 init n

[<EntryPoint>]
let main argv =
    let n = System.Convert.ToInt32(Console.ReadLine())
    let m = foon n (fun z -> z + 1) 0 // eiler
    Console.WriteLine(m)
    Foon n m |> printfn "%A" // nod
    0 