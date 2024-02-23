#r "nuget: FunSharp.Ru"

open Библиотека
open Библиотека.Цвета
let корабль = Фигуры.ДобавитьПрямоугольник (60,10)
let враг = Фигуры.ДобавитьЭллипс (10,10)
ГрафическоеОкно.ЦветКисти <- Цвета.Красный
let жизнь1 = Фигуры.ДобавитьЭллипс (10,10)
let жизнь2 = Фигуры.ДобавитьЭллипс (10,10)
let жизнь3 = Фигуры.ДобавитьЭллипс (10,10)
let снаряд = Фигуры.ДобавитьПрямоугольник (4,8)



let mutable x=320
let mutable y=460
let mutable xвраг=320
let mutable yвраг=10
let mutable скорость = 10
let mutable жизни_игрока = 3
let mutable xпули = x
let mutable yпули = y
let mutable пуля_летит = false

Фигуры.Переместить (враг,xвраг,yвраг)
Фигуры.Переместить (корабль,x,y)    
Фигуры.Переместить(жизнь1,590,10)
Фигуры.Переместить(жизнь2,610,10)
Фигуры.Переместить(жизнь3,630,10)
let атака_врага() =
    if yвраг <470 then
        yвраг <- yвраг + скорость
        Фигуры.Переместить (враг,xвраг,yвраг)
let новый_враг () = 
    xвраг <- Математика.ВзятьСлучайноеЧисло 630
    yвраг <- 10
let полет_пули() =
    yпули <-yпули - 10
    Фигуры.Переместить (снаряд,xпули,yпули)
    if yпули = 0 then
        Фигуры.СкрытьФигуру (снаряд)
let столкновение_с_врагом () =
    let столкнулся = x-10 <= xвраг && xвраг<= x+70 && y-10 <= yвраг && yвраг <= y+20
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
    if yвраг>=470 then
        скорость <- скорость + 1
        новый_враг()
let столкновение_с_пулей () = 
    let столкнулся = xпули-10 <= xвраг && xвраг<= xпули+70 && yпули-8 <= yвраг && yвраг <= yпули+16
    if столкнулся then
        пуля_летит <- false
        Фигуры.СкрытьФигуру (снаряд)
        новый_враг()
        скорость_атаки_врага()
let обработка () =
    if ГрафическоеОкно.ПоследняяКнопка ="A" then
        x <- x - 10

    if ГрафическоеОкно.ПоследняяКнопка = "D" then
        x <- x + 10
    if ГрафическоеОкно.ПоследняяКнопка = "Space" then
            //пуля_летит <- true
            //Фигуры.Переместить(снаряд,xпули,yпули)
            if yпули <= 0 then
                пуля_летит <- false  
            if not пуля_летит then
                xпули <- x + 30
                yпули <- y
                Фигуры.ПоказатьФигуру (снаряд)
                Фигуры.Переместить(снаряд,xпули,yпули)
                пуля_летит <- true

            printfn "пробел"
    if x <= 0 then
        x <- 0
    if x >= 580 then
        x <- 580
    Фигуры.Переместить (корабль,x,y)

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
    Программа.Задержка 100
Программа.Задержка 60000

// Домашнее задание
// Сделать переменную скорость_атаки_врага которая равна 10. Когда враг доходит низа экрана и не столкнулся
// то надо увеличиться скорость на 1. Сделать переменную жизни_игрока с начальным значенем 3. При
// столкновении уменьшать количество жизней на 1. если кол-во жизней равно 0, то выйти из программы.
// Задача со звездочкой, нарисовать количество жизней, три кружочка = три жизни.