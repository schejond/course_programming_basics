namespace Homework
using System;

class Program
{
    // 1. Funkce na seřazení kolekce čísel do vzestupného pořadí
    static int[] SortArray(int[] arr)
    {
        if (arr == null) return null;
        if (arr.Length == 0) return arr;

        Array.Sort(arr);
        return arr;
    }

    // 2. Funkce pro obrácení pořadí elementů v poli
    static int[] ReverseArray(int[] arr)
    {
        if (arr == null) return null;
        if (arr.Length == 0) return arr;

        Array.Reverse(arr);
        return arr;
    }

    // 3. Funkce, která odebere první element v poli
    static int[] RemoveFirst(int[] arr)
    {
        if (arr == null || arr.Length == 0) return arr;

        int[] newArr = new int[arr.Length - 1];
        Array.Copy(arr, 1, newArr, 0, newArr.Length);
        return newArr;
    }

    // 4. Funkce, která odebere poslední element v poli
    static int[] RemoveLast(int[] arr)
    {
        if (arr == null || arr.Length == 0) return arr;

        int[] newArr = new int[arr.Length - 1];
        Array.Copy(arr, 0, newArr, 0, newArr.Length);
        return newArr;
    }

    // 5. Funkce, která odebere element na daném indexu z pole
    static int[] RemoveAtIndex(int[] arr, int index)
    {
        if (arr == null || arr.Length == 0 || index < 0 || index >= arr.Length) return arr;

        int[] newArr = new int[arr.Length - 1];
        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            if (i == index) continue;
            newArr[j++] = arr[i];
        }
        return newArr;
    }

    // 6. Funkce, která vloží element na začátek pole
    static int[] InsertAtStart(int[] arr)
    {
        if (arr == null) return new int[] { 0 };
        if (arr.Length == 0) return new int[] { 0 };

        int[] newArr = new int[arr.Length + 1];
        newArr[0] = 0;
        Array.Copy(arr, 0, newArr, 1, arr.Length);
        return newArr;
    }

    // 7. Funkce, která vloží element na konec pole
    static int[] InsertAtEnd(int[] arr)
    {
        if (arr == null) return new int[] { 0 };
        if (arr.Length == 0) return new int[] { 0 };

        int[] newArr = new int[arr.Length + 1];
        Array.Copy(arr, newArr, arr.Length);
        newArr[arr.Length] = 0;
        return newArr;
    }

    // 8. Funkce, která přidá element na daný indexu do pole
    static int[] InsertAtIndex(int[] arr, int index)
    {
        if (arr == null || index < 0 || index > arr.Length) return new int[] { 0 };

        int[] newArr = new int[arr.Length + 1];
        for (int i = 0; i < index; i++)
        {
            newArr[i] = arr[i];
        }
        newArr[index] = 0;
        for (int i = index; i < arr.Length; i++)
        {
            newArr[i + 1] = arr[i];
        }
        return newArr;
    }

    static void Main(string[] args)
    {
        int[] arr = { 5, 4, 3, 2, 1 };

        // Ukázky použití funkcí
        PrintArray(SortArray(arr)); // Seřadí
        PrintArray(ReverseArray(arr)); // Obrátí
        PrintArray(RemoveFirst(arr)); // Odebere první
        PrintArray(RemoveLast(arr)); // Odebere poslední
        PrintArray(RemoveAtIndex(arr, 2)); // Odebere prvek na indexu
        PrintArray(InsertAtStart(arr)); // Vloží na začátek
        PrintArray(InsertAtEnd(arr)); // Vloží na konec
        PrintArray(InsertAtIndex(arr, 2)); // Vloží na daný index
    }

    // Funkce pro tisk pole
    static void PrintArray(int[] arr)
    {
        if (arr == null)
        {
            Console.WriteLine("null");
        }
        else if (arr.Length == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine("{" + string.Join(", ", arr) + "}");
        }
    }
}
