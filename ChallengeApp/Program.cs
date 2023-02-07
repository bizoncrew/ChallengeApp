int number = 122666;
var numberAsString = number.ToString();     //zamiana liczby na tekst
char[] digit = numberAsString.ToArray();    //rozbicie tekstu na pojedyńcze elementy

Console.WriteLine($"Cyfry z liczby {number} występują w następującej ilości:");

List<char> column1 = new List<char>();      //lista cyfr do porównania
column1.Add('0');
column1.Add('1');
column1.Add('2');
column1.Add('3');
column1.Add('4');
column1.Add('5');
column1.Add('6');
column1.Add('7');
column1.Add('8');
column1.Add('9');

foreach (var element in column1)        //pętla elementów z listy column1
{
    int column2 = 0;                    //zmienna początkowa do kolumny drugiej
    foreach (var character in digit)    //pętla elementów z tablicy char digit
    {
        if (element == character)       //jeżeli  element z listy tworzącej pierwszą pętlę = elementowi z tablicy char
            column2++;                  //powiększ o 1 zmienną początkową z kolumny drugiej
    }
    Console.WriteLine(element + " => " + column2);
}