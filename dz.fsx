#i "nuget: https://api.nuget.org/v3/index.json"
#r "nuget: FunSharp.Ru, 0.0.2"

open Библиотека

ГрафическоеОкно.Заголовок <- "Домашнее задание"

let квадрат = Фигуры.ДобавитьПрямоугольник (20.0,20.0)
Фигуры.Переместить (квадрат,0,210 )
let квадрат2 = Фигуры.ДобавитьПрямоугольник (20.0,20.0)
Фигуры.Переместить (квадрат2,320,460 )
let квадрат3 = Фигуры.ДобавитьПрямоугольник (20.0,20.0)
Фигуры.Переместить (квадрат3,620,210)
let квадрат4 = Фигуры.ДобавитьПрямоугольник (20.0,20.0)
Фигуры.Переместить (квадрат4,320,0)
Программа.Задержка 4_000
Фигуры.СкрытьФигуру(квадрат)
Фигуры.СкрытьФигуру(квадрат2)
Фигуры.СкрытьФигуру(квадрат3)
Фигуры.СкрытьФигуру(квадрат4)
let овал =Фигуры.ДобавитьЭллипс (30.0,10.0)
Фигуры.Переместить (овал,320,240)
Программа.Задержка 4_000
Фигуры.СкрытьФигуру (овал)
let овал2 =Фигуры.ДобавитьЭллипс (10.0,30.0)
Фигуры.Переместить (овал2,320,240)
Программа.Задержка 4_000
