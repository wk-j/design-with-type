type PostalAddress = {
    Address1: string
    Address2: string
    City: string
    State: string
    Zip: string
}

type PostalContactInfo = {
    Address: PostalAddress
    IsAddressValid: bool
}

type PersonalName = {
    FirstName: string
    MiddleInitial: string
    LastName: string
}

type EmailContactInfo = {
    EmailAddress: string
    IsEmailVerfied: bool
}


type Contact = {
    Name: PersonalName
    EmailContactInfo: EmailContactInfo
    PostalContactInfo : PostalContactInfo
}