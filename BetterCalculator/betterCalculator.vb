'ChristopherZ
'Spring 2025
'RCET2265
'Operators Example
'https://github.com/Christopher-isu/SayMyName.git

Option Explicit On 'forces all variables to be declared
Module betterCalculator
    Sub Main()
        ' Prompt user for the first number
        Console.WriteLine("This is a simple calculator example that can perform simple operations on two integers.")
        Console.WriteLine("Please enter the first number:")

        ' Save the frist number in a variable
        Dim firstNumber As Integer = Console.ReadLine()

        ' Prompt user for the first number
        Console.WriteLine("Enter the second number:")

        ' Save the second number in a variable
        Dim secondNumber As Integer = Console.ReadLine()

        ' Prompt user for the first number
        Console.WriteLine("Choose operation:")
        Console.WriteLine("1. Sum")
        Console.WriteLine("2. Product")

        ' Save the operation in a variable
        Dim operation As Integer = Console.ReadLine()

        Select Case operation
            Case 1
                Console.WriteLine("The sum is: " & (firstNumber + secondNumber))
            Case 2
                Console.WriteLine("The product is: " & (firstNumber * secondNumber))
            Case Else
                Console.WriteLine("Invalid operation.")
        End Select

        ' Keep console open untill button pressed
        Console.WriteLine("Press any key to exit.")
        Console.ReadKey()

    End Sub

End Module