#r "nuget: FunSharp.Ru"

open Библиотека
open Библиотека.Цвета

type Игрок = 
    {
        х: int
        у : int
        корабль: string
    }

type Враг = 
    {
        х:int
        у:int
        враг:string
    }
type Снаряд =
    {
        х:int
        у:int
        снаряд:string
    }

let mutable игрок = 
    { 
      х = 320
      у = 460
      корабль = Фигуры.ДобавитьПрямоугольник (60,10)
    }
let mutable враг = 
    {
        х = 320
        у = 10
        враг = Фигуры.ДобавитьЭллипс (10,10)
    }
let mutable снаряд = 
    {
        х = 320
        у = 10
        снаряд = Фигуры.ДобавитьПрямоугольник (4,8)
    }
//let враг = Фигуры.ДобавитьЭллипс (10,10)
ГрафическоеОкно.ЦветКисти <- Цвета.Красный
let жизнь1 = Фигуры.ДобавитьЭллипс (10,10)
let жизнь2 = Фигуры.ДобавитьЭллипс (10,10)
let жизнь3 = Фигуры.ДобавитьЭллипс (10,10)

let mutable скорость = 10
let mutable жизни_игрока = 3

let mutable пуля_летит = false

Фигуры.Переместить (враг.враг,враг.х,враг.у)
Фигуры.Переместить (игрок.корабль,игрок.х,игрок.у)    
Фигуры.Переместить(жизнь1,590,10)
Фигуры.Переместить(жизнь2,610,10)
Фигуры.Переместить(жизнь3,630,10)
let атака_врага() =
    if враг.у <470 then
        враг  <- {враг with у = враг.у + скорость} 
        Фигуры.Переместить (враг.враг,враг.х,враг.у)
let новый_враг () = 
    враг  <- { враг with у = 10 ; х = Математика.ВзятьСлучайноеЧисло 630 } 

let полет_пули() =
    снаряд <- {снаряд with у = снаряд.у - 10}
    Фигуры.Переместить (снаряд.снаряд,снаряд.х,снаряд.у)
    if снаряд.у = 0 then
        Фигуры.СкрытьФигуру (снаряд.снаряд)
let столкновение_с_врагом () =
    let столкнулся = игрок.х-10 <= враг.х && враг.х<= игрок.х+70 && игрок.у-10 <= враг.у && враг.у <= игрок.у+20
    if столкнулся then
        жизни_игрока <- жизни_игрока - 1
        printfn $"количество жизней:{жизни_игрока}"
        новый_враг ()
        if жизни_игрока =2 then
            Фигуры.СкрытьФигуру (жизнь3)        
        if жизни_игрока =1 then
            Фигуры.СкрытьФигуру (жизнь2)
        if жизни_игрока =0 then
            Фигуры.СкрытьФигуру (жизнь1)
let скорость_атаки_врага()=
    if враг.у>=470 then
        скорость <- скорость + 1
        новый_враг()
let столкновение_с_пулей () = 
    let столкнулся = снаряд.х-10 <= враг.х && враг.х<= снаряд.х+70 && снаряд.у-8 <= враг.у && враг.у <= снаряд.у+16
    if столкнулся then
        пуля_летит <- false
        Фигуры.СкрытьФигуру (снаряд.снаряд)
        новый_враг()
        скорость_атаки_врага()
let обработка () =
    if ГрафическоеОкно.ПоследняяКнопка ="A" then
        игрок <- { игрок with х = игрок.х - 10 }

    if ГрафическоеОкно.ПоследняяКнопка = "D" then
        игрок <- { игрок with х = игрок.х + 10 }
    if ГрафическоеОкно.ПоследняяКнопка = "Space" then
            if снаряд.у <= 0 then
                пуля_летит <- false  
            if not пуля_летит then
                снаряд <- {снаряд with х = игрок.х + 30 ; у = игрок.у}
                Фигуры.ПоказатьФигуру (снаряд.снаряд)
                Фигуры.Переместить(снаряд.снаряд,снаряд.х,снаряд.у)
                пуля_летит <- true

    if игрок.х <= 0 then
        игрок <- { игрок with х = 0 }
    if игрок.х >= 580 then
        игрок <- {игрок with х = 580}
    Фигуры.Переместить (игрок.корабль,игрок.х,игрок.у)

ГрафическоеОкно.КнопкаНажата <- обработка
обработка ()

let потеря_жизни()=
    if жизни_игрока = 0 then
        Программа.Закончить ()
while (true) do
    столкновение_с_врагом()
    атака_врага ()
    скорость_атаки_врага()
    потеря_жизни() 
    столкновение_с_пулей ()
    if пуля_летит then
        полет_пули ()
    Программа.Задержка 50
Программа.Задержка 60000

// Домашнее задание
// Сделать переменную скорость_атаки_врага которая равна 10. Когда враг доходит низа экрана и не столкнулся
// то надо увеличиться скорость на 1. Сделать переменную жизни_игрока с начальным значенем 3. При
// столкновении уменьшать количество жизней на 1. если кол-во жизней равно 0, то выйти из программы.
// Задача со звездочкой, нарисовать количество жизней, три кружочка = три жизни.
