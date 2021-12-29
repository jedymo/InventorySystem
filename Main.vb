Module Main

    Sub Main()
        Dim password = Encryption.HashString("123456")
        Dim salt = Encryption.GenerateSalt
        Dim hashedAndSalted = Encryption.HashString($"{password}{salt}")

        Console.WriteLine(password)
        Console.WriteLine(salt)
        Console.WriteLine(hashedAndSalted)

        Console.ReadKey()

    End Sub

End Module