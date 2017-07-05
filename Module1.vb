Imports System.IO
Imports System.Numerics
Module Module1
    Sub Main()
        Console.ForegroundColor = ConsoleColor.DarkRed
        Console.WriteLine("
___  ___    ______ ___  _____ _____ ___________ 
|  \/  |    |  ___/ _ \/  __ \_   _|  _  | ___ \
| .  . |_ __| |_ / /_\ \ /  \/ | | | | | | |_/ /
| |\/| | '__|  _||  _  | |     | | | | | |    / 
| |  | | |_ | |  | | | | \__/\ | | \ \_/ / |\ \ 
\_|  |_/_(_)\_|  \_| |_/\____/ \_/  \___/\_| \_|
                                                
                                                ")
        Console.ResetColor()
        maina()
    End Sub
    Function maina()
        Dim watch As Stopwatch = Stopwatch.StartNew()
        Console.WriteLine("Sayı giriniz : ")
        Dim sayi As BigInteger
        sayi = Console.ReadLine
        watch.Start()
        Console.WriteLine(factorit(sayi))
        watch.Stop()
        Console.WriteLine(watch.Elapsed.TotalMinutes & " saniyede bulundu" & vbNewLine)
        watch.Reset()
        maina()
    End Function
    Function factorit(number As BigInteger)
        Dim lineCount = File.ReadAllLines("primes1.txt").Length
        Dim path As String = "primes1.txt"
        Dim sr As StreamReader = New StreamReader(path)
        Dim v As BigInteger
        For i = 0 To lineCount - 1
            Dim line As String
            v = Convert.ToInt32(sr.ReadLine())
            Dim k As BigInteger
            k = (number / v)
            If ((k * v) = number) = True Then
                Return (k.ToString & " " & v.ToString)
                i = 0
            End If
        Next
        Reset()
    End Function
End Module
