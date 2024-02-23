#r "nuget: FunSharp.Ru, 0.0.3"

open Библиотека

let количество = 10
let мяч = Фигуры.ДобавитьЭллипс(10,10)

for кадр = 0 to количество - 1 do
    if кадр % 2 = 0 then 
        ГрафическоеОкно.ЦветКисти <- Цвета.Красный

    else
        ГрафическоеОкно.ЦветКисти <-Цвета.Зеленый
    let мяч = Фигуры.ДобавитьЭллипс(10,10)

    // по диагонали
    let x = кадр * 20 + 320
    let y = кадр * -20 + 240

     //по горизонтали
    //let x = кадр * 20 + 20
    //let y = 30

    // по вертикали
    let начальная_позиция_х = 180
    let шаг_х = 10
    let начальная_позиция_у = 320
    let шаг_у = 20

    let x = начальная_позиция_х + кадр * шаг_х
    let y = начальная_позиция_у
    Фигуры.Переместить (мяч, x, y)
    Программа.Задержка 1_000
Программа.Задержка 10_000

//домашнее задание 
// Нарисуй квадрат, где каждая сторона будет нарисована кружочками
// вертикальные кружечки пусть будут зеленого цвета, горизонтальные красного