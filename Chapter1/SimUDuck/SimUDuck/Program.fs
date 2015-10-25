// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open SimUDuck.Duck

[<EntryPoint>]
let main argv = 
    
    display Mallard
    quack Mallard
    fly Mallard

    display Decoy
    quack Decoy
    fly Decoy

    display RubberDuck
    quack RubberDuck
    fly RubberDuck
    
    0
