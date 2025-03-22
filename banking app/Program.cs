Using System;﻿
namespace BankingApp{
class Program{
 public class User{
  public string Name{get;set;}
  public string Email{get;set;}
  public string PhoneNumber{get;set}
  public DateTime DateOfBirth{get;set;}
  public User( string name, string email , string phoneNumber, DateTime dateOfBirth) {
   
   Name = name;
Email = email;
PhoneNumber = phoneNumber;
DateOfBirth = dateOfBirth;
  }
 }
 static void Main(){
  
 }
}
}



Console.Write("Name:");
 string name = Console.ReadLine();
Console.Write("Password:");
string lastname = Console.ReadLine();
Console.WriteLine("Hello {0} welcome to theBulb MicrofinanceBank. Here's your account no:10992783938", name);
//Console.WriteLine("Hello " +  name  + " welcome to theBulb MicrofinanceBank. Here's your account no:10992783938");

//2.if name and password is correct,view account balance
bool isName = true, isPassword = true;
if (isName && isPassword);
Console.WriteLine("Account Balance:$25,000");

bool isDetailsCorrect = true;
bool isAmount2000 = true;
if (isDetailsCorrect== isAmount2000) ;
Console.WriteLine("Successful");


