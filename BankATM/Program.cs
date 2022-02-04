using System;

namespace BankATM
{

    static class UserVerification
    {
        private static readonly string userID = "11998811";
        private static readonly string userPassword = "1111";

        public static bool userIDPassworCheck(string id, string password)
        {
            bool check = (userID.Equals(id) && (userPassword.Equals(password))) ? true : false;
            return check;
        }

    }

    static class UserAccount
    {
        private static int amount = 500000;

        public static void insertMoney(int insertMoney)
        {
            amount += insertMoney;
        }
        public static void withDrawMoney (int withDrawMoney)
        {
            if (withDrawMoney > amount || (amount == 0))
            {
                throw new Exception("The widthdrawl is more than the amount you have...");
            }

            amount -= withDrawMoney;
            Console.WriteLine("After Withdrawl : " +  amount);
        }
        public static int balanceCheck()
        {
            return amount;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            string userID = null;
            string userPassword = null;

            Console.WriteLine("please enter your ID");
            userID = Console.ReadLine();

            Console.WriteLine("please enter your password");
            userPassword = Console.ReadLine();

            bool isOurUser = UserVerification.userIDPassworCheck(userID, userPassword);


            while (isOurUser)
            {
                Console.WriteLine("please enter the amount you want to save...");
                int save = Convert.ToInt32(Console.ReadLine());
                UserAccount.insertMoney(save);


                Console.WriteLine("please enter the amount you want to withdraw...");
                int withdraw = Convert.ToInt32(Console.ReadLine());
                UserAccount.withDrawMoney(withdraw);

                Console.WriteLine(UserAccount.balanceCheck());
            }
        }
    }
}
