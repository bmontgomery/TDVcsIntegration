﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.Data

Namespace TicketsService
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://www.teamdynamix.com/TDWS", ConfigurationName:="TicketsService.TicketsSoap")>  _
    Public Interface TicketsSoap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.teamdynamix.com/TDWS/CreateTicketEx", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function CreateTicketEx( _
                    ByVal UserName As String,  _
                    ByVal Password As String,  _
                    ByVal Title As String,  _
                    ByVal AccountID As Integer,  _
                    ByVal TypeID As Integer,  _
                    ByVal PriorityID As Integer,  _
                    ByVal StatusID As Integer,  _
                    ByVal ContactName As String,  _
                    ByVal ContactEmail As String,  _
                    ByVal Description As String,  _
                    ByVal StartDate As Date,  _
                    ByVal DueDate As Date,  _
                    ByVal Budget As Double,  _
                    ByVal TimeBudget As Double,  _
                    ByVal EstHours As Double,  _
                    ByVal ApproverUID As String,  _
                    ByVal RefCode1 As String,  _
                    ByVal Weight As Double) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.teamdynamix.com/TDWS/CreateTicketNew", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function CreateTicketNew( _
                    ByVal UserName As String,  _
                    ByVal Password As String,  _
                    ByVal Title As String,  _
                    ByVal AccountID As Integer,  _
                    ByVal TypeID As Integer,  _
                    ByVal PriorityID As Integer,  _
                    ByVal StatusID As Integer,  _
                    ByVal ContactName As String,  _
                    ByVal ContactEmail As String,  _
                    ByVal Description As String,  _
                    ByVal StartDate As Date,  _
                    ByVal DueDate As Date,  _
                    ByVal Budget As Double,  _
                    ByVal TimeBudget As Double,  _
                    ByVal EstHours As Double,  _
                    ByVal ApproverUID As String,  _
                    ByVal RefCode1 As String,  _
                    ByVal Weight As Double,  _
                    ByVal descIsHtmlEncoded As Boolean) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.teamdynamix.com/TDWS/GetAccounts", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function GetAccounts(ByVal UserName As String, ByVal Password As String) As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.teamdynamix.com/TDWS/GetTicketTypes", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function GetTicketTypes(ByVal UserName As String, ByVal Password As String) As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.teamdynamix.com/TDWS/GetPriorities", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function GetPriorities(ByVal UserName As String, ByVal Password As String) As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.teamdynamix.com/TDWS/GetTicketStatuses", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function GetTicketStatuses(ByVal UserName As String, ByVal Password As String) As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.teamdynamix.com/TDWS/GetTicketAttributes", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function GetTicketAttributes(ByVal UserName As String, ByVal Password As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.teamdynamix.com/TDWS/GetTickets", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function GetTickets( _
                    ByVal UserName As String,  _
                    ByVal Password As String,  _
                    ByVal GetHistory As Boolean,  _
                    ByVal GetAssignments As Boolean,  _
                    ByVal GetAttributes As Boolean,  _
                    ByVal TicketID As Integer,  _
                    ByVal StatusIDs As String,  _
                    ByVal AccountID As Integer,  _
                    ByVal TypeID As Integer,  _
                    ByVal DueDateFrom As String,  _
                    ByVal DueDateTo As String,  _
                    ByVal DateCreatedFrom As String,  _
                    ByVal DateCreatedTo As String,  _
                    ByVal PriorityIDs As String,  _
                    ByVal CreatorUID As String,  _
                    ByVal ReviewerUID As String,  _
                    ByVal ApproverUID As String,  _
                    ByVal ResponsibleUID As String,  _
                    ByVal PrimaryResponsibleUID As String,  _
                    ByVal ShowOnlyUnassigned As Boolean,  _
                    ByVal RefCode1 As String,  _
                    ByVal TitleLike As String) As String
        
        'CODEGEN: Parameter 'FileBytes' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.teamdynamix.com/TDWS/AddTicketAttachment", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function AddTicketAttachment(ByVal request As TicketsService.AddTicketAttachmentRequest) As TicketsService.AddTicketAttachmentResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.teamdynamix.com/TDWS/AddTicketCommentBasic", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Sub AddTicketCommentBasic(ByVal userName As String, ByVal password As String, ByVal ticketId As String, ByVal comment As String, ByVal isPrivate As Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.teamdynamix.com/TDWS/AddTicketComment", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function AddTicketComment(ByVal UserName As String, ByVal Password As String, ByVal EmailBodyHTML As String, ByVal FromEmailAddress As String, ByVal FromName As String, ByVal IsPrivate As Boolean) As Integer
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="AddTicketAttachment", WrapperNamespace:="http://www.teamdynamix.com/TDWS", IsWrapped:=true)>  _
    Partial Public Class AddTicketAttachmentRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://www.teamdynamix.com/TDWS", Order:=0)>  _
        Public UserName As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://www.teamdynamix.com/TDWS", Order:=1)>  _
        Public Password As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://www.teamdynamix.com/TDWS", Order:=2)>  _
        Public TicketID As Integer
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://www.teamdynamix.com/TDWS", Order:=3)>  _
        Public FileName As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://www.teamdynamix.com/TDWS", Order:=4),  _
         System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")>  _
        Public FileBytes() As Byte
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal UserName As String, ByVal Password As String, ByVal TicketID As Integer, ByVal FileName As String, ByVal FileBytes() As Byte)
            MyBase.New
            Me.UserName = UserName
            Me.Password = Password
            Me.TicketID = TicketID
            Me.FileName = FileName
            Me.FileBytes = FileBytes
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="AddTicketAttachmentResponse", WrapperNamespace:="http://www.teamdynamix.com/TDWS", IsWrapped:=true)>  _
    Partial Public Class AddTicketAttachmentResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://www.teamdynamix.com/TDWS", Order:=0)>  _
        Public AddTicketAttachmentResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal AddTicketAttachmentResult As String)
            MyBase.New
            Me.AddTicketAttachmentResult = AddTicketAttachmentResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface TicketsSoapChannel
        Inherits TicketsService.TicketsSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class TicketsSoapClient
        Inherits System.ServiceModel.ClientBase(Of TicketsService.TicketsSoap)
        Implements TicketsService.TicketsSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function CreateTicketEx( _
                    ByVal UserName As String,  _
                    ByVal Password As String,  _
                    ByVal Title As String,  _
                    ByVal AccountID As Integer,  _
                    ByVal TypeID As Integer,  _
                    ByVal PriorityID As Integer,  _
                    ByVal StatusID As Integer,  _
                    ByVal ContactName As String,  _
                    ByVal ContactEmail As String,  _
                    ByVal Description As String,  _
                    ByVal StartDate As Date,  _
                    ByVal DueDate As Date,  _
                    ByVal Budget As Double,  _
                    ByVal TimeBudget As Double,  _
                    ByVal EstHours As Double,  _
                    ByVal ApproverUID As String,  _
                    ByVal RefCode1 As String,  _
                    ByVal Weight As Double) As Integer Implements TicketsService.TicketsSoap.CreateTicketEx
            Return MyBase.Channel.CreateTicketEx(UserName, Password, Title, AccountID, TypeID, PriorityID, StatusID, ContactName, ContactEmail, Description, StartDate, DueDate, Budget, TimeBudget, EstHours, ApproverUID, RefCode1, Weight)
        End Function
        
        Public Function CreateTicketNew( _
                    ByVal UserName As String,  _
                    ByVal Password As String,  _
                    ByVal Title As String,  _
                    ByVal AccountID As Integer,  _
                    ByVal TypeID As Integer,  _
                    ByVal PriorityID As Integer,  _
                    ByVal StatusID As Integer,  _
                    ByVal ContactName As String,  _
                    ByVal ContactEmail As String,  _
                    ByVal Description As String,  _
                    ByVal StartDate As Date,  _
                    ByVal DueDate As Date,  _
                    ByVal Budget As Double,  _
                    ByVal TimeBudget As Double,  _
                    ByVal EstHours As Double,  _
                    ByVal ApproverUID As String,  _
                    ByVal RefCode1 As String,  _
                    ByVal Weight As Double,  _
                    ByVal descIsHtmlEncoded As Boolean) As Integer Implements TicketsService.TicketsSoap.CreateTicketNew
            Return MyBase.Channel.CreateTicketNew(UserName, Password, Title, AccountID, TypeID, PriorityID, StatusID, ContactName, ContactEmail, Description, StartDate, DueDate, Budget, TimeBudget, EstHours, ApproverUID, RefCode1, Weight, descIsHtmlEncoded)
        End Function
        
        Public Function GetAccounts(ByVal UserName As String, ByVal Password As String) As System.Data.DataTable Implements TicketsService.TicketsSoap.GetAccounts
            Return MyBase.Channel.GetAccounts(UserName, Password)
        End Function
        
        Public Function GetTicketTypes(ByVal UserName As String, ByVal Password As String) As System.Data.DataTable Implements TicketsService.TicketsSoap.GetTicketTypes
            Return MyBase.Channel.GetTicketTypes(UserName, Password)
        End Function
        
        Public Function GetPriorities(ByVal UserName As String, ByVal Password As String) As System.Data.DataTable Implements TicketsService.TicketsSoap.GetPriorities
            Return MyBase.Channel.GetPriorities(UserName, Password)
        End Function
        
        Public Function GetTicketStatuses(ByVal UserName As String, ByVal Password As String) As System.Data.DataTable Implements TicketsService.TicketsSoap.GetTicketStatuses
            Return MyBase.Channel.GetTicketStatuses(UserName, Password)
        End Function
        
        Public Function GetTicketAttributes(ByVal UserName As String, ByVal Password As String) As String Implements TicketsService.TicketsSoap.GetTicketAttributes
            Return MyBase.Channel.GetTicketAttributes(UserName, Password)
        End Function
        
        Public Function GetTickets( _
                    ByVal UserName As String,  _
                    ByVal Password As String,  _
                    ByVal GetHistory As Boolean,  _
                    ByVal GetAssignments As Boolean,  _
                    ByVal GetAttributes As Boolean,  _
                    ByVal TicketID As Integer,  _
                    ByVal StatusIDs As String,  _
                    ByVal AccountID As Integer,  _
                    ByVal TypeID As Integer,  _
                    ByVal DueDateFrom As String,  _
                    ByVal DueDateTo As String,  _
                    ByVal DateCreatedFrom As String,  _
                    ByVal DateCreatedTo As String,  _
                    ByVal PriorityIDs As String,  _
                    ByVal CreatorUID As String,  _
                    ByVal ReviewerUID As String,  _
                    ByVal ApproverUID As String,  _
                    ByVal ResponsibleUID As String,  _
                    ByVal PrimaryResponsibleUID As String,  _
                    ByVal ShowOnlyUnassigned As Boolean,  _
                    ByVal RefCode1 As String,  _
                    ByVal TitleLike As String) As String Implements TicketsService.TicketsSoap.GetTickets
            Return MyBase.Channel.GetTickets(UserName, Password, GetHistory, GetAssignments, GetAttributes, TicketID, StatusIDs, AccountID, TypeID, DueDateFrom, DueDateTo, DateCreatedFrom, DateCreatedTo, PriorityIDs, CreatorUID, ReviewerUID, ApproverUID, ResponsibleUID, PrimaryResponsibleUID, ShowOnlyUnassigned, RefCode1, TitleLike)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function TicketsService_TicketsSoap_AddTicketAttachment(ByVal request As TicketsService.AddTicketAttachmentRequest) As TicketsService.AddTicketAttachmentResponse Implements TicketsService.TicketsSoap.AddTicketAttachment
            Return MyBase.Channel.AddTicketAttachment(request)
        End Function
        
        Public Function AddTicketAttachment(ByVal UserName As String, ByVal Password As String, ByVal TicketID As Integer, ByVal FileName As String, ByVal FileBytes() As Byte) As String
            Dim inValue As TicketsService.AddTicketAttachmentRequest = New TicketsService.AddTicketAttachmentRequest()
            inValue.UserName = UserName
            inValue.Password = Password
            inValue.TicketID = TicketID
            inValue.FileName = FileName
            inValue.FileBytes = FileBytes
            Dim retVal As TicketsService.AddTicketAttachmentResponse = CType(Me,TicketsService.TicketsSoap).AddTicketAttachment(inValue)
            Return retVal.AddTicketAttachmentResult
        End Function
        
        Public Sub AddTicketCommentBasic(ByVal userName As String, ByVal password As String, ByVal ticketId As String, ByVal comment As String, ByVal isPrivate As Boolean) Implements TicketsService.TicketsSoap.AddTicketCommentBasic
            MyBase.Channel.AddTicketCommentBasic(userName, password, ticketId, comment, isPrivate)
        End Sub
        
        Public Function AddTicketComment(ByVal UserName As String, ByVal Password As String, ByVal EmailBodyHTML As String, ByVal FromEmailAddress As String, ByVal FromName As String, ByVal IsPrivate As Boolean) As Integer Implements TicketsService.TicketsSoap.AddTicketComment
            Return MyBase.Channel.AddTicketComment(UserName, Password, EmailBodyHTML, FromEmailAddress, FromName, IsPrivate)
        End Function
    End Class
End Namespace
