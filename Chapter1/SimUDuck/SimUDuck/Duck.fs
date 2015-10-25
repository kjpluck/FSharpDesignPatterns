namespace SimUDuck
module Duck =

    type Duck = 
        | Mallard
        | RubberDuck
        | Decoy

    let quack = function
        | Mallard -> printfn "QUACK"
        | RubberDuck -> printfn "SQUEAK"
        | Decoy -> printfn "<silence>"

    let fly = function
        | Mallard -> printfn "I can fly!"
        | RubberDuck| Decoy -> printfn "I can't fly"