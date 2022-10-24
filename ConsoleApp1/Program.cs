using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Address
    {
        //宣告 Address 類別,具備 City, ZipCode, Street 等屬性
        public String City { get; set; }
        public String ZipCode { get; set; }
        public String Street { get; set; }

    }
    class Telephone
    {
        //宣告 Telephone 類別,具備 CountryCode, AreaCode, Number, Ext 等屬性
        public String CountryCode { get; set; }
        public String PhoneNumber { get; set; }
        public String Number { get; set; }
        public String Ext { get; set; }
    }

    class Menber
    {
        //宣告 Member 類別,
        //具備 Name, Account, Password, Email, Address, CellPhone,
        //TelePhone 等屬性, 其中 Address, TelePhone的型別沿用上面
        //二個類別
        //具備 Register method, 用來註冊新會員, 參數包含 Name,
        //Account, Password, ConfirmPassword, Email
        //具備 ForgetPassword method, 用來處理忘記密碼, 參數包含
        //Name, Email
        //具備 Authenticate method ,用來判斷是否允許使用者登入, 參數
        //包含 Account, Password
        public Address addr { get; set; }
        public Telephone Tel { get; set; }

        public String Name { get; set; }
        public String Account { get; set; }
        public String Email { get; set; }
        public String CellPhone { get; set; }

        public void RegisterMethod(String Name, String Account, String Password,
                                    String ConfirmPassword, String Email)
        {

        }
        public void ForgetPasswordMethod(String Name, String Email)
        {

        }
        public void AuthenticateMethod(String Account, String Password)
        {

        }

    }
}
