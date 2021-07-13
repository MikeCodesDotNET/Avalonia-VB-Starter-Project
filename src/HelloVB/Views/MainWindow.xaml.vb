Imports Avalonia
Imports Avalonia.Controls
Imports Avalonia.Markup.Xaml

Namespace Views
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            AvaloniaXamlLoader.Load(Me)
        End Sub
    End Class
End Namespace