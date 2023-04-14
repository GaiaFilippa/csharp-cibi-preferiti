/* Create un progetto App Console CibiPreferiti con Visual Studio.
 * Inizializza un array con la classifica dei miei cibi preferiti (minimo 5, massimo 10 elementi). HARD-CODED
 * L’array deve essere già inizializzato nel programma ordinato già con i cibi dal più preferito al meno preferito.
 * 
 * Stampa a video le seguenti informazioni:
 * La lunghezza della classifica
 * La classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
 * Il mio cibo top (prima posizione della classifica)
 * Il mio cibo preferito ma non troppo (ultima posizione della classifica)
 */


// MAIN ----------------------------------------------------------

string[] arrayMyFavoriteFood = { "Polenta", "Risotto", "Pizza", "Bunet", "Ravioli al vapore", "Fonduta"};

Console.WriteLine("La lunghezza della classifica è: " + getArrayLenght(arrayMyFavoriteFood));

Console.WriteLine();

Console.WriteLine("La mia classifica dei cibi preferiti è: ");
printArrayString(arrayMyFavoriteFood);

Console.WriteLine();

Console.Write("Il mio cibo top è: ");
getFirstFavFood(arrayMyFavoriteFood);



// FUNZIONI ------------------------------------------------------

int getArrayLenght(string[] arrayString)
{
    return arrayString.Length;
}

void printArrayString(string[] arrayString)
{
    for (int i = 0; i < arrayString.Length; i++)
    {
        Console.WriteLine((i + 1) + "° " + arrayString[i]);
    }
}

void getFirstFavFood(string[] firstFood) {
    for (int i = 0; i < firstFood.Length; i++)
    {
        if (i == 0) {
            Console.WriteLine();
        }
    }
    
}