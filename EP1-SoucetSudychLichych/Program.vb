Imports System

Module Module1

    Sub Main()

        Dim pocetCisel As Integer

        Console.WriteLine("Zadejte po�et ��sel:")

        pocetCisel = Console.ReadLine()

        Dim cisla(pocetCisel - 1) As Integer

        For i As Integer = 0 To pocetCisel - 1

            Console.WriteLine("Zadejte ��slo " & (i + 1) & ":")

            cisla(i) = Console.ReadLine()

        Next

        Console.WriteLine("Zadan� ��sla jsou:")

        For i As Integer = 0 To pocetCisel - 1

            Console.WriteLine(cisla(i))

        Next

        Console.WriteLine("Stiskn�te libovolnou kl�vesu pro ukon�en�.")

        Console.ReadKey()

    End Sub

End Module
