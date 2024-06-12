Imports System

Module Module1
    Sub Main()
        Dim pocetCisel As Integer

        Do
            Console.WriteLine("Zadejte po�et ��sel:")
            Dim vstup As String = Console.ReadLine()
            If Integer.TryParse(vstup, pocetCisel) AndAlso pocetCisel > 0 Then
                Exit Do
            Else
                Console.WriteLine("Neplatn� vstup. Zadejte pros�m cel� kladn� ��slo.")
            End If
        Loop

        Dim cisla(pocetCisel - 1) As Integer
        For i As Integer = 0 To pocetCisel - 1
            Dim cislo As Integer

            Do
                Console.WriteLine("Zadejte kladn� ��slo " & (i + 1) & ":")
                Dim vstup As String = Console.ReadLine() AndAlso cislo > 0
                If Integer.TryParse(vstup, cislo) Then
                    cisla(i) = cislo
                    Exit Do
                Else
                    Console.WriteLine("Neplatn� vstup. Zadejte pros�m cel� a kladn� ��slo")
                End If




            Loop
        Next

        Console.WriteLine("Zadan� ��sla jsou:")
        For i As Integer = 0 To pocetCisel - 1
            Console.WriteLine(cisla(i))
        Next

        Console.WriteLine("Stiskn�te libovolnou kl�vesu pro ukon�en�.")
        Console.ReadKey()
    End Sub
End Module
