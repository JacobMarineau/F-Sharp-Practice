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

let getLetters() =
  for c in 'a' .. 'z' do
    printf "%c " c
  printfn ""

getLetters()

let man = "dude man"

let activeDude(dude) =
    if dude = "dude man" then printfn "yeah %s" dude
    else printfn "%s" dude

activeDude(man)

let letters = ['a' .. 'z']

let getLettersFromList() =
  letters
  |> List.iter (printf "%c ")
  printfn ""

let lettersReverseFromList() =
  letters
  |> List.rev
  |> List.iter (printf "%c ")
  printfn ""

getLettersFromList()
lettersReverseFromList()
