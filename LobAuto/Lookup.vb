
Public Class Lookup
    Public Shared Function GetVehicleModelList() As List(Of LookupService.VehicleModel)
        Dim lookupService As LookupService.Lookup = New LookupService.Lookup
        lookupService.Url = "https://localhost:44362/Lookup.asmx"
        Dim result As List(Of LookupService.VehicleModel) = lookupService.GetAllVehicleModel()
        Return result
    End Function

End Class

