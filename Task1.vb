Module Module1

    Sub Main()
        Dim memID As Integer
        Dim memName As String
        Dim memAddress As String
        Dim memTelNo As String

        FileOpen(1, "C:/VB programs/memberdetails.txt", OpenMode.Output)
        For i = 1 To 5

            Console.WriteLine("Please enter member's ID")
            memID = Console.ReadLine
            WriteLine(1, memID)

            Console.WriteLine("Enter member's name")
            memName = Console.ReadLine
            WriteLine(1, memName)

            Console.WriteLine("Please enter the address of the member's residence")
            memAddress = Console.ReadLine
            WriteLine(1, memAddress)

            Console.WriteLine("Enter member's contact number")
            memTelNo = Console.ReadLine
            WriteLine(1, memTelNo)

        Next
        FileClose(1)
    End Sub

End Module
