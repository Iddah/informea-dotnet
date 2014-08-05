Imports System.Data.Services
Imports System.Data.Services.Common
Imports System.Linq
Imports System.ServiceModel.Web
Imports System.Data.Services.Providers

Public Class informea
    Inherits EntityFrameworkDataService(Of InformeaEntities)

    Public Shared Sub InitializeService(ByVal config As DataServiceConfiguration)
        config.SetEntitySetAccessRule("*", EntitySetRights.AllRead)
        config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3
        config.SetEntitySetPageSize("*", 200)
        config.UseVerboseErrors = True

    End Sub

End Class
