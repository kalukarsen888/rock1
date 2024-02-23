#r "nuget: FunSharp.Ru, 0.0.5"
#r "nuget: FSharp.Core.Russian, 0.0.6"
#r "nuget: Russian.System.Runtime, 0.0.2"
open Библиотека
open Фшарп.Ядро
open Библиотека.Цвета
open Система.ВВ
open System
open Система
ГрафическоеОкно.ЦветПера <-Цвета.Красный
ГрафическоеОкно.ЦветКисти <-Цвета.Зеленый
ГрафическоеОкно.ЦветФона <-Цвета.Синий
ГрафическоеОкно.РазмерШрифта <- 70
for число = 1 to 100 do 
    if число % 15 = 0 then
        printfn "FizzBuzz"
    elif число % 5 = 0 then 
        напечататьфн "Buzz"
    elif число % 3 = 0 then 
        напечататьфн "Fizz"
    else 
        напечататьфн "%d" число