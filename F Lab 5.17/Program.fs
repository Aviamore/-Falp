open System

let rec nod n m =
    if n = 0 || m = 0 then n + m 
    else
        let newn = 
            if n > m then n % m 
            else n
        let newm = 
            if n <= m then m % n 
            else m
        nod newn newm
    

let delit n foon foon1 init =
    let rec foon2 x foon3 init n = 
        if n = 0 then init
        else
            let newInit = 
                if x % n = 0 && foon n then foon3 init n
                else init
            let newN = n - 1
            foon2 x foon3 newInit newN
    foon2 n foon1 init n

let vzaimo n foon foon1 init =
    let rec foon2 x foon3 init n = 
        if n < 1 then init
        else
            let newInit = 
                if nod x n = 1 && foon n then foon3 init n
                else init
            let newN = n - 1
            foon2 x foon3 newInit newN
    foon2 n foon1 init n

[<EntryPoint>]
let main argv =
    let n = System.Convert.ToInt32(Console.ReadLine())
    delit n (fun x -> x > 5) (fun x y -> x + y) 0 |> printfn "%A" 
    vzaimo n (fun x -> x % 2 = 0) (fun x y -> x + y) 0 |> printfn "%A" 
    0 