Imports System

Module Module1

    Sub Main()

        Dim pocetCisel As Integer

        Console.WriteLine("Zadejte poèet èísel:")

        pocetCisel = Console.ReadLine()

        Dim cisla(pocetCisel - 1) As Integer

        For i As Integer = 0 To pocetCisel - 1

            Console.WriteLine("Zadejte èíslo " & (i + 1) & ":")

            cisla(i) = Console.ReadLine()

        Next

        Console.WriteLine("Zadaná èísla jsou:")

        For i As Integer = 0 To pocetCisel - 1

            Console.WriteLine(cisla(i))

        Next

        Console.WriteLine("Stisknìte libovolnou klávesu pro ukonèení.")

        Console.ReadKey()

    End Sub

End Module
