// dotnet fsi .\program.fsx

let имя = "Арсений"

let возраст = 11

let вес = 40.0
let рост = 160

printfn $"Меня зовут {имя}, мой возраст {возраст} лет.
Мой вес {вес}кг и рост {рост}см" 

let длина = 10
let ширина =20
let площадь =длина * ширина

printfn $"дан прямоугольник с шириной {ширина} и длиной {длина}
площадь {площадь}"

let периметр = длина + длина + ширина + ширина

printfn $"периметр {периметр} "

let площадь длина ширина =
    длина * ширина