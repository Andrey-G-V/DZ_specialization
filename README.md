# Описание решения домашнего задания к лекци "Выбор специализации"

## Задание:

Написать программуб которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
___

## Обявляем массив строк.
    stringArrey["abc1", "bce", "ce222", "ed", "0dfg"]
___

## Объявляем переменную храняшую значение длинны искомых строк в массиве.
     symbols = 3

___
## Метод ScanArray принимает массив строк и переменную - длинна строки. Возврошает количество строк в массиве заданной длинны.
    int ScanArray(string[] stringArrey, int symbols)

    return count;
___

## Метод NewArrey принимает значение длинны массива. Возврошает новый пустой строковый массив.
    string[] NewArrey(int count)

    return newArrey;
____

## Метод FillArrey примает исходный строковый массив, новый пустой строковый массив и переменную - количество символов в строке. Возврашает новый массив, заполненый строками заданной длинны. 
    string[] FillArrey(string[] stringArrey, string[] newArrey, int symbols)

    return newArrey;
___
## Метод PrintArrey принимает строковый массив и выводит его значения в консоль.

    void PrintArrey(string[] arrey)

    [ ]
____

## Переменная arrey принимает новый строковый массив, длинна которого равна количеству найденых строк, заданной длинны (symbols) в исходном массиве (stringArrey). 

    string[] arrey = NewArrey(ScanArray(stringArrey, symbols));
___

## Если исходный массив не содержит строк заданной длинны, то выводим пустой новый массив или заполняем новый массив найдеными строками и выводим его.
    if (arrey.Length == 0)
    {
        PrintArrey(arrey);
    }
    else
    {
        PrintArrey(FillArrey(stringArrey, arrey, symbols));
    }
___