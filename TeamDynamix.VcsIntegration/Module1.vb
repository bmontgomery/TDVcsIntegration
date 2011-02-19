Module Module1

  Private mRepositoryUrl As String
  Private mRevision As String
  Private mVcsUserName As String
  Private mVcsPassword As String
  Private mCommit As CommitInfo

  Sub Main()

    Try

      ParseCommandLineArgs()
      GetCommitInfo()

      If CommitPertainsToTicket() Then
        AddCommentToTicket()
      End If

    Catch ex As Exception
      Console.WriteLine(ex.Message)
    End Try
    
  End Sub

  Private Sub ParseCommandLineArgs()

    'first command line argument we expect to be the repository url
    Dim args As String() = Environment.GetCommandLineArgs()

    If args.Length < 3 Then Throw New ApplicationException("invalid arguments")

    mRepositoryUrl = args(1)
    mRevision = args(2)

  End Sub

  Private Sub GetCommitInfo()

    Dim vcs As IVcsProvider = GetVcsProvider()

    If vcs Is Nothing Then Throw New ApplicationException("VCS provider not configured")

    GetVcsProxyUserInfo()
    mCommit = vcs.GetCommitInfo(mVcsUserName, mVcsPassword, mRevision)

    If mCommit Is Nothing Then Throw New ApplicationException("could not load commit data")

  End Sub

  Private Function GetVcsProvider()
    'TODO: implement DI logic here
  End Function

  Private Sub GetVcsProxyUserInfo()

    mVcsUserName = Configuration.ConfigurationManager.AppSettings("VcsUser")
    mVcsPassword = Configuration.ConfigurationManager.AppSettings("VcsPassword")

    If String.IsNullOrEmpty(mVcsUserName) Or String.IsNullOrEmpty(mVcsPassword) Then Throw New ApplicationException("invalid VCS proxy user configuration")

  End Sub

  Private Function CommitPertainsToTicket() As Boolean
    'TODO: implement logic here
    Return False
  End Function

  Private Sub AddCommentToTicket()
    'TODO: implement
  End Sub

End Module
