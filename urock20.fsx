#r "nuget: FunSharp.Ru"
#r "nuget: FSharp.Core.Russian, 0.0.6"

open Библиотека
open Фшарп.Ядро
open Библиотека.Цвета
ГрафическоеОкно.ЦветПера <-Цвета.Синий
ГрафическоеОкно.ЦветКисти <-Цвета.Синий
ГрафическоеОкно.ЦветФона <-Цвета.Синий
//let цифры = [28;83;90;27;49]
let цифры = [28;83;90;27;84]
// for номер = 2 to 20 do 
//     if номер % 2 = 0 then
//         напечататьфн "%d" номер 
let mutable максимальное_число = 0
let mutable второе_число_от_минимального_числа = 9999
let mutable минимальное_число = 999999
let mutable второе_число_от_максимального = 0

for элемент in цифры  do
    if элемент > максимальное_число then    
        второе_число_от_максимального <- максимальное_число
        максимальное_число <- элемент 
        // напечататьфн "Э=%d М=%d 2М=%d" элемент максимальное_число второе_число_от_максимального
    else // элемент <= максимальное_число
        if элемент > второе_число_от_максимального && элемент <= максимальное_число then
            второе_число_от_максимального <- элемент
            // напечататьфн "Э=%d М=%d 2М=%d" элемент максимальное_число второе_число_от_максимального

    /////////////////////////////////
    напечататьфн "Э=%d" элемент
    if элемент < минимальное_число then  
        второе_число_от_минимального_числа <- минимальное_число
        минимальное_число <- элемент
        напечататьфн "1 Э=%d Мин=%d 2Мин=%d" элемент минимальное_число второе_число_от_минимального_числа
    else  if элемент >= второе_число_от_минимального_числа && элемент <= минимальное_число then
        второе_число_от_минимального_числа <- минимальное_число
        напечататьфн "2 Э=%d Мин=%d 2Мин=%d" элемент минимальное_число второе_число_от_минимального_числа

    
напечататьфн "%d" максимальное_число
напечататьфн "%d" минимальное_число
напечататьфн "%d" второе_число_от_максимального
напечататьфн "%d" второе_число_от_минимального_числа


напечататьфн "%d" цифры[1]
let первое_действие = минимальное_число + максимальное_число 
let второе_действие = второе_число_от_максимального + второе_число_от_минимального_числа 
напечататьфн " первое действие%d второе действие %d" первое_действие второе_действие
напечататьфн "М=%d 2М=%d" максимальное_число второе_число_от_максимального
if первое_действие > второе_действие then 
    напечататьфн "первое действие больше второго"
if первое_действие < второе_действие then 
    напечататьфн "второе действие больше первого"
if первое_действие = второе_действие then 
    напечататьфн "оба действия равны"
//(минимальное + максимальное) (второе число от максимального + второе от минимального числа) 
// если первое произведение > второго написать первые больше второго,а если вторые > первого то написать первые меньше вторых

// Напечатать таблицу умножения на 4
// Например
// 4 х 1 = 4
// 4 х 2 = 8    
// до 10 
