#r "nuget: FunSharp.Ru"
#r "nuget: FSharp.Core.Russian, 0.0.6"
open Библиотека
open Фшарп.Ядро
open Библиотека.Цвета
ГрафическоеОкно.ЦветПера <-Цвета.Красный
ГрафическоеОкно.ЦветКисти <-Цвета.Зеленый
ГрафическоеОкно.ЦветФона <-Цвета.Синий
let фигура_1 = Фигуры.ДобавитьИзображение "C:\\unity\\rock1\\Layer 1.png"
let фигура_2 = Фигуры.ДобавитьИзображение "C:\\unity\\rock1\\Layer 2.png"
let фигура_3 = Фигуры.ДобавитьИзображение "C:\\unity\\rock1\\Layer 3.png"
let фигура_4 = Фигуры.ДобавитьИзображение "C:\\unity\\rock1\\Layer 4.png"
let фигура_5 = Фигуры.ДобавитьИзображение "C:\\unity\\rock1\\Layer 5.png"
let фигура_6 = Фигуры.ДобавитьИзображение "C:\\unity\\rock1\\Layer 6.png"
let фигуры_вправо = [фигура_1;фигура_2;фигура_3;фигура_4;фигура_5;фигура_6]
let фигуры_влево = [фигура_1;фигура_2;фигура_3;фигура_4;фигура_5;фигура_6]

let скрыть_все_фигуры_слева() = 
    for фигура in фигуры_влево do
        Фигуры.СкрытьФигуру(фигура)
let скрыть_все_фигуры_справа() =
    for фигура in фигуры_вправо do
        Фигуры.СкрытьФигуру(фигура)

let цикл_анимаций_вправо(х: int,у)= 
    let mutable сдвиг = -5
    for фигура in фигуры_вправо do
        
        Фигуры.Переместить(фигура,х + сдвиг,у)
        Фигуры.ПоказатьФигуру (фигура)
        Программа.Задержка 100
        Фигуры.СкрытьФигуру(фигура)
        сдвиг <- сдвиг + 1

    Фигуры.ПоказатьФигуру (фигура_6)

let цикл_анимаций_влево(х: int,у)= 
    let mutable сдвиг = -5
    for фигура in фигуры_влево do
        
        Фигуры.Переместить(фигура,х - сдвиг,у)
        Фигуры.ПоказатьФигуру (фигура)
        Программа.Задержка 100
        Фигуры.СкрытьФигуру(фигура)
        сдвиг <- сдвиг + 1

    Фигуры.ПоказатьФигуру (фигура_6)

let mutable х = 320 
let mutable у = 220
let обработка () =
    let mutable направление = -1
    if ГрафическоеОкно.ПоследняяКнопка ="A" then
        х <- х - 5
        скрыть_все_фигуры_справа()
        цикл_анимаций_влево(х,у)
    if ГрафическоеОкно.ПоследняяКнопка = "D" then
        х <- х + 5
        скрыть_все_фигуры_слева()
        цикл_анимаций_вправо(х,у)
        
ГрафическоеОкно.КнопкаНажата <- обработка

цикл_анимаций_вправо(х,у)
while (true) do
    Программа.Задержка 100