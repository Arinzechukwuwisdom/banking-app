Using System;﻿
namespace BankingApp{
class Program{
 public class User{
  public string Name{get;set;}
  public string Email{get;set;}
  public string PhoneNumber{get;set}
  public DateTime DateOfBirth{get;set;}
  public string Password { get; }
  public User( string name, string email , string phoneNumber, DateTime dateOfBirth,string password) {
   
Name = name;
Email = email;
PhoneNumber = phoneNumber;
DateOfBirth = dateOfBirth;
Password=password;
   
  }
 }
 public class BankAccount {
     public string AccountNumber { get; }// the reason i used get only is bc i want to generate the account number automatically and I dont want it to be changed.
     public decimal Balance { get; private set; }
     public string AccountHolder { get; }

     public BankAccount(string accountnumber, decimal balance, string accountHolder)
     {

         AccountNumber = accountnumber;
         Balance = balance;
         AccountHolder = accountHolder;
     }
  }
   public class Transaction {

public string TransactionID { get; } = Guid.NewGuid().ToString();
    public decimal Amount { get; }
    public string FromAccount{ get; }
    public string ToAccount { get; }
    public DateTime Date { get; } = DateTime.Now;

    public Transaction(string transactionID, decimal amount, string fromAccount, string toAccount, DateTime dateNow) {
    Amount = amount;
    FromAccount = fromAccount;
    ToAccount = toAccount;
    Date = dateNow;
}
 static void Main()
  
 }
}
}



Console.Write("Enter Your Name:");
 string name = Console.ReadLine();
Console.Write("Password:");
string lastname = Console.ReadLine();
Console.WriteLine("Hello {0} welcome to theBulb MicrofinanceBank. Here's your account no:10992783938", name);
//Console.WriteLine("Hello " +  name  + " welcome to theBulb MicrofinanceBank. Here's your account no:10992783938");

if (name and password is correct,view account balance
bool isName = true, isPassword = true;
if (isName && isPassword);
Console.WriteLine("Account Balance:$25,000");

bool isDetailsCorrect = true;
bool isAmount2000 = true;
if (isDetailsCorrect== isAmount2000) ;
Console.WriteLine("Successful");


