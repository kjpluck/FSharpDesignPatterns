namespace SimUDuck
module Duck =

    type Duck = 
        | Mallard
        | RubberDuck
        | Decoy

    let display = function
        | Mallard -> printfn "I am a Mallard"
        | RubberDuck -> printfn "I am a Rubber Duck"
        | Decoy -> printfn "I am a Decoy"

    let quack = function
        | Mallard -> printfn "QUACK"
        | RubberDuck -> printfn "SQUEAK"
        | Decoy -> printfn "<silence>"

    let fly = function
        | Mallard -> printfn "I can fly!"
        | RubberDuck| Decoy -> printfn "I can't fly"