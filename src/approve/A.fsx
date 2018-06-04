type Result = Approve | Reject

type ApproveRequest = {
    Signs : string list
    Price : int
}

let approve = function
    | { Price = price; Signs = signs } when price >= 50000 && signs.Length = 2
        -> Approve
    | _ -> Reject

{ Price = 10000; Signs = [ "u1" ] }
|> approve
|> printfn "%A"

{ Price = 50000000; Signs = [ "u1"; "u2" ] }
|> approve
|> printfn "%A"