Public Class VehicleModel
    Public Year As Integer
    Public Make As String
    Public Model As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal year As Integer, ByVal make As String, ByVal model As String)
        Me.Year = year
        Me.Make = make
        Me.Model = model
    End Sub

End Class
