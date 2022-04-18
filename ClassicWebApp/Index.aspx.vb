Imports LobAuto
Imports LobAuto.Lookup

Public Class Index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim vehcileModelList As List(Of LookupService.VehicleModel) = GetVehicleModelList()
        lblASXMServiceStatus.Text = "Lookup ASMX Service called and returned " + vehcileModelList.Count.ToString + " Items successfully."
    End Sub

End Class