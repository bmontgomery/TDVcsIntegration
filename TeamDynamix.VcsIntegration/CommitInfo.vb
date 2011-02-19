Public Class CommitInfo
  Public Property User As String
  Public Property Message As String

  Public Sub New()
  End Sub

  Public Sub New(ByVal user As String, ByVal message As String)
    Me.User = user
    Me.Message = message
  End Sub

End Class
