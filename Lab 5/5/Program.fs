open System

let rec Prov n =
   if n = 1 || n = 2 then printfn "Ну ты и подлиза"
   else printfn "Задумайся о своём вкусе"

[<EntryPoint>]
let main argv =
    printfn "Какой язык проиграммирования у тебя любимый?"
    printfn "Prolog - 1, F# - 2, C++ - 3, C# - 4, Pascal - 5, Python - 6"
    System.Convert.ToInt32(System.Console.ReadLine()) |> Prov |> System.Console.WriteLine
    0