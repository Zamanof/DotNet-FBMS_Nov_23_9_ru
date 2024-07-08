#region Single Responsibility Bad Example
//class SendMail
//{
//    public bool Send(string mailAddress, string message)
//    {
//        if(IsMailAddressValid(mailAddress))
//        {
//            return true;
//        }
//        return false;
//    }

//    public bool IsMailAddressValid(string mailAddress)
//    {
//        // some magic code for check mail validation
//        return true;
//    }
//}



#endregion

#region Single Responsibility Good Example
class MailAddressValidation
{
    public bool IsMailAddressValid(string mailAddress)
    {
        // some magic code for check mail validation
        return true;
    }
}

class SendMail
{
    private MailAddressValidation _validation = new();
    public bool Send(string mailAddress, string message)
    {
        if (_validation.IsMailAddressValid(mailAddress))
        {
            return true;
        }
        return false;
    }
}

#endregion