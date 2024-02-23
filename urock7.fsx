#r "nuget: FunSharp.Ru, 0.0.3"

open Библиотека

let вертикальная_линия количество начальная_позиция_х начальная_позиция_у цвет =
    for кадр = 0 to количество - 1 do
        ГрафическоеОкно.ЦветКисти <- цвет
        let мяч = Фигуры.ДобавитьЭллипс(10,10)
        let шаг_х = 10
        let шаг_у = 20

        let x = начальная_позиция_х 
        let y = начальная_позиция_у + кадр * шаг_у
        Фигуры.Переместить (мяч, x, y)
        //Программа.Задержка 1_000

let горизонтальные_линии количество начальная_позиция_х (начальная_позиция_у: int) цвет =
    for кадр2 = 0 to количество - 1 do
        ГрафическоеОкно.ЦветКисти <- цвет
        let мяч = Фигуры.ДобавитьЭллипс(10,10)
        let шаг_х = 20
      
        let шаг_у = 20

        let x = начальная_позиция_х + кадр2 * шаг_х
        let y = начальная_позиция_у 
        Фигуры.Переместить (мяч, x, y)
        //Программа.Задержка 1_000

let квадрат начальная_позиция_х начальная_позиция_y цвет =
    вертикальная_линия 5 начальная_позиция_х начальная_позиция_y цвет
    горизонтальные_линии 4 (начальная_позиция_х + 20) начальная_позиция_y цвет
    вертикальная_линия 4 (начальная_позиция_х + 80) (начальная_позиция_y + 20) цвет
    горизонтальные_линии 3 (начальная_позиция_х + 20) (начальная_позиция_y + 80) цвет

let возраст = 20
// =
// <> 
// <
// <= 
// > 
// >=
//if not (возраст >= 20) then
if возраст < 20 then
    printfn "Добрый день молодой человек!"
else
    printfn "Добрый день!"
 
if not (возраст >= 20) then
    printfn "Добрый день!"
else
    printfn "Добрый день молодой человек!"

 
if возраст % 2 = 0 then
    квадрат 100 100 Цвета.Зеленый
    printfn "Четный возраст!"
else
    квадрат 100 100 Цвета.Красный
    ГрафическоеОкно.РазмерШрифта <- 40
    let текст = Фигуры.ДобавитьТекст "НЕЧЕТНЫЙ ВОЗРАСТ"
    Фигуры.Переместить (текст, 200, 200)
    printfn "Нечетный возраст!"

(*

если возраст < 20 тогда
    printfn "Добрый день молодой человек!"
иначе
    printfn "Добрый день!"

если не (возраст >= 20) тогда
    printfn "Добрый день!"
иначе
    printfn "Добрый день молодой человек!"

*)
Программа.Задержка 2000

// Сделать функцию которая будет принимать возраст, и печатать разные привествия если возраст старше 15
// Вызвать функцию для возрастов 11, 15, 22, 35
// Сделать функию которая напечатает делится ли число на 10. Если число делится на 10, то пусть печатает "делится", если не делится, пусть печатает "не делится"
// вызвать функцию для 5, 19, 20, 0, 100
