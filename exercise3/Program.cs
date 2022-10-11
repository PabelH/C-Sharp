Data myData = new Data("Pabel Hernandez", 6143552795, "Vista Sierra Azul", "pabel_h@hotmail.com", true);

Console.Writeline(myData.fullName);






public struct Data
{

    public Data(string n, int ph, string ad, string em, bool nC)
    {
      fullName = n;
      phone = ph;
      address = ad;
      email = em;
      newClient = nC;
    }

    public string fullName { get; set; }
    public int phone { get; set; }
    public string address { get; set; }
    public string email { get; set; }
    public bool newClient { get; set; }

    public override string ToString() => $"({phone}, {newClient})";

}