Module Module1

    Sub Main()
        Dim memID, srchmemID As Integer
        Dim memName, memAddress, memTelNo As String

        Console.WriteLine("Enter member ID to search for")

        srchmemID = Console.ReadLine
        FileOpen(1, "C:/VB programs/memberdetails.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, memID)
            Input(1, memName)
            Input(1, memAddress)
            Input(1, memTelNo)

            If srchmemID = memID Then
                Console.WriteLine("Member ID found")
                Console.WriteLine(memID)
                Console.WriteLine(memName)
                Console.WriteLine(memAddress)
                Console.WriteLine(memTelNo)
            Else : Console.WriteLine("notfound")
            End If
        End While

        FileClose(1)
        Console.ReadKey()
    End Sub

End Module
