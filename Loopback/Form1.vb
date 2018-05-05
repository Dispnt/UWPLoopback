Imports MaterialSkin
Imports System.IO
Imports System.Environment
Public Class Form1
    '========================MaterialSkin部分
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    '===============获得输出所用类
    Public Class ConsoleOutput
        Private Sub New()
        End Sub

        Private Shared gWorkingDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal)

        Public Shared Property WorkingDirectory() As String
            Get
                Return gWorkingDirectory
            End Get
            Set(ByVal Value As String)
                gWorkingDirectory = Value
            End Set
        End Property

        Public Shared Function ExcuteCmd(ByVal command As String) As String
            Dim mResult As String
            Dim tmpProcess As New Process
            With tmpProcess
                With .StartInfo
                    .CreateNoWindow = True
                    .FileName = .EnvironmentVariables.Item("ComSpec")
                    .RedirectStandardOutput = True
                    .UseShellExecute = False
                    .Arguments = String.Format("/C {0}", command)
                    .WorkingDirectory = gWorkingDirectory
                End With
                Try
                    .Start()
                    .WaitForExit(5000)
                    mResult = .StandardOutput.ReadToEnd
                Catch e As System.ComponentModel.Win32Exception
                    mResult = e.ToString
                End Try
            End With
            Return mResult
        End Function
    End Class


    Private Sub Enable_Click_1(sender As Object, e As EventArgs) Handles Enable.Click
        Me.Text = "Status:Applying"
        Me.Refresh()
        Dim UserPath As String = GetFolderPath(SpecialFolder.UserProfile)
        Dim UWPPath As New DirectoryInfo(UserPath & "\AppData\Local\Packages")
        ListBox1.Items.Clear()
        For Each UWPmane In UWPPath.GetDirectories
            ListBox1.Items.Add(ConsoleOutput.ExcuteCmd("CheckNetIsolation LoopbackExempt -a -n=" + UWPmane.Name) + UWPmane.Name)
        Next
        Me.Text = "Status:Done"
        Me.Refresh()
    End Sub

    Private Sub Disbale_Click(sender As Object, e As EventArgs) Handles Disable.Click
        ListBox1.Items.Clear()
        ListBox1.Items.Add(ConsoleOutput.ExcuteCmd("CheckNetIsolation LoopbackExempt -c"))
    End Sub


End Class