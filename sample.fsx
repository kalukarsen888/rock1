#r "nuget: FunSharp.Ru"
#r "nuget: FSharp.Core.Russian"

open Библиотека
open Библиотека.Цвета

type ПримерРакеткиДляСтарта()  = 
    let mutable х = 100
    let mutable у = 200
    let ракетка = Фигуры.ДобавитьПрямоугольник(10, 60)
    
    member я.Переместить(новыйХ, новыйУ) =
        х <- новыйХ
        у <- новыйУ
        Фигуры.Переместить(ракетка, х, у)

type Ракетка(начальныйХ : int, начальныйУ: int) as я =
    do
        ГрафическоеОкно.ЦветКисти <- Синий
        ГрафическоеОкно.РазмерШрифта <- 40
    let mutable х = начальныйХ
    let mutable у = начальныйУ
    let ракетка = Фигуры.ДобавитьПрямоугольник(10, 60)
    let mutable счет = 5
    let счетТекст = Фигуры.ДобавитьТекст "5"

    do
        я.Переместить(х, у)
        Фигуры.Переместить(счетТекст, начальныйХ, 10)
        я.УстановитьСчет(0)

    member я.Переместить(новыйХ, новыйУ) =
        х <- новыйХ
        у <- новыйУ
        Фигуры.Переместить(ракетка, х, у)

    member я.УстановитьСчет(новыйСчет) =
        счет <- новыйСчет
        Фигуры.УстановитьТекст (счетТекст, (sprintf "%d" счет))

    member я.ЗаработатьОчко() =
        я.УстановитьСчет(счет + 1)

    member я.ПереместитьВверх() =
        let выходит_за_границу = у < 10
        if не выходит_за_границу then
            я.Переместить(х, у - 10)

    member я.ПереместитьВниз() =
        let выходит_за_границу = у > 410
        if не выходит_за_границу then
            я.Переместить(х, у + 10)

type Мяч(начальныйХ : int, начальныйУ: int) as я =
    do
        ГрафическоеОкно.ЦветКисти <- Красный
    let mutable х = начальныйХ
    let mutable у = начальныйУ
    let mutable скоростьХ = 10
    let mutable скоростьУ = 10
    let мяч = Фигуры.ДобавитьЭллипс(10, 10)

    do
        я.Переместить(х, у)

    member я.Переместить(новыйХ, новыйУ) =
        х <- новыйХ
        у <- новыйУ
        Фигуры.Переместить(мяч, х, у)

    member я.ВозлеЛевойГраницы() =
        х = 10

    member я.ВозлеПравойГраницы() =
        х = 630

    member я.ОтскокХ() =
        скоростьХ <- -скоростьХ

    member я.ОтскокУ() =
        скоростьУ <- -скоростьУ

    //member я.РядомСРакеткой(ракетка: Ракетка) =
    //    let рядомСВерхом = х = ракетка.

    member я.Полет() =
        if х = 10 || х = 630 then
            я.ОтскокХ()
        if у = 10 || у = 470 then
            я.ОтскокУ()

        х <- х + скоростьХ
        у <- у + скоростьУ
        Фигуры.Переместить(мяч, х, у)

let мяч = Мяч(320, 240)

let игрок1 = Ракетка(10, 210)
let игрок2 = Ракетка(620, 210)

let обработка () =
    if ГрафическоеОкно.ПоследняяКнопка = "W" then
        игрок1.ПереместитьВверх ()
    if ГрафическоеОкно.ПоследняяКнопка = "S" then
        игрок1.ПереместитьВниз ()
    if ГрафическоеОкно.ПоследняяКнопка = "Up" then
        игрок2.ПереместитьВверх ()
    if ГрафическоеОкно.ПоследняяКнопка = "Down" then
        игрок2.ПереместитьВниз ()

ГрафическоеОкно.КнопкаНажата <- обработка

while (true) do
    мяч.Полет()
    if мяч.ВозлеЛевойГраницы() then
        игрок2.ЗаработатьОчко()
    if мяч.ВозлеПравойГраницы() then
        игрок1.ЗаработатьОчко()

    Программа.Задержка 1000