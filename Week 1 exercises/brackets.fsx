
let matchingParens(str : string) =
    let mutable cleft = 0
    let mutable cright = 0

    for i in str do
        match i with
        | '(' -> cleft <- cleft + 1
        | ')' -> cright <- cright + 1
        |_ -> ()
    
    if cleft = cright then true else false

let test_matchingP_1 = matchingParens "(((hello))(hi))()woot(())"
let test_matchingP_2 = not (matchingParens "(not(going(to(work())))")
//printfn "%b" test_matchingP_1
//printfn "%b" test_matchingP_2


let rmv(lst : char list) =
    match lst with
    |[] -> []
    |x::xs -> xs

let rec matchingBrackets(str : string) =
    let mutable recent = ""
    let mutable res = true
    let mutable clist = []
    for i in str do 
        match i with
        | '(' -> clist <- '('::clist
        | '{' -> clist <- '{'::clist
        | '[' -> clist <- '['::clist 
        | ')' when clist.[0] = '(' -> clist <- rmv(clist)
        | '}' when clist.[0] = '{' -> clist <- rmv(clist)
        | ']' when clist.[0] = '[' -> clist <- rmv(clist)
        | _ -> res <- false
    res

let test = matchingBrackets("{([[]])}")
printfn "%b" test
