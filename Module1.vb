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
        Dim lineCount = File.ReadAllLines("target").Length
        Dim path As String = "target"
        Dim sr As StreamReader = New StreamReader(path)
        For i = 0 To lineCount - 1
            Dim tsayi As BigInteger
            tsayi = BigInteger.Parse(sr.ReadLine())
            watch.Start()
            Dim veri = factorit(tsayi).ToString
            watch.Stop()
            My.Computer.FileSystem.WriteAllText("log", "Hedef : " & tsayi.ToString & vbCrLf & veri & watch.Elapsed.TotalMinutes & " saniyede bulundu" & vbCrLf, True)
            watch.Reset()
        Next
        Console.WriteLine("İşlemler bitti")
        Console.ReadLine()
    End Function
    Function factorit(number As BigInteger)
        Dim lineCount = File.ReadAllLines("primes").Length
        Dim path As String = "primes"
        Dim sr As StreamReader = New StreamReader(path)
        Dim v As BigInteger
        For i = 0 To lineCount - 1
            Dim line As String
            v = BigInteger.Parse(sr.ReadLine())
            Dim k As BigInteger
            k = BigInteger.Divide(number, v)
            If (BigInteger.Multiply(k, v) = number) = True Then
                Return ("p : " & k.ToString & vbCrLf & "q : " & v.ToString & vbCrLf)
                i = 0
            End If
        Next
        Reset()

    End Function
End Module
