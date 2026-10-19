void CreateNumbers()
{
    string text = "";
    for (int i = 1; i <= 10000; i++)
    {
        text = text + i;
        if (i < 10000)
        {
            text = text + ",";
        }
    }

    Console.WriteLine("Cisla su vytvorene");
}
 
List<int> ReadNumbers(string text)
{
    List<int> cisla = new List<int>();
    string[] casti = text.Split(',');

    for (int i = 0; i < casti.Length; i++)
    {
        cisla.Add(int.Parse(casti[i]));
    }

    return cisla;
}










