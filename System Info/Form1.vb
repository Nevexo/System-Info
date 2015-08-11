Imports System
Imports System.Management
Imports System.Diagnostics

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Loading.Show()
        pollsys()
    End Sub
    Sub pollsys()
        Dim sgtr As String = "HARDWARE\DESCRIPTION\System\CentralProcessor"
        Dim cpuMhz As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
            "HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("~mhz")

        Dim cpuName As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
            "HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("ProcessorNameString")

        Dim cpuVendorID As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
            "HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("VendorIdentifier")

        Dim cpuIdentifier As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
            "HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("Identifier")

        Dim sysVendor As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
            "HARDWARE\DESCRIPTION\System\BIOS").GetValue("SystemManufacturer")

        Dim moboVendor As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
            "HARDWARE\DESCRIPTION\System\BIOS").GetValue("BaseBoardManufacturer")

        Dim moboModel As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
            "HARDWARE\DESCRIPTION\System\BIOS").GetValue("BaseBoardProduct")

        Dim moboFirmwareVend As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
            "HARDWARE\DESCRIPTION\System\BIOS").GetValue("BIOSVendor")

        Label1.Text = "OSNAME: " & My.Computer.Info.OSFullName
        Label2.Text = "OSPLATFORM: " & My.Computer.Info.OSPlatform
        Label3.Text = "OSVERSION: " & My.Computer.Info.OSVersion
        Label4.Text = "USABLE RAM: " & My.Computer.Info.TotalVirtualMemory & " MB"
        Label5.Text = "INSTALLED RAM: " & My.Computer.Info.TotalPhysicalMemory & " MB"


        Label6.Text = "CPU NAME: " & cpuName
        Label7.Text = "CPU SPEED: " & cpuMhz & " Mhz"
        Label8.Text = "CPU VENDOR: " & cpuVendorID
        Label9.Text = "CPU ID: " & cpuIdentifier
        Label10.Text = "SYSTEM VENDOR: " & sysVendor
        Label11.Text = "MOTHERBOARD VENDOR: " & moboVendor
        Label12.Text = "MOTHERBOARD MODEL: " & moboModel
        Label13.Text = "MOBO FIRMWARE VENDOR: " & moboFirmwareVend




        Loading.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pollsys()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            timer1.start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pollsys()
    End Sub


End Class



