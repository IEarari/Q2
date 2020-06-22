Public Class Resistor
#Region "Attributes"
    Private ValArr(2) As Double
    Private Front As Integer = 0
    Private Rear As Integer = -1
    Private value As Integer = 0
#End Region
#Region "Property"
    Public ReadOnly Property getVal()
        Get
            Return value
        End Get
    End Property
#End Region
#Region "Methods"
    Public Sub Insert(x As Integer)
        If Rear <> 2 Then
            Rear += 1
            ValArr(Rear) = x
        Else
            MessageBox.Show("Queue Is Full!")
        End If
    End Sub
    Public Function Delete() As Double
        If Front > Rear Then
            MessageBox.Show("Queue is empty!")
        Else
            Return ValArr(Front)
            Front += 1
        End If
        Return 0
    End Function

    Public Sub calculation()
        value = (ValArr(0) * 1 + ValArr(1) * 10) * ValArr(2)
    End Sub
    Public Sub Clear()
        Rear = -1
        Front = 0
    End Sub
#End Region
#Region "Counstructor"
    Public Sub New()
        value = 0
        Rear = -1
        Front = 0
    End Sub
#End Region
End Class
