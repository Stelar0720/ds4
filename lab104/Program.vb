Public Module Program
    Public Sub Main(args() As String)
        Dim perrito As As Perro = New Perro()
        perrito.nombre = "Chico"
        perrito.raza = "Pastor Alemán"
        perrito.altura = "0.70m"

        Console.WriteLine(perrito.comer("Carne"))

        Dim perrito2 As Perro = New Perro()
        perrito2.nombre = "Lassy"

        Console.WriteLine(perrito2.comer("Pollo"))

        Dim perrito3 As Perro = New Perro("Peluchin", "Poodle", "0.5m")
        Console.WriteLine(perrito3.comer("Pan"))
    End Sub
End Module

