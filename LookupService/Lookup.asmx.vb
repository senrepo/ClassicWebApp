Imports System.ComponentModel
Imports System.Web.Services
Imports System.Web.Services.Protocols

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Lookup
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function HealthCheck() As String
        Return "Lookup Service is up and running."
    End Function

    <WebMethod()> 
    Public Function GetAllVehicleModel() As List(Of VehicleModel)
        Dim list As List(Of VehicleModel) = LoadAllVehicleModel()
        Return list
    End Function

    Private Function LoadAllVehicleModel() As List(Of VehicleModel)
        Dim list As List(Of VehicleModel) = New List(Of VehicleModel)

        list.Add(New VehicleModel(2015, "Toyota", "Camery"))
        list.Add(New VehicleModel(2015, "Honda", "Acord"))
        list.Add(New VehicleModel(2016, "Nissan", "Rogue"))

        Return list
    End Function

End Class