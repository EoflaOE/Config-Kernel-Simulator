﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Kernel_Simulator_Configuration_Tool.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fswiss\fprq2\fcharset0 Segoe UI;}{\f1\fswiss\fcharset0 Arial;}}
        '''{\colortbl ;\red0\green0\blue255;\red0\green128\blue128;}
        '''{\*\generator Msftedit 5.41.15.1515;}\viewkind4\uc1\pard\cf1\f0\fs48 MadMilkman.Ini\par
        '''\fs24\par
        '''\cf2 Source code: https://github.com/MarioZ/MadMilkman.Ini\par
        '''\par
        '''Copyright (c) 2016, Mario Zorica\par
        '''\par
        '''License (Apache 2.0): https://github.com/MarioZ/MadMilkman.Ini/blob/master/LICENSE\cf0\f1\fs20\par
        '''}
        ''' .
        '''</summary>
        Friend ReadOnly Property AboutLibs() As String
            Get
                Return ResourceManager.GetString("AboutLibs", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {\rtf1\adeflang1025\ansi\ansicpg1252\uc1\adeff1\deff0\stshfdbch31505\stshfloch31506\stshfhich31506\stshfbi0\deflang1033\deflangfe1033\themelang1033\themelangfe0\themelangcs0{\fonttbl{\f0\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\f1\fbidi \fswiss\fcharset0\fprq2{\*\panose 020b0604020202020204}Arial;}
        '''{\f2\fbidi \fmodern\fcharset0\fprq1{\*\panose 02070309020205020404}Courier New;}{\f3\fbidi \froman\fcharset2\fprq2{\*\panose 05050102010706020507}Symbol;}{\f10\fbidi \fnil\ [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property General() As String
            Get
                Return ResourceManager.GetString("General", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fswiss\fprq2\fcharset0 Segoe UI;}{\f1\fswiss\fcharset0 Arial;}}
        '''{\colortbl ;\red0\green0\blue255;\red0\green128\blue128;\red0\green0\blue0;}
        '''{\*\generator Msftedit 5.41.15.1515;}\viewkind4\uc1\pard\cf1\f0\fs48 Hardware Section\par
        '''\fs24\par
        '''\cf2 - Quiet Probe: \cf0 When enabled, the probing will be quiet.\par
        '''\par
        '''\cf2 - Probe Slots by Name and by Numbers (and Percentage): \cf3 When enabled, the RAM chips will be probed.\cf0\f1\fs20\par
        '''}
        ''' .
        '''</summary>
        Friend ReadOnly Property Hardware() As String
            Get
                Return ResourceManager.GetString("Hardware", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fswiss\fprq2\fcharset0 Segoe UI;}}
        '''{\colortbl ;\red0\green0\blue255;\red0\green128\blue128;\red0\green0\blue0;}
        '''{\*\generator Riched20 10.0.17763}\viewkind4\uc1 
        '''\pard\cf1\f0\fs48 Localization Section\par
        '''\fs24\par
        '''\cf2 - Language: \cf3 This lets you select your language from the list.\par
        '''}
        ''' .
        '''</summary>
        Friend ReadOnly Property Localization() As String
            Get
                Return ResourceManager.GetString("Localization", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {\rtf1\adeflang1025\ansi\ansicpg1252\uc1\adeff31507\deff0\stshfdbch31505\stshfloch31506\stshfhich31506\stshfbi31507\deflang1033\deflangfe1033\themelang1033\themelangfe0\themelangcs0{\fonttbl{\f0\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\f1\fbidi \fswiss\fcharset0\fprq2{\*\panose 020b0604020202020204}Arial;}
        '''{\f34\fbidi \froman\fcharset0\fprq2{\*\panose 02040503050406030204}Cambria Math;}{\f43\fbidi \fswiss\fcharset0\fprq2{\*\panose 020b0502040204020203}Segoe UI;}{\flom [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Login() As String
            Get
                Return ResourceManager.GetString("Login", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fswiss\fprq2\fcharset0 Segoe UI;}{\f1\fswiss\fcharset0 Arial;}}
        '''{\colortbl ;\red0\green0\blue255;}
        '''{\*\generator Msftedit 5.41.15.1515;}\viewkind4\uc1\pard\cf1\f0\fs48 Welcome to Kernel Simulator Configuration Tool!\par
        '''\fs24\par
        '''\cf0 This tool allows you to configure Kernel Simulator in an easy way rather than the text way of editing. This tool has the available options, or checking and clearing the box, or editing the text like MOTD, MAL, etc.\par [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Main() As String
            Get
                Return ResourceManager.GetString("Main", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {\rtf1\adeflang1025\ansi\ansicpg1252\uc1\adeff1\deff0\stshfdbch31505\stshfloch31506\stshfhich31506\stshfbi0\deflang1033\deflangfe1033\themelang1033\themelangfe0\themelangcs0{\fonttbl{\f0\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\f1\fbidi \fswiss\fcharset0\fprq2{\*\panose 020b0604020202020204}Arial;}
        '''{\f2\fbidi \fmodern\fcharset0\fprq1{\*\panose 02070309020205020404}Courier New;}{\f3\fbidi \froman\fcharset2\fprq2{\*\panose 05050102010706020507}Symbol;}{\f10\fbidi \fnil\ [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Network() As String
            Get
                Return ResourceManager.GetString("Network", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {\rtf1\adeflang1025\ansi\ansicpg1252\uc1\adeff1\deff0\stshfdbch31505\stshfloch31506\stshfhich31506\stshfbi0\deflang1033\deflangfe1033\themelang1033\themelangfe0\themelangcs0{\fonttbl{\f0\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\f1\fbidi \fswiss\fcharset0\fprq2{\*\panose 020b0604020202020204}Arial;}
        '''{\f2\fbidi \fmodern\fcharset0\fprq1{\*\panose 02070309020205020404}Courier New;}{\f3\fbidi \froman\fcharset2\fprq2{\*\panose 05050102010706020507}Symbol;}{\f10\fbidi \fnil\ [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Others() As String
            Get
                Return ResourceManager.GetString("Others", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fswiss\fprq2\fcharset0 Segoe UI;}{\f1\fswiss\fcharset0 Arial;}}
        '''{\colortbl ;\red0\green0\blue255;\red0\green128\blue128;\red0\green0\blue0;}
        '''{\*\generator Msftedit 5.41.15.1515;}\viewkind4\uc1\pard\cf1\f0\fs48 Shell Section\par
        '''\fs24\par
        '''\cf2 - Colored Shell: \cf3 When enabled, there will be a colorful shell.\par
        '''\par
        '''\cf2 - Simplified Help Command: \cf0 When enabled, the help command will only show commands what&apos;s available, not the descriptions. [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Shell() As String
            Get
                Return ResourceManager.GetString("Shell", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
