using System.IO;
using System;

// Create a Stock class
class Stock
{
  public string Name, Symbol;  // Create the required fields
  double previousClosingPrice, currentPrice;


  public Stock(String Name, String Symbol)  //A constructor method to create a stock with user-specified name and symbol.
  {
    this.Name = Name; // Set the  value for Name to user defined value
    this.Symbol = Symbol; // Set the  value for Symbol to user defined value
  }
  
  public String getName() //Method getName() that returns the stock’s name.
  {
      return this.Name;
  }
  
   public String getSymbol() //Method getSymbol() that returns the stock’s symbol.
  {
      return this.Symbol;
  }
  
  public void setClosingPrice(double previousClosingPrice)//Method setClosingPrice() that sets the previous closing price.
  {
      this.previousClosingPrice = previousClosingPrice;
  }
  
    public void setCurrentPrice(double currentPrice) //Method setCurrentPrice() that sets the current price.
  {
      this.currentPrice = currentPrice;
  }
  
  public double getChangePercent(double currentPrice, double previousClosingPrice) //Method getChangePercent() that returns the percentage changed from previousClosingPrice to currentPrice.
  {
      return ((currentPrice - previousClosingPrice)/ currentPrice * 100);
  }
  
  public void DisplayStock() // this method is called to display the info for the particular company
  {
    Console.WriteLine("\n" + Name + " Stock: ");
    Console.WriteLine("\tSymbol: " + Symbol);
    Console.WriteLine("\tClosing Price: " + this.previousClosingPrice);
    Console.WriteLine("\tCurrent Price: " + this.currentPrice);
    Console.WriteLine("\tChange Percent: " + getChangePercent(currentPrice, previousClosingPrice));
    Console.WriteLine("\t" + Name + " stock closing price is $" + currentPrice);
      
  }
  static void Main(string[] args)
  {
    Stock Google = new Stock("Google", "GOG");  // Create an object of the Stock Class for GOOGLE(this will call the constructor)
    Google.setClosingPrice(134.67); //set the closing price for google
    Google.setCurrentPrice(131.98); //set the current price for google
    Google.DisplayStock(); //display the stock info
    
    
    Stock Microsoft = new Stock("Microsoft", "MSF");  // Create an object of the Stock Class for MICROSOFT(this will call the constructor)
    Microsoft.setClosingPrice(156.52);
    Microsoft.setCurrentPrice(161.22);
    Microsoft.DisplayStock();
  }
}
