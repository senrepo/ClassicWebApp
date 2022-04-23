Imports System.ServiceModel
Imports DmvWCFServiceContract
Imports Newtonsoft.Json

Public Class DmvDriver
    Public Shared Function GetDriverDetails(ByVal licenseNo As String) As String
        Dim binding As BasicHttpBinding = New BasicHttpBinding
        Dim endpoint As EndpointAddress = New EndpointAddress("http://localhost:56912/DriverService.svc")
        Dim channelFactory As ChannelFactory(Of IDriverService) = New ChannelFactory(Of IDriverService)(binding, endpoint)

        Dim service As IDriverService = channelFactory.CreateChannel()

        Dim driver As Driver = New Driver()
        driver.LicenseNo = "12345"

        driver = service.GetDriverDetails(driver)

        Return JsonConvert.SerializeObject(driver)

    End Function
End Class
