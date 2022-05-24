open System


let rec prostoe a b =
    if a = b then a
    else
        if (a > b) then 
            let NEWA = b 
            let NEWB = a-b
            prostoe NEWA NEWB
        else 
            let NEWA = a 
            let NEWB = b-a
            prostoe NEWA NEWB
            

let foon n foon1 init =
    let rec foon2 x foon3 init n = 
        if n < 1 then init
        else
            let newInit = 
                if prostoe x n = 1 then foon3 init n 
                else init
            let newN = n - 1
            foon2 x foon3 newInit newN
    foon2 n foon1 init n

[<EntryPoint>]
let main argv =
    let n = System.Convert.ToInt32(Console.ReadLine())
    foon n (fun x y -> x + y) 0 |> printfn "%A"
    0 