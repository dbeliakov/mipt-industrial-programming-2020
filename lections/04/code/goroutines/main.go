package main

import (
    "fmt"
    "runtime"
)

func f(n int) {
    for i := 0; i < 10; i++ {
        fmt.Println(n, ":", i)
        runtime.Gosched()
    }
}

func main() {
    go f(0)
    go f(1)
    var input string
    fmt.Scanln(&input)
}
