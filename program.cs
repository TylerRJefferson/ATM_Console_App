using System;
public class cardHolder
{
  String cardNum;
  int pin;
  String firstName;
  String lastName;
  double balance;

  public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
  {
    this.cardNum = cardNum;
    this.pin = pin;
    this.firstName = firstName;
    this.lastName = lastName;
    this.balance = balance;
  }

  public String getNum()
  {
    return cardNum;
  }

  public int getPin()
  {
    return pin;
  }

  public String getFirstName()
  {
    return firstName;
  }

  public String getLastName()
  {
    return lastName;
  }

  public double getBalance()
  {
    return balance;
  }

  public void setNum(String newCardNum)
  {
    cardNum = newCardNum;
  }

  public void setPin(int newPin)
  {
    pin = newPin;
  }

  public void setFirstName(String newFirstName)
  {
    firstName = newFirstName;
  }

  public void setLastName(String newLastName)
  {
    lastName = newLastName;
  }

  public void setBalance(double newBalance)
  {
    balance = newBalance;
  }

  public static void Main(String[] args)
  {
    void printOptions()
    {
      Console.WriteLine("Please choose from one of the following options...");
      Console.WriteLine("1. Deposit");
      Console.WriteLine("2. Withdraw");
      Console.WriteLine("3. Show Balance");
      Console.WriteLine("4. Exit");
    }

    void deposit(cardHolder currentUser)
    {
      Console.WriteLine("How much $$ would you like to deposit:");
      double deposit = Double.Parse(Console.ReadLine());
      currentUser.setBalance(deposit + currentBalance);
      Console.WriteLine("Thank you for your deposit. Your new balance is: " + currentUser.getBalance());
    }

    void withdraw(cardHolder currentUser)
    {
      Console.WriteLine("How much $$ would you like to withdraw:");
      double withdrawal = Double.Parse(Console.ReadLine());
      if(currentUser.getBalance() > withdrawal)
      {
        Console.WriteLine("Insufficient balance");
      }
      else
      {
        currentUser.setBalance(currentUser.getBalance() - withdrawal);
        Console.WriteLine("Thank you for banking with us!");
      }
    }

    void balance(cardHolder currentUser)
    {
      Console.WriteLine("Current balance: " + currentUser.getBalance());
    }

  }

}