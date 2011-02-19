Public Interface IVcsProvider
  Function GetCommitInfo(ByVal username As String, ByVal password As String, ByVal revision As String) As CommitInfo
End Interface
