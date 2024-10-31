printfn "Hello World from F#"

let printMessage name =
    printfn $"Hello there, {name}!"

let printNames names =
    for name in names do
        printMessage name

let names = [ "Ana"; "Felipe"; "Emillia" ]
printNames names

let countUp() =
    for count in 1 .. 10 do
        printf "%d " count 
    printfn ""
countUp()
