﻿Module Module1

  Private mRepositoryUrl As String
  Private mRevision As String
  Private mVcsUserName As String
  Private mVcsPassword As String
  Private mTDProxyUser As String
  Private mTDProxyPassword As String
  Private mCommit As CommitInfo
  Private mTicketId As Int32
  Private Const cTicketMatchExp As String = "(?:ticket|bug)\s+(\d+)"
  Private Const cCommentFormat As String = "{0} committed revision {1} to {2} and said ""{3}"""

  Sub Main()

    Try

      ParseCommandLineArgs()
      GetCommitInfo()

      If CommitPertainsToTicket() Then
        AddCommentToTicket()
      End If

    Catch ex As Exception
      Console.WriteLine(ex.Message)
      System.IO.File.WriteAllText("tdvcs.log", ex.Message)
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

    GetVcsProxyUserInfo()
    mCommit = vcs.GetCommitInfo(mVcsUserName, mVcsPassword, mRepositoryUrl, mRevision)

    If mCommit Is Nothing Then Throw New ApplicationException("could not load commit data")

  End Sub

  Private Function GetVcsProvider()

    'TODO: implement DI logic here
    Dim vcsProvider As String = Configuration.ConfigurationManager.AppSettings("VcsProvider")
    If String.IsNullOrEmpty(vcsProvider) Then Throw New ApplicationException("VCS provider not configured")

    If String.Equals(vcsProvider, "Subversion", StringComparison.CurrentCultureIgnoreCase) Then
      Return New SubversionProvider()
    End If

    Return Nothing

  End Function

  Private Sub GetVcsProxyUserInfo()

    mVcsUserName = Configuration.ConfigurationManager.AppSettings("VcsUser")
    mVcsPassword = Configuration.ConfigurationManager.AppSettings("VcsPassword")

    If String.IsNullOrEmpty(mVcsUserName) Or String.IsNullOrEmpty(mVcsPassword) Then Throw New ApplicationException("invalid VCS proxy user configuration")

  End Sub

  Private Function CommitPertainsToTicket() As Boolean

    'run a regex to determine if it's a match
    Dim isMatch As Boolean = False
    Dim regEx As New Text.RegularExpressions.Regex(cTicketMatchExp)
    Dim match As Text.RegularExpressions.Match = regEx.Match(mCommit.Message)

    If match IsNot Nothing AndAlso match.Groups.Count > 1 Then
      mTicketId = match.Groups(1).Value
      isMatch = True
    End If

    Return isMatch

  End Function

  Private Sub GetTDProxyUserInfo()

    mTDProxyUser = Configuration.ConfigurationManager.AppSettings("TDProxyUser")
    mTDProxyPassword = Configuration.ConfigurationManager.AppSettings("TDProxyPassword")

    If String.IsNullOrEmpty(mTDProxyUser) Or String.IsNullOrEmpty(mTDProxyPassword) Then Throw New ApplicationException("invalid TeamDynamix proxy user configuration")

  End Sub

  Private Sub AddCommentToTicket()

    GetTDProxyUserInfo()

    Dim comment As String = String.Format(cCommentFormat, mCommit.User, mRevision, mRepositoryUrl, mCommit.Message)

    Dim ticketSvcClient As New TicketsService.TicketsSoapClient()
    ticketSvcClient.AddTicketCommentBasic(mTDProxyUser, mTDProxyPassword, mTicketId, comment, True)

  End Sub

End Module
