Imports System.ComponentModel.DataAnnotations
Imports Newtonsoft.Json

Namespace model

    Public Class STAFFDEPARTMENT

        '#  To store list of staff rows from querying
        'Public STAFF As IEnumerable(Of STAFF)

        '#  To store list of staff rows with shift id from querying
        Public STAFFSIMPLELIST As IEnumerable(Of SELECTEDSTAFF)

        '# For Index View - Filter Function
        Public FIRSTNAME As String
        Public LASTNAME As String
        Public NRIC As String
        Public DEPARTMENTID As Integer
        Public SHIFTID As String
        Public SHOWRESIGNEDSTAFF As Boolean

        ' For Edit and Delete View
        Public Property STAFFNO As String
        Public Property ISRESIGNED As Boolean
        <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy}", ApplyFormatInEditMode:=True)>
        Public Property RESIGNEDON As Nullable(Of Date)
        Public Property RESIGNEDONSTR As String

        Public DEPARTMENTLIST As IList(Of SelectListItem)
        Public SHIFTLIST As IList(Of SelectListItem)

        '#  To store list of staff rows from Firebird Database querying
        Public FIREBIRDSTAFFLIST As IEnumerable(Of FIREBIRDSTAFF)

    End Class

    Public Class FIREBIRDSTAFF
        Public STAFFNO As String
        <JsonProperty("NAME")>
        Public NAME As String
        <JsonProperty("NRIC")>
        Public NRIC As String
        <JsonProperty("DEPARTMENTID")>
        Public DEPARTMENTID As String
        <JsonProperty("SHIFTID")>
        Public SHIFTID As String
    End Class

    Public Class SELECTEDSTAFF

        Public Property NRIC As String
        Public Property STAFFNO As String
        Public Property FIRSTNAME As String
        Public Property LASTNAME As String
        Public Property DEPARTMENTID As Integer
        Public Property DEPARTMENTNAME As String
        Public Property DIVISIONNAME As String
        Public Property UNITNAME As String
        Public Property SHIFTID As String
        Public Property EFFECTIVEON As Date

    End Class

    Public Class STAFF

        <Key>
        <Required(ErrorMessage:="NRIC is required")>
        Public Property NRIC As String
        Public Property STAFFNO As String
        Public Property FIRSTNAME As String
        Public Property LASTNAME As String
        Public Property STAFFGROUPID As String
        Public Property GENDER As String
        Public Property GRADE As String
        Public Property CONTACTNO1 As String
        Public Property CONTACTNO2 As String
        Public Property ADDRESS As String
        Public Property EMAIL As String
        Public Property DEPARTMENTID As String
        Public Property ISRESIGNED As Boolean
        <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy}", ApplyFormatInEditMode:=True)>
        Public Property RESIGNEDON As Nullable(Of Date)
        Public Property PASSWORD As String
        Public Property CREATEDBY As String
        Public Property CREATEDON As Date
        Public Property UPDATEDBY As String
        Public Property UPDATEDON As Nullable(Of Date)
        Public Property STATUSCODE As String

    End Class

End Namespace



