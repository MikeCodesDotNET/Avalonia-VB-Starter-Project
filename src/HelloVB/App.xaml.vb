Imports Avalonia
Imports Avalonia.Controls.ApplicationLifetimes
Imports Avalonia.Markup.Xaml
Imports HelloVB.ViewModels
Imports HelloVB.Views

Public Class App
    Inherits Application

    Public Overrides Sub Initialize()
        AvaloniaXamlLoader.Load(Me)
    End Sub

    Public Overrides Sub OnFrameworkInitializationCompleted()

        If TypeOf ApplicationLifetime Is IClassicDesktopStyleApplicationLifetime Then

            Dim desktop As IClassicDesktopStyleApplicationLifetime = ApplicationLifetime

            desktop.MainWindow = New MainWindow With {
                    .DataContext = New MainWindowViewModel()
                }

        End If



        MyBase.OnFrameworkInitializationCompleted()
    End Sub

End Class
