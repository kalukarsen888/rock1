#i "nuget: https://api.nuget.org/v3/index.json"
#r "nuget: FunSharp.Ru, 0.0.2"

open Библиотека

ГрафическоеОкно.Заголовок <- "Мячик"

//ГрафическоеОкно.ЦветКисти <- Цвета.AliceBlue

let мяч = Фигуры.ДобавитьЭллипс (10.0,10.0)
Фигуры.Переместить (мяч,50,20)
let мяч2 = Фигуры.ДобавитьЭллипс (20.0,20.0) 
Фигуры.Переместить(мяч2,20,20)

let мяч3 = Фигуры.ДобавитьЭллипс (20.0,20.0)
Фигуры.Переместить(мяч3,20,460)
let мяч4 = Фигуры.ДобавитьЭллипс (20.0,20.0)
Фигуры.Переместить(мяч4,620,460)
let мяч5 = Фигуры.ДобавитьЭллипс (20.0,20.0)
Фигуры.Переместить(мяч5,620,20)

Программа.Задержка 2_000
Фигуры.СкрытьФигуру (мяч)
Программа.Задержка 2_000
Фигуры.ПоказатьФигуру (мяч)
ГрафическоеОкно.РазмерШрифта <- 50
let текст = Фигуры.ДобавитьТекст "Веселый мяч"
Фигуры.Переместить(текст,220,20)
Фигуры.ДобавитьПрямоугольник (30.0,20.0)



Программа.Задержка 200_000

// Домашнее задание
// Нарисовать 4 квадрата, расположенных по центру каждой границы графического окна
// Через пару секунд скрыть 4 квадрата, и показать в центре графического окна горизонтальный овал
// через пару секунд показать вертикально расположенный овал на том же месте, в центре графического окна,
// как буд-то оно было повернуто