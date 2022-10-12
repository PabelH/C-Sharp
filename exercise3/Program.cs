Data myData = new("Pabel Hernandez", 6143552795, "Vista Sierra Azul", "pabel_h@hotmail.com", true);

Console.WriteLine("Full Name: " + myData.fullName);
Console.WriteLine("Cell Phone: " + myData.phone);
Console.WriteLine("Address: " + myData.address);
Console.WriteLine("Email: " + myData.email);
Console.WriteLine("new customer?: " + myData.newClient);
public struct Data
{

    public Data(string n, long ph, string ad, string em, bool nC)
    {
      fullName = n;
      phone = ph;
      address = ad;
      email = em;
      newClient = nC;
    }

    public string fullName { get; set; }
    public long phone { get; set; }
    public string address { get; set; }
    public string email { get; set; }
    public bool newClient { get; set; }

    public override string ToString() => $"({phone}, {newClient})";

}