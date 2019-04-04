'Eddie Switek
'CST 271
'Chapter 11 Guided Program
'This business class for registering an on-campus college student calculates the semester costs,
'including tuition and housing. It also causes the student costs file to be written.

Option Strict On
Public Class OnCampusStudent
    Inherits Student

    'Class variables
    Private _Cooper As Boolean
    Private _Craig As Boolean
    Private _Julian As Boolean

    Dim objStudentCostsFile As StudentCostsFile

    Sub New(ByVal StudentID As String, ByVal StudentName As String, ByVal Major As String, ByVal Units As String,
            ByVal Cooper As Boolean, ByVal Craig As Boolean, ByVal Julian As Boolean)
        'This subprocedure is a constructor for the Student class. It is called when instantiated with arguments

        MyBase.New(StudentID, StudentName, Major, Units)

        'The following code assigns the arguments to class variables
        _Cooper = Cooper
        _Craig = Craig
        _Julian = Julian

    End Sub

    Overrides Function ComputeCosts() As Decimal
        'This function computes the registration costs, 
        'writes a record In the student costs file, And returns the registration costs

        'Define variables
        Dim HousingCost As Decimal
        Const cdecCooperHousingCost As Decimal = 2900D
        Const cdecCraigHousingCost As Decimal = 3400D
        Const cdecJulianHousingCost As Decimal = 4000D

        'Calculate the cost
        If _Cooper Then
            HousingCost = cdecCooperHousingCost
        ElseIf _Craig Then
            HousingCost = cdecCraigHousingCost
        ElseIf _Julian Then
            HousingCost = cdecJulianHousingCost
        End If

        _decCost = (_intUnits * _decCostPerUnit) + HousingCost

        'Write the student record.
        objStudentCostsFile = New StudentCostsFile(_strStudentID, _strStudentName, _strMajor, _decCost)
        objStudentCostsFile.WriteRecord()

        'Return the calculated cost.
        Return _decCost

    End Function

End Class
