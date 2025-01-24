'Rudy Earnest
'Spring 2025
'RCET 2265
'VariablesAndDataTypesAndStuff
'https://github.com/rc-earnest/VariablesAndDataTypesAndStuff.git
Option Explicit On
Option Strict On
Module VariablesAndDataTypesAndStuff

    Sub Main()

        Dim jellyBeans As Integer
        Dim laffyTaffy As Integer
        Dim money As Decimal
        Dim studentName As String

        Console.WriteLine(jellyBeans)

        jellyBeans = 120
        Console.WriteLine(jellyBeans)

        jellyBeans = jellyBeans + 10
        Console.WriteLine(jellyBeans)

        jellyBeans += 10
        Console.WriteLine(jellyBeans)

        laffyTaffy = 26
        Console.WriteLine(laffyTaffy)

        money = 9.21837498812374D
        jellyBeans = CInt(1.56)
        studentName = "7"

        jellyBeans = CInt(studentName)
        Console.WriteLine()

        Dim userInput As String

        Console.WriteLine("Please enter a fruit.")
        userInput = Console.ReadLine()

        'Console.WriteLine(userInput & " That is a terrible fruit!")
        Console.WriteLine($"You entered: {userInput}!")
    End Sub

End Module
