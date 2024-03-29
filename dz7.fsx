#r "nuget: FunSharp.Ru, 0.0.3"

open Библиотека

let mutable x = 320
let mutable y = 240
let mutable счет =0

let mutable x2 = 420
let mutable y2 = 340
let mutable счет2 =0

let mutable y3 = 0
let mutable x3 = 0
let mutable еда_перенаправлена_вниз = true

let круг = Фигуры.ДобавитьЭллипс (10, 10)
Фигуры.Переместить (круг,x,y)
ГрафическоеОкно.ЦветКисти <- Цвета.Красный
let круг2 = Фигуры.ДобавитьЭллипс (10,10)
Фигуры.Переместить (круг2,x2,y2)
ГрафическоеОкно.ЦветКисти <- Цвета.Синий

еда_перенаправлена_вниз <- false
let еда = Фигуры.ДобавитьПрямоугольник (20, 10)

let новая_еда () = 
    x3 <- 10 + 10 * Математика.ВзятьСлучайноеЧисло 61
    y3 <- 10 + 10 * Математика.ВзятьСлучайноеЧисло 45
    Фигуры.Переместить (еда,x3,y3)
let переместить_еду () =
    if еда_перенаправлена_вниз then  
        y3 <- y3 + 10
        if y3 >= 470 then
            y3 <- 470
            еда_перенаправлена_вниз <- false     
    else  
        y3 <- y3 - 10
        if y3 <= 10 then
            y3 <- 10
            еда_перенаправлена_вниз <- true     
    Фигуры.Переместить (еда,x3,y3)


let сьесть_еду () =
    let еда_съедена = x3 <= x && x <= x3 + 22 && y3 <= y && y <= y3 + 12
    if еда_съедена then
        счет <- счет + 1
        новая_еда ()
        printfn $"счет {счет}:{счет2}"
        
    let еда_съедена2 = x3 - 10 <= x2 && x2 <= x3 + 30 && y3 - 10 <= y2 && y2 <= y3 + 20
    if еда_съедена2 then
        счет2 <- счет2 + 1
        новая_еда ()
        printfn $"счет {счет}:{счет2}" 


новая_еда ()

let обработка () =
    if ГрафическоеОкно.ПоследняяКнопка ="A" then
        x <- x - 10

    if ГрафическоеОкно.ПоследняяКнопка = "D" then
        x <- x + 10
    if ГрафическоеОкно.ПоследняяКнопка ="W" then
        y <- y - 10

    if ГрафическоеОкно.ПоследняяКнопка = "S" then
        y <- y + 10
    if ГрафическоеОкно.ПоследняяКнопка = "Left" then
        x2 <- x2 - 10
    if ГрафическоеОкно.ПоследняяКнопка = "Up" then
        y2 <- y2 - 10
    if ГрафическоеОкно.ПоследняяКнопка = "Right" then
        x2 <- x2 + 10
    if ГрафическоеОкно.ПоследняяКнопка = "Down" then
        y2 <- y2 + 10

    if x <= 10 then
        x <- 10
    if y <= 10 then
        y <- 10
    if x >= 630 then
        x <- 630
    if y >= 470 then
        y <- 470

    if x2 <= 10 then
        x2 <- 10
    if y2 <= 10 then
        y2 <- 10
    if x2 >= 630 then
        x2 <- 630
    if y2 >= 470 then
        y2 <- 470 
       
    Фигуры.Переместить (круг,x,y)
    Фигуры.Переместить (круг2,x2,y2)
    сьесть_еду()

    if счет = 5 then
        printfn "игра завершена победил игрок номер 1"
        Программа.Закончить ()
    if счет2 = 5 then
        printfn "игра завершена победил игрок номер 2"
        Программа.Закончить ()
        
ГрафическоеОкно.КнопкаНажата <- обработка

while (true) do
    переместить_еду ()
    сьесть_еду()
    Программа.Задержка 1_000


Программа.Задержка 200_000

// Домашнее задание:
// Сделать логическую переменную которая говорит будет ли еда падать вниз или нет
// после того как еда упала в самый низ, надо чтобы еда "отскочила" и поменяла направление падения
// после того как еда достигла верхнего края, она снова должна падать вниз