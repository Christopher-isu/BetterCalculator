'ChristopherZ
'Spring 2025
'RCET2265
'Better Calculator
'https://github.com/Christopher-isu/BetterCalculator.git

Option Explicit On 'forces all variables to be declared

Module BetterCalculator

    Function enterNumber() As Integer
        Dim number As Integer
        Dim input As String
        Do
            Console.WriteLine("Choose a Number:")
            input = Console.ReadLine()

            If input.ToUpper() = "Q" Then
                Console.WriteLine("You entered " & number)
                Console.WriteLine("Have a nice day")
                Environment.Exit(0)
            End If

            Try
                number = CInt(input)
            Catch ex As Exception
                Console.WriteLine($"You entered ""{input}"", please enter a whole number.")
            End Try
        Loop Until IsNumeric(input)

        Console.WriteLine("You entered " & number)
        Return number
    End Function

    Function selectOperation() As Integer
        Dim operation As Integer
        Dim input As String
        Do
            Console.WriteLine("Choose one of the following options:")
            Console.WriteLine("1. Add")
            Console.WriteLine("2. Subtract")
            Console.WriteLine("3. Multiply")
            Console.WriteLine("4. Divide")
            input = Console.ReadLine()

            If input.ToUpper() = "Q" Then
                Console.WriteLine("You entered " & input)
                Console.WriteLine("Have a nice day")
                Environment.Exit(0)
            End If

            Try
                operation = CInt(input)
            Catch ex As Exception
                Console.WriteLine($"You entered ""{input}"", please enter a whole number.")
            End Try
        Loop Until operation >= 1 And operation <= 4

        Return operation
    End Function

    Sub Main()
        Do
            Console.WriteLine("Please enter two numbers. Enter 'Q' at any time to quit")

            Dim result As Double
            Dim num1 As Integer = enterNumber()
            Dim operation As Integer = selectOperation()
            Dim num2 As Integer = enterNumber()

            Select Case operation
                Case 1
                    result = (num1) + (num2)
                    Console.WriteLine($"{num1} + {num2} = {result}")
                Case 2
                    result = (num1) - (num2)
                    Console.WriteLine($"{num1} - {num2} = {result}")
                Case 3
                    result = (num1) * (num2)
                    Console.WriteLine($"{num1} * {num2} = {result}")
                Case 4
                    result = (num1) / (num2)
                    Console.WriteLine($"{num1} / {num2} = {result}")
            End Select

        Loop Until False
    End Sub

End Module
