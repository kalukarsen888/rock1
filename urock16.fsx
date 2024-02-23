#r "nuget: FunSharp.Ru"
#r "nuget: FSharp.Core.Russian, 0.0.2"

open Библиотека
open Фшарп.Ядро
open Библиотека.Цвета
let массив1 = ["Андрей";"Арсений";"Тимоха";"Егор"]
let массив_чисел1 =[1;11;222;3333]
printfn "Перебрать все"
for имя in массив1 do
    printfn "%s" имя

printfn "Перебрать все по порядковому номеру"
for номер = 0 to массив1.Length - 1 do
    let имя = массив1[номер]
    printfn "%d - %s" номер имя

printfn "%s" массив1[2]