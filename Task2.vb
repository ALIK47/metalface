Module Module1

    Sub Main()
        Dim memID As Integer
        Dim memName As String
        Dim memAddress As String
        Dim memTelNo As String


        FileOpen(1, "C:/VB programs/memberdetails.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, memID)
            Input(1, memName)
            Input(1, memAddress)
            Input(1, memTelNo)

            Console.WriteLine("Member's ID number is " & memID)
            Console.WriteLine("Member's name is " & memName)
            Console.WriteLine("Member's address is " & memAddress)
            Console.WriteLine("Member's telephone number " & memTelNo)
            Console.ReadKey()
        End While
        FileClose(1)


    End Sub

End Module
