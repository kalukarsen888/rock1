#r "nuget: FunSharp.Ru"
#r "nuget: FSharp.Core.Russian, 0.0.2"

open Библиотека
open Фшарп.Ядро
open Библиотека.Цвета
ГрафическоеОкно.ЦветПера <-Цвета.Синий
ГрафическоеОкно.ЦветКисти <-Цвета.Синий
ГрафическоеОкно.ЦветФона <-Цвета.Синий

type Игрок = 
    {
        mutable х:int
        mutable у:int
        mutable направление:int
        на_восток:string
        на_север:string
        на_запад:string
        на_юг:string
        

    }

    member я.поворот новое_направление =
        я.направление <- новое_направление
        if я.направление = 0 then 
            Фигуры.ПоказатьФигуру (я.на_восток)
            Фигуры.СкрытьФигуру (я.на_запад)
            Фигуры.СкрытьФигуру (я.на_север)
            Фигуры.СкрытьФигуру (я.на_юг)
            Фигуры.Переместить (я.на_восток,я.х,я.у)
        if я.направление = 1 then 
            Фигуры.СкрытьФигуру (я.на_восток)
            Фигуры.ПоказатьФигуру (я.на_запад)
            Фигуры.СкрытьФигуру (я.на_север)
            Фигуры.СкрытьФигуру (я.на_юг)
            Фигуры.Переместить (я.на_запад,я.х,я.у)
        if я.направление = 2 then 
            Фигуры.СкрытьФигуру (я.на_восток)
            Фигуры.СкрытьФигуру (я.на_запад)
            Фигуры.ПоказатьФигуру(я.на_север)
            Фигуры.СкрытьФигуру (я.на_юг)
            Фигуры.Переместить (я.на_север,я.х,я.у)
        if я.направление = 3 then 
            Фигуры.СкрытьФигуру (я.на_восток)
            Фигуры.СкрытьФигуру (я.на_запад)
            Фигуры.СкрытьФигуру(я.на_север)
            Фигуры.ПоказатьФигуру (я.на_юг)
            Фигуры.Переместить (я.на_юг,я.х,я.у)
