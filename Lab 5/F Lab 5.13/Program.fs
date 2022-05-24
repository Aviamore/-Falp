open System

let BOOdiv value = (value / 10)
let BOOprochent value = (value % 10)

let rec DigitalSum value proiz =
    let div = BOOdiv value
    let prochent = BOOprochent value 
    let sum = proiz * prochent
    if div = 0 then sum
    else DigitalSum div sum
        

[<EntryPoint>]
let main argv =
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    DigitalSum n 1 |> printfn "%A" 
    0