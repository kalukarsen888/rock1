#r "nuget: FunSharp.Ru, 0.0.5"
#r "nuget: FSharp.Core.Russian, 0.0.6"
#r "nuget: Russian.System.Runtime, 0.0.2"
open Библиотека
open Фшарп.Ядро
open Библиотека.Цвета
open Система.ВВ
open System
open Система
напечататьфн "введите количество:"
let кол_во_чисел =  Консоль.ПрочитатьСтроку() |> цел
let mutable максимальное_число = 0
let mutable список = []


for кол_во = 1 to кол_во_чисел do
    напечататьфн "введите число"
    let число =  Консоль.ПрочитатьСтроку() |> цел
    список <- список @ [число]
for элемент in список  do
    if элемент > максимальное_число then
        максимальное_число <- элемент
let удвоить(список) =
    let mutable результат = []
    for элемент in список do
        напечататьф "%A @ [%A * 2] = " результат элемент
        результат <- результат @ [элемент * 2]
        напечататьфн "%A" результат
    результат
let удвоить_элементы(список) =
    let mutable результат = []
    for элемент in список do
        напечататьф "%A @ [%A ; 2 * %A] = " результат элемент элемент
        результат <- результат @ [элемент; 2 * элемент]
        напечататьфн "%A" результат
    результат
let перевернуть (список) =
    let mutable результат = []
    for элемент in список do
        напечататьф "[%d] @ %A = " элемент результат
        результат <- [элемент] @ результат
        напечататьфн "%A" результат
    результат
напечататьфн "%A" список
//напечататьфн "%d" максимальное_число
//напечататьфн "%A" (удвоить список)
//напечататьфн "%A" (перевернуть список)
напечататьфн "%A" (удвоить_элементы список)