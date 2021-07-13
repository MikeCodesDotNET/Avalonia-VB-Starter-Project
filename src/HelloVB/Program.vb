Imports Avalonia
Imports Avalonia.ReactiveUI

Class Program
    Public Shared Sub Main(ByVal args As String())
        BuildAvaloniaApp().StartWithClassicDesktopLifetime(args)
    End Sub

    Public Shared Function BuildAvaloniaApp() As AppBuilder
        Return AppBuilder.Configure(Of App)().UsePlatformDetect().LogToTrace().UseReactiveUI()
    End Function
End Class
