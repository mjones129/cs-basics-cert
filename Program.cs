string[] orderIDs = new string[] { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine($"This order starts with \"B\": {orderID}");
    }
}