Imports LobAuto
Imports LobAuto.Lookup
Imports LobAuto.DmvDriver

Public Class Index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim vehcileModelList As List(Of LookupService.VehicleModel) = GetVehicleModelList()
        lblASXMServiceStatus.Text = "Lookup ASMX Service called and returned " + vehcileModelList.Count.ToString + " Items successfully."

        Dim dmvDriverDetails As String = GetDriverDetails("12345")
        lblWCFServiceStatus.Text = "DmvDriver WCF Service called and returned " + dmvDriverDetails + " successfully."

    End Sub

End Class