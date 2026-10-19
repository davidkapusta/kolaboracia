void VytvorCisla()
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
 
List<int> CitajCisla(string text)
{
    List<int> cisla = new List<int>();
    string[] casti = text.Split(',');

    for (int i = 0; i < casti.Length; i++)
    {
        cisla.Add(int.Parse(casti[i]));
    }

    return cisla;
} 

void ProcesujCisla(List<int> cisla)
{
    double sucet = 0;
    for (int i = 0; i < cisla.Count; i++)
    {
        sucet = sucet + cisla[i];
    }
    double priemer = sucet / cisla.Count;

    cisla.Sort();

    int max = cisla[cisla.Count - 1];
    int median = cisla[cisla.Count / 2];

    PrintResults(priemer, median, max);
}

void PrintResults(double priemer, int median, int max)
{
    Console.WriteLine("--- DATOVA ANALYZA ---");
    Console.WriteLine("Priemer: " + priemer);
    Console.WriteLine("Median: " + median);
    Console.WriteLine("Maximum: " + max);
    Console.WriteLine("----------------------");
}