let mutable уровень_1 = [
    [ "Ц"; "Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц" ]
    [ "Ц"; "Т";"к";"Т";"Т";"к";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"К";"Т";"Т";"К";"Т";"к";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"К";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"к";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"к";"Т";"Т";"Т";"Т";"Т";"К";"к";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"К";"к";"Т";"Т";"Т";"Т";"Т";"К";"Т";"к";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"К";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"К";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"В";"Ц" ]
    [ "Ц"; "Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]



]
let mutable уровень_2 = [
    [ "Ц"; "Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Т";"Ц" ]
    [ "Ц"; "Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц";"Ц" ]



]

let папка_с_тайлами = "C:\\unity\\rock1\\тайлы\\"
let создать_спрайт к = 
    if к = "Т" then Фигуры.ДобавитьИзображение (папка_с_тайлами + "3.png")
    elif к = "К" then Фигуры.ДобавитьИзображение (папка_с_тайлами + "1.png")
    elif к = "к" then Фигуры.ДобавитьИзображение (папка_с_тайлами + "2.png")
    elif к = "Ц" then Фигуры.ДобавитьИзображение (папка_с_тайлами + "4.png")
    elif к = "В" then Фигуры.ДобавитьИзображение (папка_с_тайлами + "выход.png")
    else
    ""
let нарисовать_карту (уровень:string list list) =
    let mutable ряд = 0
    for ряд_уровня in уровень do 
        let mutable столбец = 0
        for тайл_код in ряд_уровня do 
            let спрайт = создать_спрайт тайл_код 
            Фигуры.Переместить (спрайт,столбец*32,ряд*32)
            столбец <- столбец + 1
        ряд <- ряд + 1 

нарисовать_карту уровень_1
let создать_персонажа (х,у,направление,тип_спрайта) =
    let игрок  =   
        {
            х = х
            у = у 
            направление = 0
            на_восток =Фигуры.ДобавитьИзображение $"C:\\unity\\rock1\\Спрайты для игры\\{тип_спрайта} восток.png"
            на_север =Фигуры.ДобавитьИзображение $"C:\\unity\\rock1\\Спрайты для игры\\{тип_спрайта} север.png"
            на_запад =Фигуры.ДобавитьИзображение $"C:\\unity\\rock1\\Спрайты для игры\\{тип_спрайта} запад.png"
            на_юг =Фигуры.ДобавитьИзображение $"C:\\unity\\rock1\\Спрайты для игры\\{тип_спрайта} юг.png"
        } 
    игрок.поворот направление
    игрок
let mutable игрок  = создать_персонажа(320,240,0,"Игрок")  
let mutable враг = создать_персонажа(240,240,0,"враг")
let точка_внутри_прямоугольника (хточки,уточки,х,у)  =
    (хточки > х && хточки < х+40) && (уточки > у+32 && уточки < у+64)
let тайл_внутри_прямоугольника (хтайла,утайла,х,у) =
    точка_внутри_прямоугольника(хтайла,утайла,х,у)||
    точка_внутри_прямоугольника(хтайла+32,утайла,х,у)||
    точка_внутри_прямоугольника(хтайла,утайла+32,х,у)||
    точка_внутри_прямоугольника(хтайла+32,утайла+32,х,у)
let можно_стоять_в_ряду(уровень: string list list, код_ряда, х,у) =
    let ряд = уровень[код_ряда]
    let mutable результат = true
    let mutable код_столбца = 0
    for столбец in ряд do
        if столбец = "к" || столбец = "К" then
            let пересечение_с_тайлом = тайл_внутри_прямоугольника(код_столбца * 32, код_ряда * 32, х, у)
            результат <- результат && не пересечение_с_тайлом
        код_столбца <- код_столбца + 1
    результат

let можно_стоять(уровень: string list list, х,у) =
    if х >= 608 || х <= -10 || у >= 420 || у <= -10 then
        false
    else
        let mutable результат = true
        let mutable код_ряда = 0
        for ряд in уровень do
            результат <- результат && можно_стоять_в_ряду(уровень, код_ряда, х, у)
            код_ряда <- код_ряда + 1
        результат
let можно_выйти_в_ряду(уровень: string list list, код_ряда, х,у) =
    let ряд = уровень[код_ряда]
    let mutable результат = false
    let mutable код_столбца = 0
    for столбец in ряд do
        if столбец = "В" then
            let пересечение_с_тайлом = тайл_внутри_прямоугольника(код_столбца * 32, код_ряда * 32, х, у)
            if  пересечение_с_тайлом then
                напечататьф "тайл (%d,%d) игрок (%d,%d)" код_столбца код_ряда х у
            результат <- результат || пересечение_с_тайлом
        код_столбца <- код_столбца + 1
    результат

let можно_выйти(уровень: string list list, х,у) =
    let mutable результат = false
    let mutable код_ряда = 0
    for ряд in уровень do
        результат <- результат || можно_выйти_в_ряду(уровень, код_ряда, х, у)
        код_ряда <- код_ряда + 1
    результат
    

let попробовать_переместить непись (направление: int) =
    let mutable результат = непись
    if направление = 1 then
         if можно_стоять(уровень_1, непись.х - 8, непись.у) then
            результат <- { непись with х = непись.х - 8 }
    if направление = 0 then
         if можно_стоять(уровень_1, непись.х + 8, непись.у) then
            результат <- { непись with х = непись.х + 8 }
    if направление = 2 then
         if можно_стоять(уровень_1, непись.х, непись.у-8) then
            результат <- { непись with у = непись.у - 8 }
    if направление = 3 then
         if можно_стоять(уровень_1, непись.х, непись.у + 8) then
            результат <- { непись with у = непись.у + 8 }
    
    результат.поворот направление
    результат

let обработка () =
    if ГрафическоеОкно.ПоследняяКнопка ="A" then
        игрок <- попробовать_переместить игрок 1

    if ГрафическоеОкно.ПоследняяКнопка = "D" then
        игрок <- попробовать_переместить игрок 0

    if ГрафическоеОкно.ПоследняяКнопка = "W" then
        игрок <- попробовать_переместить игрок 2

    if ГрафическоеОкно.ПоследняяКнопка = "S" then
        игрок <- попробовать_переместить игрок 3

    if ГрафическоеОкно.ПоследняяКнопка ="Left" then
        враг <- попробовать_переместить враг 1

    if ГрафическоеОкно.ПоследняяКнопка = "Right" then
        враг <- попробовать_переместить враг 0

    if ГрафическоеОкно.ПоследняяКнопка = "Up" then
        враг <- попробовать_переместить враг 2

    if ГрафическоеОкно.ПоследняяКнопка = "Down" then
        враг <- попробовать_переместить враг 3


ГрафическоеОкно.КнопкаНажата <- обработка
обработка ()



let ии ()  =
    if игрок.х > враг.х then
        0
    elif игрок.х < враг.х then
        1
    elif игрок.у > враг.у then
        3
    else  
        2
let столкновение_с_врагом () = 
    if враг.х = игрок.х && враг.у = игрок.у then
        ГрафическоеОкно.ЦветКисти <- Синий
        ГрафическоеОкно.РазмерШрифта <- 90
        let оформление2 = Фигуры.ДобавитьИзображение "C:\\unity\\rock1\\тайлы\\оформление.png"
        Фигуры.Переместить(оформление2,224,165)
        let проиграл = Фигуры.ДобавитьТекст "Проиграл"
        Фигуры.Переместить (проиграл,220,205)
        Программа.Задержка 5000
        Программа.Закончить()
let mutable таймер = 0
while (true) do
    let результат_ии =ии()
    if таймер >= 1000 then 
        враг <- попробовать_переместить враг результат_ии
    столкновение_с_врагом()
    let игрок_победил =можно_выйти (уровень_1,игрок.х,игрок.у)
    if игрок_победил then
        let оформление = Фигуры.ДобавитьИзображение "C:\\unity\\rock1\\тайлы\\оформление.png"
        Фигуры.Переместить(оформление,224,165)
        ГрафическоеОкно.РазмерШрифта <- 90
        let выиграл =Фигуры.ДобавитьТекст "Выиграл"
        Фигуры.Переместить (выиграл,232,205)
        Программа.Задержка 5000
        Программа.Закончить()
    Программа.Задержка 100
    таймер <- таймер + 100

Программа.Задержка 1_000_000_000
