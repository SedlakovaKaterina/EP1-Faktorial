﻿Imports System


Sub Main(args As String())
    Dim cislo As Integer
    Dim soucet As Integer = 0

    Console.Write("Zadej èíslo: ")
    cislo = Console.ReadLine
    If cislo <= 0 Then
        Console.Write("Chyba vstupu")
        End
    End If

    If cislo > 10 Then
        Console.WriteLine("musi byt mensi nez deset")
        Console.ReadKey()
        End

    End If
    If Not IsNumeric(cislo) Then
        Console.WriteLine("neni to cislo")
        Console.ReadKey()
        End
    End If
    For i = 1 To cislo
        soucet = soucet + i
    Next

    Console.WriteLine($"Souèet od 1 do {cislo} je {soucet}")


