#r "nuget: FunSharp.Ru, 0.0.5"
#r "nuget: FSharp.Core.Russian, 0.0.6"
#r "nuget: Russian.System.Runtime, 0.0.2"
open Библиотека
open Фшарп.Ядро
open Библиотека.Цвета
open Система.ВВ
open System
open Система

let является_цифрой символ = 
    let цифры = ['1';'2';'3';'4';'5';'6';'7';'8';'9';'0']
    Список.содержит символ цифры
let является_числом (ч: строка)= 
    let ч = ч.Trim()
    let все_цифры = ч |> Посл.длявсех является_цифрой
    все_цифры && ч <> ""
    
let является_знаком (символ: строка) = 
    let знаки = ["+";"-";"/";"*"]
    Список.содержит (символ.Trim()) знаки

// --------------------
let ввести_число () = 
    let mutable число_выбрано = false
    let mutable строка = ""
    while (не число_выбрано) do
        строка <- Консоль.ПрочитатьСтроку()
        if не (является_числом строка )  then 
            напечататьфн "Неверный ввод. Попробуйте ввести число еще раз."
        else
            число_выбрано <- true

    цел строка
let ввести_знак() = 
    let mutable знак_выбран = false 
    let mutable строка = ""
    while (не знак_выбран) do
        строка <- Консоль.ПрочитатьСтроку()
        if не (является_знаком строка )  then 
            напечататьфн "Неверный ввод. Попробуйте ввести знак еще раз."
        else
            знак_выбран <- true
    строка

напечататьфн "Введите первое число:"
let первое_число = ввести_число ()

напечататьфн "Введите второе число:"
let второе_число = ввести_число () 

напечататьфн "Введите знак"
let знак = ввести_знак ()

let результат = 
    if знак = "+" then первое_число + второе_число
    elif знак = "-" then первое_число - второе_число
    elif знак = "*" then первое_число * второе_число
    else первое_число / второе_число
напечататьфн "%d %s %d = %d"  первое_число знак второе_число результат