Imports ParameterModifiers

Module Module1

    Sub Main()
        Dim f1 As Foo = New Foo With {.N = 1}
        Console.WriteLine($"Pre: {f1}")
        Program.TestInOnly(f1)
        Console.WriteLine($"Post: {f1}")

        'Dim f2 As Foo = New Foo With {.N = 2}
        'Console.WriteLine($"Pre: {f2}")
        'Program.TestInOut(ref f2)
        'Console.WriteLine($"Post: {f2}")

        'Dim f3 As Foo = New Foo With {.N = 3}
        'Console.WriteLine($"Pre: {f3}")
        'Program.TestOutOnly(out f3)
        'Console.WriteLine($"Post: {f3}")

        Dim f4 As Foo = New Foo With {.N = 4}
        Console.WriteLine($"Pre: {f4}")
        TestByVal(f4)
        Console.WriteLine($"Post: {f4}")

        Dim f5 As Foo = New Foo With {.N = 5}
        Console.WriteLine($"Pre: {f5}")
        TestByRef(f5)
        Console.WriteLine($"Post: {f5}")

        Dim f6 As Foo = New Foo With {.N = 6}
        Console.WriteLine($"Pre: {f6}")
        TestByValFieldChange(f6)
        Console.WriteLine($"Post: {f6}")

        Dim f7 As Foo = New Foo With {.N = 7}
        Console.WriteLine($"Pre: {f7}")
        TestByRefFieldChange(f7)
        Console.WriteLine($"Post: {f7}")

    End Sub

    Sub TestByVal(ByVal f As Foo)
        f = New Foo With {.N = 400}
    End Sub

    Sub TestByRef(ByRef f As Foo)
        f = New Foo With {.N = 500}
    End Sub
    Sub TestByValFieldChange(ByVal f As Foo)
        f.N = 600
    End Sub
    Sub TestByRefFieldChange(ByRef f As Foo)
        f.N = 700
    End Sub
End Module
