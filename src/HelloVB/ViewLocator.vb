Imports Avalonia.Controls
Imports Avalonia.Controls.Templates
Imports HelloVB.ViewModels

Public Class ViewLocator
    Implements IDataTemplate

    Public ReadOnly Property SupportsRecycling As Boolean
        Get
            Return False
        End Get
    End Property


    Public Function Match(data As Object) As Boolean Implements IDataTemplate.Match
        Return TypeOf data Is ViewModelBase
    End Function


    Public Function Build(param As Object) As IControl Implements ITemplate(Of Object, IControl).Build

        Dim name = param.[GetType]().FullName.Replace("ViewModel", "View")
        Dim type As Type = Type.GetType(name)

        If type IsNot Nothing Then
            Return CType(Activator.CreateInstance(type), Control)
        Else
            Return New TextBlock With {
                    .Text = $"Not Found: {name}"
                }
        End If

    End Function
End Class
