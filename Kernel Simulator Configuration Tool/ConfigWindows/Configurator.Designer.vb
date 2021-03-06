﻿
'    Kernel Simulator Configuration Tool  Copyright (C) 2018  EoflaOE
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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configurator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configurator))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenSourceLibrariesUsedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.UpdateStart = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ErrorColor = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.StageColor = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.inputColor = New System.Windows.Forms.ComboBox()
        Me.backgroundColor = New System.Windows.Forms.ComboBox()
        Me.DefHelpColor = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CmdHelpColor = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.userNameColor = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hostNameColor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.uncontError = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.contError = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.licenseColor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textColor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RootPwd = New System.Windows.Forms.MaskedTextBox()
        Me.RootPC = New System.Windows.Forms.CheckBox()
        Me.MaintMode = New System.Windows.Forms.CheckBox()
        Me.BootPrompt = New System.Windows.Forms.CheckBox()
        Me.LogIn = New System.Windows.Forms.TabPage()
        Me.UsersShow = New System.Windows.Forms.CheckBox()
        Me.HostName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.clslogin = New System.Windows.Forms.CheckBox()
        Me.motdShow = New System.Windows.Forms.CheckBox()
        Me.Shell = New System.Windows.Forms.TabPage()
        Me.simHelp = New System.Windows.Forms.CheckBox()
        Me.colorShell = New System.Windows.Forms.CheckBox()
        Me.Hardware = New System.Windows.Forms.TabPage()
        Me.slotProbe = New System.Windows.Forms.CheckBox()
        Me.probeQuiet = New System.Windows.Forms.CheckBox()
        Me.Localization = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Languages = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NetworkTab = New System.Windows.Forms.TabPage()
        Me.FirstFTPProfile = New System.Windows.Forms.CheckBox()
        Me.LogFTPIP = New System.Windows.Forms.CheckBox()
        Me.LogFTPUsr = New System.Windows.Forms.CheckBox()
        Me.RetryDownload = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DebugNPrefix = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DebugPort = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Others = New System.Windows.Forms.TabPage()
        Me.HiddenFiles = New System.Windows.Forms.CheckBox()
        Me.LongTimeDate = New System.Windows.Forms.CheckBox()
        Me.StartScroll = New System.Windows.Forms.CheckBox()
        Me.FullParseMode = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DebugMax = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Screensave = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tdCorner = New System.Windows.Forms.CheckBox()
        Me.ScreenOpen = New System.Windows.Forms.OpenFileDialog()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.LogIn.SuspendLayout()
        Me.Shell.SuspendLayout()
        Me.Hardware.SuspendLayout()
        Me.Localization.SuspendLayout()
        Me.NetworkTab.SuspendLayout()
        Me.Others.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.HelpToolStripMenuItem, Me.OpenSourceLibrariesUsedToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(660, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveSettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'SaveSettingsToolStripMenuItem
        '
        Me.SaveSettingsToolStripMenuItem.Name = "SaveSettingsToolStripMenuItem"
        Me.SaveSettingsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveSettingsToolStripMenuItem.Text = "Save Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'OpenSourceLibrariesUsedToolStripMenuItem
        '
        Me.OpenSourceLibrariesUsedToolStripMenuItem.Name = "OpenSourceLibrariesUsedToolStripMenuItem"
        Me.OpenSourceLibrariesUsedToolStripMenuItem.Size = New System.Drawing.Size(163, 20)
        Me.OpenSourceLibrariesUsedToolStripMenuItem.Text = "Open Source Libraries Used"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Controls.Add(Me.LogIn)
        Me.TabControl1.Controls.Add(Me.Shell)
        Me.TabControl1.Controls.Add(Me.Hardware)
        Me.TabControl1.Controls.Add(Me.Localization)
        Me.TabControl1.Controls.Add(Me.NetworkTab)
        Me.TabControl1.Controls.Add(Me.Others)
        Me.TabControl1.Location = New System.Drawing.Point(8, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(647, 448)
        Me.TabControl1.TabIndex = 1
        '
        'General
        '
        Me.General.Controls.Add(Me.UpdateStart)
        Me.General.Controls.Add(Me.GroupBox1)
        Me.General.Controls.Add(Me.RootPwd)
        Me.General.Controls.Add(Me.RootPC)
        Me.General.Controls.Add(Me.MaintMode)
        Me.General.Controls.Add(Me.BootPrompt)
        Me.General.Location = New System.Drawing.Point(4, 24)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(639, 420)
        Me.General.TabIndex = 0
        Me.General.Text = "General"
        Me.General.UseVisualStyleBackColor = True
        '
        'UpdateStart
        '
        Me.UpdateStart.AutoSize = True
        Me.UpdateStart.Location = New System.Drawing.Point(437, 12)
        Me.UpdateStart.Name = "UpdateStart"
        Me.UpdateStart.Size = New System.Drawing.Size(181, 19)
        Me.UpdateStart.TabIndex = 9
        Me.UpdateStart.Text = "Check for Updates on Startup"
        Me.UpdateStart.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.ErrorColor)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.StageColor)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.inputColor)
        Me.GroupBox1.Controls.Add(Me.backgroundColor)
        Me.GroupBox1.Controls.Add(Me.DefHelpColor)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.CmdHelpColor)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.userNameColor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.hostNameColor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.uncontError)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.contError)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.licenseColor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.textColor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 325)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Colors"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(435, 177)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 15)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "Error Color"
        '
        'ErrorColor
        '
        Me.ErrorColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ErrorColor.Enabled = False
        Me.ErrorColor.FormattingEnabled = True
        Me.ErrorColor.Location = New System.Drawing.Point(438, 195)
        Me.ErrorColor.Name = "ErrorColor"
        Me.ErrorColor.Size = New System.Drawing.Size(168, 23)
        Me.ErrorColor.TabIndex = 30
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(224, 177)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 15)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Stage Color"
        '
        'StageColor
        '
        Me.StageColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StageColor.Enabled = False
        Me.StageColor.FormattingEnabled = True
        Me.StageColor.Location = New System.Drawing.Point(227, 195)
        Me.StageColor.Name = "StageColor"
        Me.StageColor.Size = New System.Drawing.Size(168, 23)
        Me.StageColor.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 177)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 15)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Background Color"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(435, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 15)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Input Color"
        '
        'inputColor
        '
        Me.inputColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.inputColor.Enabled = False
        Me.inputColor.FormattingEnabled = True
        Me.inputColor.Location = New System.Drawing.Point(438, 143)
        Me.inputColor.Name = "inputColor"
        Me.inputColor.Size = New System.Drawing.Size(168, 23)
        Me.inputColor.TabIndex = 25
        '
        'backgroundColor
        '
        Me.backgroundColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.backgroundColor.Enabled = False
        Me.backgroundColor.FormattingEnabled = True
        Me.backgroundColor.Location = New System.Drawing.Point(15, 195)
        Me.backgroundColor.Name = "backgroundColor"
        Me.backgroundColor.Size = New System.Drawing.Size(168, 23)
        Me.backgroundColor.TabIndex = 24
        '
        'DefHelpColor
        '
        Me.DefHelpColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DefHelpColor.Enabled = False
        Me.DefHelpColor.FormattingEnabled = True
        Me.DefHelpColor.Location = New System.Drawing.Point(227, 143)
        Me.DefHelpColor.Name = "DefHelpColor"
        Me.DefHelpColor.Size = New System.Drawing.Size(168, 23)
        Me.DefHelpColor.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(224, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 15)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Definition Help Color"
        '
        'CmdHelpColor
        '
        Me.CmdHelpColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmdHelpColor.Enabled = False
        Me.CmdHelpColor.FormattingEnabled = True
        Me.CmdHelpColor.Location = New System.Drawing.Point(15, 143)
        Me.CmdHelpColor.Name = "CmdHelpColor"
        Me.CmdHelpColor.Size = New System.Drawing.Size(168, 23)
        Me.CmdHelpColor.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 15)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Command Help Color"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(438, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 41)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Show colors in Live Mode"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(584, 30)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'userNameColor
        '
        Me.userNameColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.userNameColor.Enabled = False
        Me.userNameColor.FormattingEnabled = True
        Me.userNameColor.Location = New System.Drawing.Point(438, 90)
        Me.userNameColor.Name = "userNameColor"
        Me.userNameColor.Size = New System.Drawing.Size(168, 23)
        Me.userNameColor.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(435, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "User Name Shell Color"
        '
        'hostNameColor
        '
        Me.hostNameColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hostNameColor.Enabled = False
        Me.hostNameColor.FormattingEnabled = True
        Me.hostNameColor.Location = New System.Drawing.Point(227, 90)
        Me.hostNameColor.Name = "hostNameColor"
        Me.hostNameColor.Size = New System.Drawing.Size(168, 23)
        Me.hostNameColor.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(224, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Host Name Shell Color"
        '
        'uncontError
        '
        Me.uncontError.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.uncontError.Enabled = False
        Me.uncontError.FormattingEnabled = True
        Me.uncontError.Location = New System.Drawing.Point(15, 90)
        Me.uncontError.Name = "uncontError"
        Me.uncontError.Size = New System.Drawing.Size(168, 23)
        Me.uncontError.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Uncontinuable Kernel Error Color"
        '
        'contError
        '
        Me.contError.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.contError.Enabled = False
        Me.contError.FormattingEnabled = True
        Me.contError.Location = New System.Drawing.Point(438, 37)
        Me.contError.Name = "contError"
        Me.contError.Size = New System.Drawing.Size(168, 23)
        Me.contError.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(435, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Continuable Kernel Error Color"
        '
        'licenseColor
        '
        Me.licenseColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.licenseColor.Enabled = False
        Me.licenseColor.FormattingEnabled = True
        Me.licenseColor.Location = New System.Drawing.Point(227, 37)
        Me.licenseColor.Name = "licenseColor"
        Me.licenseColor.Size = New System.Drawing.Size(168, 23)
        Me.licenseColor.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "License Color"
        '
        'textColor
        '
        Me.textColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.textColor.Enabled = False
        Me.textColor.FormattingEnabled = True
        Me.textColor.Location = New System.Drawing.Point(15, 37)
        Me.textColor.Name = "textColor"
        Me.textColor.Size = New System.Drawing.Size(168, 23)
        Me.textColor.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Text Color"
        '
        'RootPwd
        '
        Me.RootPwd.BeepOnError = True
        Me.RootPwd.Enabled = False
        Me.RootPwd.Location = New System.Drawing.Point(166, 60)
        Me.RootPwd.Name = "RootPwd"
        Me.RootPwd.Size = New System.Drawing.Size(462, 23)
        Me.RootPwd.TabIndex = 7
        Me.RootPwd.UseSystemPasswordChar = True
        '
        'RootPC
        '
        Me.RootPC.AutoSize = True
        Me.RootPC.Location = New System.Drawing.Point(10, 62)
        Me.RootPC.Name = "RootPC"
        Me.RootPC.Size = New System.Drawing.Size(151, 19)
        Me.RootPC.TabIndex = 2
        Me.RootPC.Text = "Root Password Change:"
        Me.RootPC.UseVisualStyleBackColor = True
        '
        'MaintMode
        '
        Me.MaintMode.AutoSize = True
        Me.MaintMode.Location = New System.Drawing.Point(10, 37)
        Me.MaintMode.Name = "MaintMode"
        Me.MaintMode.Size = New System.Drawing.Size(129, 19)
        Me.MaintMode.TabIndex = 1
        Me.MaintMode.Text = "Maintenance Mode"
        Me.MaintMode.UseVisualStyleBackColor = True
        '
        'BootPrompt
        '
        Me.BootPrompt.AutoSize = True
        Me.BootPrompt.Location = New System.Drawing.Point(10, 12)
        Me.BootPrompt.Name = "BootPrompt"
        Me.BootPrompt.Size = New System.Drawing.Size(191, 19)
        Me.BootPrompt.TabIndex = 0
        Me.BootPrompt.Text = "Prompt for Arguments on Boot"
        Me.BootPrompt.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.LogIn.Controls.Add(Me.UsersShow)
        Me.LogIn.Controls.Add(Me.HostName)
        Me.LogIn.Controls.Add(Me.Label10)
        Me.LogIn.Controls.Add(Me.clslogin)
        Me.LogIn.Controls.Add(Me.motdShow)
        Me.LogIn.Location = New System.Drawing.Point(4, 24)
        Me.LogIn.Name = "LogIn"
        Me.LogIn.Padding = New System.Windows.Forms.Padding(3)
        Me.LogIn.Size = New System.Drawing.Size(639, 420)
        Me.LogIn.TabIndex = 1
        Me.LogIn.Text = "Log in"
        Me.LogIn.UseVisualStyleBackColor = True
        '
        'UsersShow
        '
        Me.UsersShow.AutoSize = True
        Me.UsersShow.Location = New System.Drawing.Point(10, 91)
        Me.UsersShow.Name = "UsersShow"
        Me.UsersShow.Size = New System.Drawing.Size(184, 19)
        Me.UsersShow.TabIndex = 21
        Me.UsersShow.Text = "Show available users on Login"
        Me.UsersShow.UseVisualStyleBackColor = True
        '
        'HostName
        '
        Me.HostName.Location = New System.Drawing.Point(138, 62)
        Me.HostName.Name = "HostName"
        Me.HostName.Size = New System.Drawing.Size(486, 23)
        Me.HostName.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Host Name:"
        '
        'clslogin
        '
        Me.clslogin.AutoSize = True
        Me.clslogin.Location = New System.Drawing.Point(10, 37)
        Me.clslogin.Name = "clslogin"
        Me.clslogin.Size = New System.Drawing.Size(141, 19)
        Me.clslogin.TabIndex = 1
        Me.clslogin.Text = "Clear Screen on Login"
        Me.clslogin.UseVisualStyleBackColor = True
        '
        'motdShow
        '
        Me.motdShow.AutoSize = True
        Me.motdShow.Checked = True
        Me.motdShow.CheckState = System.Windows.Forms.CheckState.Checked
        Me.motdShow.Location = New System.Drawing.Point(10, 12)
        Me.motdShow.Name = "motdShow"
        Me.motdShow.Size = New System.Drawing.Size(141, 19)
        Me.motdShow.TabIndex = 0
        Me.motdShow.Text = "Show MOTD on Login"
        Me.motdShow.UseVisualStyleBackColor = True
        '
        'Shell
        '
        Me.Shell.Controls.Add(Me.simHelp)
        Me.Shell.Controls.Add(Me.colorShell)
        Me.Shell.Location = New System.Drawing.Point(4, 24)
        Me.Shell.Name = "Shell"
        Me.Shell.Size = New System.Drawing.Size(639, 420)
        Me.Shell.TabIndex = 2
        Me.Shell.Text = "Shell"
        Me.Shell.UseVisualStyleBackColor = True
        '
        'simHelp
        '
        Me.simHelp.AutoSize = True
        Me.simHelp.Location = New System.Drawing.Point(10, 37)
        Me.simHelp.Name = "simHelp"
        Me.simHelp.Size = New System.Drawing.Size(167, 19)
        Me.simHelp.TabIndex = 1
        Me.simHelp.Text = "Simplified Help Command"
        Me.simHelp.UseVisualStyleBackColor = True
        '
        'colorShell
        '
        Me.colorShell.AutoSize = True
        Me.colorShell.Checked = True
        Me.colorShell.CheckState = System.Windows.Forms.CheckState.Checked
        Me.colorShell.Location = New System.Drawing.Point(10, 12)
        Me.colorShell.Name = "colorShell"
        Me.colorShell.Size = New System.Drawing.Size(96, 19)
        Me.colorShell.TabIndex = 0
        Me.colorShell.Text = "Colored Shell"
        Me.colorShell.UseVisualStyleBackColor = True
        '
        'Hardware
        '
        Me.Hardware.Controls.Add(Me.slotProbe)
        Me.Hardware.Controls.Add(Me.probeQuiet)
        Me.Hardware.Location = New System.Drawing.Point(4, 24)
        Me.Hardware.Name = "Hardware"
        Me.Hardware.Size = New System.Drawing.Size(639, 420)
        Me.Hardware.TabIndex = 3
        Me.Hardware.Text = "Hardware"
        Me.Hardware.UseVisualStyleBackColor = True
        '
        'slotProbe
        '
        Me.slotProbe.AutoSize = True
        Me.slotProbe.Checked = True
        Me.slotProbe.CheckState = System.Windows.Forms.CheckState.Checked
        Me.slotProbe.Location = New System.Drawing.Point(10, 37)
        Me.slotProbe.Name = "slotProbe"
        Me.slotProbe.Size = New System.Drawing.Size(320, 19)
        Me.slotProbe.TabIndex = 3
        Me.slotProbe.Text = "Probe Slots by Name and by Numbers (and Percentage)"
        Me.slotProbe.UseVisualStyleBackColor = True
        '
        'probeQuiet
        '
        Me.probeQuiet.AutoSize = True
        Me.probeQuiet.Location = New System.Drawing.Point(10, 12)
        Me.probeQuiet.Name = "probeQuiet"
        Me.probeQuiet.Size = New System.Drawing.Size(89, 19)
        Me.probeQuiet.TabIndex = 1
        Me.probeQuiet.Text = "Quiet Probe"
        Me.probeQuiet.UseVisualStyleBackColor = True
        '
        'Localization
        '
        Me.Localization.Controls.Add(Me.Label8)
        Me.Localization.Controls.Add(Me.Languages)
        Me.Localization.Controls.Add(Me.Label7)
        Me.Localization.Location = New System.Drawing.Point(4, 24)
        Me.Localization.Name = "Localization"
        Me.Localization.Size = New System.Drawing.Size(639, 420)
        Me.Localization.TabIndex = 5
        Me.Localization.Text = "Localization"
        Me.Localization.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(620, 60)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'Languages
        '
        Me.Languages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Languages.FormattingEnabled = True
        Me.Languages.Items.AddRange(New Object() {"Chinese (Simplified - China - chi)", "Chinese (Simplified - China - chi) (Translated)", "English (United States - eng)", "French (France - fre)", "German (Germany - ger)", "Hindi (India - ind)", "Hindi (India - ind) (Translated)", "Portuguese (Brazil - ptg)", "Spanish (Spain - spa)", "Dutch (Netherlands - dtc)", "Finnish (Finland - fin)", "Italian (Italy - ita)", "Malay (mal)", "Swedish (Switzerland (?) - swe)", "Turkish (Turkey - tky)", "Czech (cze)", "Indonesian (Indonesia - ndo)", "Polish (Poland - pol)", "Romanian (Roman - rmn)", "Uzbek (Uzbekistan - uzb)", "Croatian (Croatia - cro)", "Russian (Russia - rus)", "Russian (Russia - rus) (Translated)", "Arabic (Arab countries - arb)", "Arabic (Arab countries - arb) (Translated)", "Japanese (Japan - jpn)", "Japanese (Japan - jpn) (Translated)", "Danish (dan)", "Vietnamese (Vietnam - vtn)", "Norwegian (nwg)", "Korean (Korea - kor)", "Korean (Korea - kor) (Translated)", "Slovak (Slovakia - slo)"})
        Me.Languages.Location = New System.Drawing.Point(194, 9)
        Me.Languages.Name = "Languages"
        Me.Languages.Size = New System.Drawing.Size(431, 23)
        Me.Languages.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Select your language on the list:"
        '
        'NetworkTab
        '
        Me.NetworkTab.Controls.Add(Me.FirstFTPProfile)
        Me.NetworkTab.Controls.Add(Me.LogFTPIP)
        Me.NetworkTab.Controls.Add(Me.LogFTPUsr)
        Me.NetworkTab.Controls.Add(Me.RetryDownload)
        Me.NetworkTab.Controls.Add(Me.Label20)
        Me.NetworkTab.Controls.Add(Me.DebugNPrefix)
        Me.NetworkTab.Controls.Add(Me.Label19)
        Me.NetworkTab.Controls.Add(Me.DebugPort)
        Me.NetworkTab.Controls.Add(Me.Label11)
        Me.NetworkTab.Location = New System.Drawing.Point(4, 24)
        Me.NetworkTab.Name = "NetworkTab"
        Me.NetworkTab.Size = New System.Drawing.Size(639, 420)
        Me.NetworkTab.TabIndex = 6
        Me.NetworkTab.Text = "Network"
        Me.NetworkTab.UseVisualStyleBackColor = True
        '
        'FirstFTPProfile
        '
        Me.FirstFTPProfile.AutoSize = True
        Me.FirstFTPProfile.Location = New System.Drawing.Point(16, 157)
        Me.FirstFTPProfile.Name = "FirstFTPProfile"
        Me.FirstFTPProfile.Size = New System.Drawing.Size(169, 19)
        Me.FirstFTPProfile.TabIndex = 38
        Me.FirstFTPProfile.Text = "Return only first FTP profile"
        Me.FirstFTPProfile.UseVisualStyleBackColor = True
        '
        'LogFTPIP
        '
        Me.LogFTPIP.AutoSize = True
        Me.LogFTPIP.Location = New System.Drawing.Point(16, 132)
        Me.LogFTPIP.Name = "LogFTPIP"
        Me.LogFTPIP.Size = New System.Drawing.Size(126, 19)
        Me.LogFTPIP.TabIndex = 37
        Me.LogFTPIP.Text = "Log FTP IP Address"
        Me.LogFTPIP.UseVisualStyleBackColor = True
        '
        'LogFTPUsr
        '
        Me.LogFTPUsr.AutoSize = True
        Me.LogFTPUsr.Location = New System.Drawing.Point(16, 107)
        Me.LogFTPUsr.Name = "LogFTPUsr"
        Me.LogFTPUsr.Size = New System.Drawing.Size(123, 19)
        Me.LogFTPUsr.TabIndex = 36
        Me.LogFTPUsr.Text = "Log FTP username"
        Me.LogFTPUsr.UseVisualStyleBackColor = True
        '
        'RetryDownload
        '
        Me.RetryDownload.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RetryDownload.Location = New System.Drawing.Point(144, 73)
        Me.RetryDownload.MaxLength = 3
        Me.RetryDownload.Name = "RetryDownload"
        Me.RetryDownload.Size = New System.Drawing.Size(149, 23)
        Me.RetryDownload.TabIndex = 35
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(13, 76)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(123, 15)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Download retry times:"
        '
        'DebugNPrefix
        '
        Me.DebugNPrefix.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DebugNPrefix.Location = New System.Drawing.Point(144, 44)
        Me.DebugNPrefix.MaxLength = 30
        Me.DebugNPrefix.Name = "DebugNPrefix"
        Me.DebugNPrefix.Size = New System.Drawing.Size(149, 23)
        Me.DebugNPrefix.TabIndex = 33
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(13, 47)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(103, 15)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Debug nick prefix:"
        '
        'DebugPort
        '
        Me.DebugPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DebugPort.Location = New System.Drawing.Point(144, 15)
        Me.DebugPort.MaxLength = 5
        Me.DebugPort.Name = "DebugPort"
        Me.DebugPort.Size = New System.Drawing.Size(149, 23)
        Me.DebugPort.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 15)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Debug port:"
        '
        'Others
        '
        Me.Others.Controls.Add(Me.HiddenFiles)
        Me.Others.Controls.Add(Me.LongTimeDate)
        Me.Others.Controls.Add(Me.StartScroll)
        Me.Others.Controls.Add(Me.FullParseMode)
        Me.Others.Controls.Add(Me.Label18)
        Me.Others.Controls.Add(Me.DebugMax)
        Me.Others.Controls.Add(Me.Label12)
        Me.Others.Controls.Add(Me.Screensave)
        Me.Others.Controls.Add(Me.Label17)
        Me.Others.Controls.Add(Me.tdCorner)
        Me.Others.Location = New System.Drawing.Point(4, 24)
        Me.Others.Name = "Others"
        Me.Others.Size = New System.Drawing.Size(639, 420)
        Me.Others.TabIndex = 4
        Me.Others.Text = "Others"
        Me.Others.UseVisualStyleBackColor = True
        '
        'HiddenFiles
        '
        Me.HiddenFiles.AutoSize = True
        Me.HiddenFiles.Location = New System.Drawing.Point(10, 173)
        Me.HiddenFiles.Name = "HiddenFiles"
        Me.HiddenFiles.Size = New System.Drawing.Size(223, 19)
        Me.HiddenFiles.TabIndex = 27
        Me.HiddenFiles.Text = "Show hidden files when listing locally"
        Me.HiddenFiles.UseVisualStyleBackColor = True
        '
        'LongTimeDate
        '
        Me.LongTimeDate.AutoSize = True
        Me.LongTimeDate.Location = New System.Drawing.Point(10, 148)
        Me.LongTimeDate.Name = "LongTimeDate"
        Me.LongTimeDate.Size = New System.Drawing.Size(111, 19)
        Me.LongTimeDate.TabIndex = 26
        Me.LongTimeDate.Text = "Long Time/Date"
        Me.LongTimeDate.UseVisualStyleBackColor = True
        '
        'StartScroll
        '
        Me.StartScroll.AutoSize = True
        Me.StartScroll.Location = New System.Drawing.Point(10, 123)
        Me.StartScroll.Name = "StartScroll"
        Me.StartScroll.Size = New System.Drawing.Size(259, 19)
        Me.StartScroll.TabIndex = 25
        Me.StartScroll.Text = "Scroll the kernel introduction text on startup"
        Me.StartScroll.UseVisualStyleBackColor = True
        '
        'FullParseMode
        '
        Me.FullParseMode.AutoSize = True
        Me.FullParseMode.Location = New System.Drawing.Point(10, 98)
        Me.FullParseMode.Name = "FullParseMode"
        Me.FullParseMode.Size = New System.Drawing.Size(366, 19)
        Me.FullParseMode.TabIndex = 24
        Me.FullParseMode.Text = "Parse entire directory on size when listing files and folders locally"
        Me.FullParseMode.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(252, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 15)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "bytes"
        '
        'DebugMax
        '
        Me.DebugMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DebugMax.Location = New System.Drawing.Point(138, 67)
        Me.DebugMax.MaxLength = 30
        Me.DebugMax.Name = "DebugMax"
        Me.DebugMax.Size = New System.Drawing.Size(107, 23)
        Me.DebugMax.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 15)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Debug maximum size:"
        '
        'Screensave
        '
        Me.Screensave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Screensave.FormattingEnabled = True
        Me.Screensave.Items.AddRange(New Object() {"colorMix", "colorMix255", "disco", "disco255", "matrix", "glitterMatrix", "glitterColor", "glitterColor255", "lines", "lines255", "aptErrorSim", "hackuserFromAD", "Custom (by mods)"})
        Me.Screensave.Location = New System.Drawing.Point(138, 38)
        Me.Screensave.Name = "Screensave"
        Me.Screensave.Size = New System.Drawing.Size(149, 23)
        Me.Screensave.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 41)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 15)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Select Screensaver:"
        '
        'tdCorner
        '
        Me.tdCorner.AutoSize = True
        Me.tdCorner.Location = New System.Drawing.Point(10, 13)
        Me.tdCorner.Name = "tdCorner"
        Me.tdCorner.Size = New System.Drawing.Size(235, 19)
        Me.tdCorner.TabIndex = 12
        Me.tdCorner.Text = "Show Time/Date on Upper Right Corner"
        Me.tdCorner.UseVisualStyleBackColor = True
        '
        'ScreenOpen
        '
        Me.ScreenOpen.DefaultExt = "SS.m"
        Me.ScreenOpen.FileName = "screensaver"
        Me.ScreenOpen.Filter = "Screensaver file|*SS.m"
        Me.ScreenOpen.InitialDirectory = "%USERPROFILE%\KSMods"
        Me.ScreenOpen.Title = "Select a screensaver"
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(419, 37)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.VersionLabel.Size = New System.Drawing.Size(237, 15)
        Me.VersionLabel.TabIndex = 2
        Me.VersionLabel.Text = "KS Version: K.K.K.K | Config Version: C.C.C.C"
        '
        'Configurator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 484)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Configurator"
        Me.Text = "Kernel Simulator Configuration Tool"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.LogIn.ResumeLayout(False)
        Me.LogIn.PerformLayout()
        Me.Shell.ResumeLayout(False)
        Me.Shell.PerformLayout()
        Me.Hardware.ResumeLayout(False)
        Me.Hardware.PerformLayout()
        Me.Localization.ResumeLayout(False)
        Me.Localization.PerformLayout()
        Me.NetworkTab.ResumeLayout(False)
        Me.NetworkTab.PerformLayout()
        Me.Others.ResumeLayout(False)
        Me.Others.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents General As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents userNameColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents hostNameColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents uncontError As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents contError As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents licenseColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents textColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RootPwd As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RootPC As System.Windows.Forms.CheckBox
    Friend WithEvents MaintMode As System.Windows.Forms.CheckBox
    Friend WithEvents BootPrompt As System.Windows.Forms.CheckBox
    Friend WithEvents LogIn As System.Windows.Forms.TabPage
    Friend WithEvents clslogin As System.Windows.Forms.CheckBox
    Friend WithEvents motdShow As System.Windows.Forms.CheckBox
    Friend WithEvents Shell As System.Windows.Forms.TabPage
    Friend WithEvents simHelp As System.Windows.Forms.CheckBox
    Friend WithEvents colorShell As System.Windows.Forms.CheckBox
    Friend WithEvents Hardware As System.Windows.Forms.TabPage
    Friend WithEvents slotProbe As System.Windows.Forms.CheckBox
    Friend WithEvents probeQuiet As System.Windows.Forms.CheckBox
    Friend WithEvents Others As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tdCorner As System.Windows.Forms.CheckBox
    Friend WithEvents HostName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefHelpColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CmdHelpColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents inputColor As System.Windows.Forms.ComboBox
    Friend WithEvents backgroundColor As System.Windows.Forms.ComboBox
    Friend WithEvents OpenSourceLibrariesUsedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Localization As TabPage
    Friend WithEvents Languages As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Screensave As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ScreenOpen As OpenFileDialog
    Friend WithEvents Label18 As Label
    Friend WithEvents DebugMax As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents StageColor As ComboBox
    Friend WithEvents UpdateStart As CheckBox
    Friend WithEvents UsersShow As CheckBox
    Friend WithEvents HiddenFiles As CheckBox
    Friend WithEvents LongTimeDate As CheckBox
    Friend WithEvents StartScroll As CheckBox
    Friend WithEvents FullParseMode As CheckBox
    Friend WithEvents Label22 As Label
    Friend WithEvents ErrorColor As ComboBox
    Friend WithEvents NetworkTab As TabPage
    Friend WithEvents LogFTPIP As CheckBox
    Friend WithEvents LogFTPUsr As CheckBox
    Friend WithEvents RetryDownload As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents DebugNPrefix As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents DebugPort As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents FirstFTPProfile As CheckBox
    Friend WithEvents VersionLabel As Label
End Class
