open System

let foon n foon1 init =
    let rec foon2 x foon3 init prov =
        if prov = 0 then init
        else 
            let newINIT = 
                if x % prov = 0 then foon3 init prov 
                else init
            let newPROV = prov - 1
            foon2 x foon3 newINIT newPROV
    foon2 n foon1 init n
    
[<EntryPoint>]
let main argv =
    let n = System.Convert.ToInt32(Console.ReadLine())
    foon n (fun x y -> x * y) 1 |> printfn "%A"
    0