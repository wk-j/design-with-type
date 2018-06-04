open System
open System.Text

type EmailAddress = EmailAddress of string
type ZipCode = ZipCode of string
type StateCode = StateCode of string

type PersonName = {
    FirstName: string
    MiddleInitial: string option
    LastName: string
}

type EmailContactInfo = {
    EmailAddress: EmailAddress
    IsEmailVerified: bool
}

type PostalAddress = {
    Address1: string
    Address2: string
    City: string
    Zip: ZipCode
}

type PostalContactInfo = {
    Address: PostalAddress
    IsAddressValid: bool
}

type Contact = {
    Name: PersonName
    EmailContactInfo: EmailContactInfo
    PostalContactInfo: PostalContactInfo
}

let createEmailAddress s =
    if RegularExpressions.Regex.IsMatch(s, @"^\S+@\S+\.\S+$") then
        Some (EmailAddress s)
    else None

let createStateCode (s: string) =
    let upper = s.ToUpper()
    let stateCodes = ["AZ"; "CA"; "NY"]
    if stateCodes |> List.exists ((=) s) then
        Some (StateCode upper)
    else None

type EmailAddress2 = EmailAddress2 of string
type CreationResult<'T> = Success of 'T | Error of string

let createEmailAddress2 (s: string) =
    if RegularExpressions.Regex.IsMatch(s, @"^\S+@\S+\.\+$") then
        Success (EmailAddress s)
    else Error "Email address must contain an @ sign"
