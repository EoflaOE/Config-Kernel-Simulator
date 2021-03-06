﻿
'    Kernel Simulator Configuration Tool  Copyright (C) 2018-2020  EoflaOE
'
'    This file is part of Kernel Simulator Configuration Tool
'
'    Kernel Simulator Configuration Tool is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.
'
'    Kernel Simulator Configuration Tool is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.
'
'    You should have received a copy of the GNU General Public License
'    along with this program.  If not, see <https://www.gnu.org/licenses/>.

Public Class SimulatorsSelection

    'Variables
    Public kernelSimulators() As String
    Public wsh As New IWshRuntimeLibrary.WshShell
    Public onExec As Boolean = True
    Public selectedExec As String

    Private Sub RefreshSims(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown, refreshButton.Click

        population.RunWorkerAsync()

    End Sub

    Private Sub population_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles population.DoWork

        'TODO: Re-write, but let it detect all EXE files and see if the specified EXE file is KS or not.
        statText.Text = "Finding Kernel Simulator executables..."

        'Try to delete the temporary old search file
        Try
            FileIO.FileSystem.DeleteFile(Environ("TEMP") + "\ksFind.txt")
        Catch ex As IO.FileNotFoundException
            'Do nothing, and continue.
        End Try

        'Variables
        Dim ret As Integer
        Dim folder As String = ""

        'Find KS in every disk
        For Each drive As IO.DriveInfo In My.Computer.FileSystem.Drives
            If drive.DriveType = IO.DriveType.Fixed Then
                folder = drive.Name
                ret = wsh.Run("CMD /C DIR """ & folder & "Kernel*Simulator.exe"" /S /B /A:-D >> %TEMP%\ksFind.txt", 0, True)
            End If
        Next

        'If KS is found
        If (ret = 0) Then
            'Variables
            Dim res As New IO.StreamReader(Environ("TEMP") + "\ksFind.txt")
            Dim ln As String = res.ReadLine
            Dim temp As String = ""

            'TODO: Make it a list, removing unnecessary "temp" var.
            Do While Not res.EndOfStream
                temp = temp + ln + ", "
                ln = res.ReadLine
            Loop

            'Split paths
            Dim kernelSimulators() As String = temp.Split({", "}, StringSplitOptions.RemoveEmptyEntries)
            For Each KernelSimulator As String In kernelSimulators
                Me.Invoke(New Action(Sub()
                                         Simulators.Items.Add(KernelSimulator)
                                         Simulators.Items.Item(Simulators.Items.Count - 1).SubItems.Add(Reflection.Assembly.LoadFile(KernelSimulator).GetName.Version.ToString)
                                         statText.Text = "Found " + KernelSimulator
                                         statBar.Increment(statBar.Maximum / kernelSimulators.Length)
                                         If (Simulators.Items.Count = 1) Then
                                             Me.Text = "Found " + CStr(Simulators.Items.Count) + " simulator - Choose one from the list and click OK to create a config file."
                                         Else
                                             Me.Text = "Found " + CStr(Simulators.Items.Count) + " simulators - Choose one from the list and click OK to create a config file."
                                         End If
                                     End Sub))
            Next

            'Ready
            statText.Text = "Ready!"
        Else
            MsgBox("Kernel Simulator executable was not found anywhere on " + folder + ". " + vbNewLine + "Download on https://github.com/EoflaOE/Kernel-Simulator/releases", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Kernel Simulator Not Found")
            Environment.Exit(2)
        End If

    End Sub

    Private Sub cancelButtonList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelButtonList.Click

        If (onExec = False) Then
            Me.Hide()
        Else
            Environment.Exit(1)
        End If

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click

        Dim ret = wsh.Run("CMD /C """ & selectedExec & """ createConf", 0, True)
        If (ret = 0) Then
            MsgBox("Kernel Simulator has created a configuration.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Kernel Simulator Config Error")
            Me.Hide()
            Configurator.ReadConfig()
            Configurator.Show()
        Else
            MsgBox("Kernel Simulator executable was unable to create a config. Kernel Simulator returned " + CStr(ret), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Kernel Simulator Config Error")
            Environment.Exit(1)
        End If

    End Sub

    Private Sub Simulators_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles Simulators.ItemSelectionChanged

        If (IsNothing(Simulators.FocusedItem) = False) Then
            Dim versionAsm As String = Simulators.Items(Simulators.FocusedItem.Index).SubItems(1).Text.Remove(5)
#Disable Warning IDE0059
            Dim versionAsmSplit(2) As String
#Enable Warning IDE0059
            versionAsmSplit = versionAsm.Split("."c)
            If (CInt(versionAsmSplit(0)) = 0 And CInt(versionAsmSplit(1)) = 0 And CInt(versionAsmSplit(2)) >= 4) Or (CInt(versionAsmSplit(0)) > 0 And CInt(versionAsmSplit(1)) > 0 And CInt(versionAsmSplit(2)) >= 0) Then
                OKButton.Enabled = True
                selectedExec = Simulators.Items(Simulators.FocusedItem.Index).Text
            ElseIf (CInt(versionAsmSplit(0)) = 0 And CInt(versionAsmSplit(1)) = 0 And CInt(versionAsmSplit(2)) < 4) Then
                OKButton.Enabled = False
            End If
        End If

    End Sub
End Class