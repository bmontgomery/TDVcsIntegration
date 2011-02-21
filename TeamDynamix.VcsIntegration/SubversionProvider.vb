Imports SharpSvn

'I had to change the VisualSVN subversion server to use my administrator account, or this kept giving me errors about
'and untrusted certificate issuer

Public Class SubversionProvider
  Implements IVcsProvider

  Private mCommit As CommitInfo

  Public Function GetCommitInfo(ByVal username As String, ByVal password As String, ByVal repositoryUrl As String, ByVal revision As String) As CommitInfo Implements IVcsProvider.GetCommitInfo

    Using client As New SvnClient()
      client.Log(New System.Uri(repositoryUrl),
                 New SvnLogArgs(New SvnRevisionRange(revision, revision)),
                 New EventHandler(Of SvnLogEventArgs)(AddressOf LogEventHandler))
    End Using

    Return mCommit

  End Function

  Private Sub LogEventHandler(ByVal sender As Object, ByVal args As SvnLogEventArgs)
    mCommit = New CommitInfo(args.Author, args.LogMessage)
  End Sub

End Class
