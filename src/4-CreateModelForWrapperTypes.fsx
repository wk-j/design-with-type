module EmailAddress =
    type T = EmailAddress of string

    let create (s: string) =
        if System.Text.RegularExpressions.Regex.IsMatch(s, @"^\S+@\S+\.\S+$") then
            Some (EmailAddress s)
        else None

    let value  (EmailAddress e) = e


let address1 = EmailAddress.create "x@example.com"
let address2 = EmailAddress.create "example.com"

match address1 with
| Some e -> EmailAddress.value e |> printfn "the value is %s"
| None -> ()