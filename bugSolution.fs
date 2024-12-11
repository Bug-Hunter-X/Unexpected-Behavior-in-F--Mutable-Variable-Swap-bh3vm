let mutable x = 1
let mutable y = 2

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y // this will print 2 1 as expected

let mutable a = 1
let mutable b = 2

let swap2 () =
    let temp = a
    a <- b
    b <- temp
    a, b // return the updated values

let a, b = swap2 () // assign the returned values back to the variables
printf "%d %d" a b //this will print 2 1 as expected