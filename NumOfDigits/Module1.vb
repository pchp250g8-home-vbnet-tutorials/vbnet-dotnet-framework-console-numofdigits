Module Module1

    Sub Main()
        Console.WriteLine("Input an Integer Number:")
        Dim strNum = Console.ReadLine()
        Dim iNum As Long = 0
        Int64.TryParse(strNum, iNum)
        Dim nDigits = 0 : Dim iVal = Math.Abs(iNum)
        Do While (iVal > 0)
            iVal \= 10
            nDigits += 1
        Loop
        Console.WriteLine("The number {0} has {1} digit(s)", iNum, nDigits)
        Console.Read()
    End Sub

End Module
