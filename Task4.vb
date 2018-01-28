Module Module1

    Sub Main()
        Dim memID As Integer
        Dim memName, memAddress, memTelNo As String

        Dim i As Integer = 1
        FileOpen(1, "C:/VB programs/memberdetails.txt", OpenMode.Append)

        While i = 1

            Console.WriteLine("enter memid")
            memID = Console.ReadLine
            WriteLine(1, memID)

            Console.WriteLine("enter mebers name")
            memName = Console.ReadLine
            WriteLine(1, memName)

            Console.WriteLine("Enter member's address")
            memAddress = Console.ReadLine
            WriteLine(1, memAddress)

            Console.WriteLine("enter me tel no")
            memTelNo = Console.ReadLine
            WriteLine(1, memTelNo)

            Console.WriteLine("Do you want to add more records? If yes then press 1 else press any other digit")
            i = Console.ReadLine

        End While

        FileClose(1)
    End Sub

End Module
