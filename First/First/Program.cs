
bool CzyLiczbaUjemna(string value, out int liczba)
{
    
    liczba = int.Parse(value);
    return liczba < 0;
}
string slowo = "10";
int liczba;

if (CzyLiczbaUjemna(slowo, out liczba))

    Console.WriteLine("liczba jest ujmna i wynosi " + liczba);

else
    Console.WriteLine("liczba nie jest ujmna i wynosi " + liczba);