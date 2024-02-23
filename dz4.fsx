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

let горизонтальные_линии количество начальная_позиция_х начальная_позиция_у цвет =
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

квадрат 180 320 Цвета.Красный
квадрат 350 260 Цвета.Синий
квадрат 50 160 Цвета.Зеленый
квадрат 460 320 Цвета.Желтый
Программа.Задержка 10_000

