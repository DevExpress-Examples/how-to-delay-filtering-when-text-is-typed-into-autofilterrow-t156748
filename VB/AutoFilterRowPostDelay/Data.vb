Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace AutoFilterRowPostDelay
    Public Class Data
        Private Shared FirstNames() As String = {"Ann", "Peter", "Rose", "Lily", "Tom", "Jack", "Holly", "Poul"}

        Private Shared LastNames() As String = {"Red", "Blue", "Orange", "White", "Yellow", "Black"}

        Private Shared gen As New Random()

        Public Shared ReadOnly Property DataList() As List(Of Customer)
            Get

                Dim data_Renamed As New List(Of Customer)()
                For i As Integer = 0 To 19
                    data_Renamed.Add(New Customer() With {.Id = i, .FirstName = FirstNames(gen.Next(8)), .LastName = LastNames(gen.Next(6))})
                Next i
                Return data_Renamed
            End Get
        End Property
    End Class

    Public Class Customer
        Public Property Id() As Integer
        Public Property FirstName() As String
        Public Property LastName() As String
    End Class
End Namespace
