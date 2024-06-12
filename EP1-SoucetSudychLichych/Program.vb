Imports System

Module Module1
    Sub Main()
        Dim pocetCisel As Integer

        Do
            Console.WriteLine("Zadejte poèet èísel:")
            Dim vstup As String = Console.ReadLine()
            If Integer.TryParse(vstup, pocetCisel) AndAlso pocetCisel > 0 Then
                Exit Do
            Else
                Console.WriteLine("Neplatný vstup. Zadejte prosím celé kladné èíslo.")
            End If
        Loop

        Dim cisla(pocetCisel - 1) As Integer
        For i As Integer = 0 To pocetCisel - 1
            Dim cislo As Integer

            Do
                Console.WriteLine("Zadejte kladné èíslo " & (i + 1) & ":")
                Dim vstup As String = Console.ReadLine() AndAlso cislo > 0
                If Integer.TryParse(vstup, cislo) Then
                    cisla(i) = cislo
                    Exit Do
                Else
                    Console.WriteLine("Neplatný vstup. Zadejte prosím celé a kladné èíslo")
                End If




            Loop
        Next

        Console.WriteLine("Zadaná èísla jsou:")
        For i As Integer = 0 To pocetCisel - 1
            Console.WriteLine(cisla(i))
        Next

        Console.WriteLine("Stisknìte libovolnou klávesu pro ukonèení.")
        Console.ReadKey()
    End Sub
End Module
