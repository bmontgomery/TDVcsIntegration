Imports SharpSvn

Public Class SubversionProvider
  Implements IVcsProvider

  Private mCommit As CommitInfo

  Public Function GetCommitInfo(ByVal username As String, ByVal password As String, ByVal repositoryUrl As String, ByVal revision As String) As CommitInfo Implements IVcsProvider.GetCommitInfo

    Using client As New SvnClient()
      client.Log(New System.Uri(repositoryUrl),
                 New SvnLogArgs(New SvnRevisionRange(revision, revision)),
                 New EventHandler(Of SvnLogEventArgs)(AddressOf LogEventHandler))

      Using diffStream As New IO.MemoryStream()
        If client.Diff(New SvnUriTarget(repositoryUrl), New SvnRevisionRange(revision, CInt(revision) - 1), diffStream) Then

          diffStream.Position = 0
          Using reader As New IO.StreamReader(diffStream)
            mCommit.Patch = reader.ReadToEnd()
          End Using

        End If
      End Using
    End Using

    Return mCommit

  End Function

  Private Sub LogEventHandler(ByVal sender As Object, ByVal args As SvnLogEventArgs)
    mCommit = New CommitInfo(args.Author, args.LogMessage)
  End Sub

End Class
