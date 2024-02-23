//#i "nuget: https://api.nuget.org/v3/index.json"
#r "nuget: FunSharp.Ru, 0.0.3"

open Библиотека

ГрафическоеОкно.ЦветКисти <-Цвета.Синий

let круг = Фигуры.ДобавитьЭллипс (10.0,10.0)
ГрафическоеОкно.ЦветКисти <- Цвета.Красный
let круг2 = Фигуры.ДобавитьЭллипс (10.0,10.0)
ГрафическоеОкно.ЦветКисти <- Цвета.Желтый
let квадрат =Фигуры.ДобавитьПрямоугольник (10.0,10.0)
ГрафическоеОкно.ЦветКисти <- Цвета.Зеленый
let квадрат2 =Фигуры.ДобавитьПрямоугольник (10.0,10.0)
let движение_круга фигура радиус задержка =
 Фигуры.ПоказатьФигуру (фигура)
 Фигуры.Переместить (фигура,0.0+радиус ,0.0+радиус)
 Программа.Задержка задержка
 Фигуры.Переместить (фигура,310,230)
 Программа.Задержка задержка
 Фигуры.Переместить (фигура,630,470)
 Программа.Задержка задержка
 Фигуры.СкрытьФигуру (фигура)
let движение_квадрата фигура радиус задержка =
 Фигуры.ПоказатьФигуру (фигура)
 Фигуры.Переместить (фигура,630,10)
 Программа.Задержка задержка
 Фигуры.Переместить (фигура,320,240)
 Программа.Задержка задержка
 Фигуры.Переместить (фигура,10,470)
 Программа.Задержка задержка
 Фигуры.СкрытьФигуру (фигура)
Фигуры.СкрытьФигуру(круг)
Фигуры.СкрытьФигуру(круг2)
Фигуры.СкрытьФигуру(квадрат)
Фигуры.СкрытьФигуру(квадрат2)




движение_круга круг 10 1000
движение_квадрата квадрат 10 1000
движение_круга круг2 10 1000
движение_квадрата квадрат2 10 1000

ГрафическоеОкно.Заголовок <- "Домашнее задание 2"
Программа.Задержка 1000
