open System.Text

module EmailAddress =
    type T = private EmailAddress of string
    let create (s: string) =
        if RegularExpressions.Regex.IsMatch(s, @"^\S+@\S+.\S+$") then
            Some (EmailAddress s)
        else None
    let value (EmailAddress e) = e

module EmailAddress2 =
    type T = EmailAddress of string
    let create (s:string) =
        if System.Text.RegularExpressions.Regex.IsMatch(s,@"^\S+@\S+\.\S+$")
            then Some (EmailAddress s)
            else None
    // unwrap
    let value (EmailAddress e) = e


open EmailAddress


let mail = create "wk@gmail.com"
match mail with
| Some m -> printfn "%A" (EmailAddress.value m)
| None -> ()