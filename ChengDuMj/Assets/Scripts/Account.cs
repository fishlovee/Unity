using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// 账户
public class Account
{
    private static Account account;
    public string http_url = "http://127.0.0.1:8080/";
    public string logname = "defualt";
    public string password = "defalut";

    public static Account GetAccount()
    {
        if (account == null)
            account = new Account();
        return account;
    }
}

